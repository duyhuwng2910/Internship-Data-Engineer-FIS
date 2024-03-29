﻿using DW_Test.DWEModels;
using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Dim_CustomerDAO = DW_Test.Models.Dim_CustomerDAO;
using Dim_DateDAO = DW_Test.Models.Dim_DateDAO;
using Dim_ItemDAO = DW_Test.Models.Dim_ItemDAO;
using Dim_ItemNewItemGroupDAO = DW_Test.Models.Dim_ItemNewItemGroupDAO;
using Dim_ItemVATGroupDAO = DW_Test.Models.Dim_ItemVATGroupDAO;
using Raw_B1_5_ActualExportReport_RepDAO = DW_Test.Models.Raw_B1_5_ActualExportReport_RepDAO;

namespace DW_Test.Services.ActualService.ActualService
{
    public interface IActualService : IServiceScoped
    {
        Task<bool> ActualInit();

        Task<bool> IncrementalActualInit(DateTime Date);

        Task Transform();

        Task TransformByDate();
    }
    public class ActualService : IActualService
    {
        // ngữ cảnh data nằm trong local, tức là data của mình
        private DataContext DataContext;

        // ngữ cảnh data của khách hàng (remote)
        private DWEContext DWEContext;

        public ActualService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        /*
         * Hàm này dùng để init các data remote, trước hết là
         * delete các data trong local, sau đó kéo data từ remote 
         * về local rồi merge và đẩy lên data trong local
         */
        public async Task<bool> ActualInit()
        {
            // Biến var dạng List<Raw_B1_5_ActualExportReport_RepDAO> => local thì đi với DataContext
            var Raw_B1_5_ActualServiceLocalDAOs = await DataContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();

            // Biến var dạng List<DWEModels.Raw_B1_5_ActualExportReport_RepDAO> => remote đi với DWEContext
            var Raw_B1_5_ActualServiceRemoteDAOs = await DWEContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();

            // Hàm này dùng để xoá các data đang có ở trong local
            await DataContext.BulkDeleteAsync(Raw_B1_5_ActualServiceLocalDAOs);

            var Raw_B1_5_NewDAOs = Raw_B1_5_ActualServiceRemoteDAOs.Select(x => new Raw_B1_5_ActualExportReport_RepDAO()
            {
                Ma_HH = x.Ma_HH,
                Ten_HH = x.Ten_HH,
                Donvitinh = x.Donvitinh,
                XN = x.XN,
                Loai_NX = x.Loai_NX,
                SoHD = x.SoHD,
                Seri = x.Seri,
                KhoaHD = x.KhoaHD,
                Ngay_xuat = x.Ngay_xuat,
                thoidiem = x.thoidiem,
                Soluong = x.Soluong,
                DonGia = x.DonGia,
                ThanhTien = x.ThanhTien,
                coso = x.coso,
                Ma_KH = x.Ma_KH,
                Khach_hang = x.Khach_hang,
                Huy = x.Huy,
                DocEntry = x.DocEntry,
                TT = x.TT,
            }).ToList();

            // Sau khi gắn/kéo data từ phía khách hàng (remote) thì sẽ tiến hành merge
            await DataContext.BulkMergeAsync(Raw_B1_5_NewDAOs);

            return true;
        }

        // Hàm init bảng Raw 1.5 có tham số là Ngày lấy dữ liệu 
        // Tức là ta sẽ lấy dữ liệu trong bảng từ Ngày lấy dữ liệu
        // đến hiện tại
        public async Task<bool> IncrementalActualInit(DateTime Date)
        {
            // List dữ liệu trong bảng Raw_B1_5_ActualExportReport_Rep của Local
            var Raw_B1_5_ActualServiceLocalDAOs = await DataContext.Raw_B1_5_ActualExportReport_Rep
               .Where(x => x.Ngay_xuat >= Date).ToListAsync();

            // List dữ liệu đã tạo thêm thuộc tính Key và Value trong bảng của Local
            List<Raw_B1_5_ActualExportReport_Rep> HashLocal = Raw_B1_5_ActualServiceLocalDAOs
                .Select(x => new Raw_B1_5_ActualExportReport_Rep(x)).ToList();

            // List dữ liệu trong bảng Raw_B1_5_ActualExportReport_Rep của Remote
            var Raw_B1_5_ActualServiceRemoteDAOs = await DWEContext.Raw_B1_5_ActualExportReport_Rep
                .Where(x => x.Ngay_xuat >= Date).ToListAsync();

            // List dữ liệu đã tạo thêm thuộc tính Key và Value trong bảng của Remote
            List<Raw_B1_5_ActualExportReport_Rep> HashRemote = Raw_B1_5_ActualServiceRemoteDAOs
                .Select(x => new Raw_B1_5_ActualExportReport_Rep(x)).ToList();

            // Sắp xếp các dòng dữ liệu trong bảng theo thuộc tính Key của Local
            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            // Sắp xếp các dòng dữ liệu trong bảng theo thuộc tính Key của Remote
            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            // List dùng để insert dữ liệu mới vào Local
            List<Raw_B1_5_ActualExportReport_RepDAO> InsertList = new List<Raw_B1_5_ActualExportReport_RepDAO>();

            // List dùng để update dữ liệu cũ trong Local
            List<Raw_B1_5_ActualExportReport_RepDAO> UpdateList = new List<Raw_B1_5_ActualExportReport_RepDAO>();

            // List dùng để delete dữ liệu trong Local mà không còn tồn tại trong Remote
            List<Raw_B1_5_ActualExportReport_RepDAO> DeleteList = new List<Raw_B1_5_ActualExportReport_RepDAO>();

            // Chỉ số dùng cho HashLocal
            int index = 0;

            for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
            {
                // Nếu Hàm compare trả về < 0, tức là dòng dữ liệu này trong Local chưa có
                // Ta tiến hành thêm dòng này vào InsertList
                if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                {
                    var remote = HashRemote[j];

                    var actual = new Raw_B1_5_ActualExportReport_RepDAO()
                    {
                        Ma_HH = remote.Ma_HH,
                        Ten_HH = remote.Ten_HH,
                        Donvitinh = remote.Donvitinh,
                        XN = remote.XN,
                        Loai_NX = remote.Loai_NX,
                        SoHD = remote.SoHD,
                        Seri = remote.Seri,
                        KhoaHD = remote.KhoaHD,
                        Ngay_xuat = remote.Ngay_xuat,
                        thoidiem = remote.thoidiem,
                        Soluong = remote.Soluong,
                        DonGia = remote.DonGia,
                        ThanhTien = remote.ThanhTien,
                        coso = remote.coso,
                        Ma_KH = remote.Ma_KH,
                        Khach_hang = remote.Khach_hang,
                        Huy = remote.Huy,
                        DocEntry = remote.DocEntry,
                        TT = remote.TT,
                    };

                    InsertList.Add(actual);

                    j++;
                }
                
                // Nếu hàm Compare trả về = 0 tức là hai Key bằng nhau
                // Ta tiến hành so sánh hai Value
                else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                {
                    // Nếu hai Value khác nhau
                    // Ta tiến hành thêm dòng này vào UpdateList
                    if (HashRemote[j].Value != HashLocal[index].Value)
                    {
                        var remote = HashRemote[j];

                        var actual = new Raw_B1_5_ActualExportReport_RepDAO()
                        {
                            Id = HashLocal[index].Id,
                            Ma_HH = HashLocal[index].Ma_HH,
                            Ten_HH = remote.Ten_HH,
                            Donvitinh = remote.Donvitinh,
                            XN = remote.XN,
                            Loai_NX = remote.Loai_NX,
                            SoHD = remote.SoHD,
                            Seri = remote.Seri,
                            KhoaHD = remote.KhoaHD,
                            Ngay_xuat = remote.Ngay_xuat,
                            thoidiem = remote.thoidiem,
                            Soluong = remote.Soluong,
                            DonGia = remote.DonGia,
                            ThanhTien = remote.ThanhTien,
                            coso = remote.coso,
                            Ma_KH = remote.Ma_KH,
                            Khach_hang = remote.Khach_hang,
                            Huy = remote.Huy,
                            DocEntry = remote.DocEntry,
                            TT = remote.TT,
                        };

                        UpdateList.Add(actual);
                    }

                    j++;

                    index++;
                }

                // Nếu hàm Compare trả về > 0, tức là dòng này không tồn tại trong Remote
                // Ta tiến hành thêm dòng này vào DeleteList
                else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                {
                    var local = HashLocal[index];

                    var actual = new Raw_B1_5_ActualExportReport_RepDAO()
                    {
                        Id = local.Id,
                        Ma_HH = local.Ma_HH,
                        Ten_HH = local.Ten_HH,
                        Donvitinh = local.Donvitinh,
                        XN = local.XN,
                        Loai_NX = local.Loai_NX,
                        SoHD = local.SoHD,
                        Seri = local.Seri,
                        KhoaHD = local.KhoaHD,
                        Ngay_xuat = local.Ngay_xuat,
                        thoidiem = local.thoidiem,
                        Soluong = local.Soluong,
                        DonGia = local.DonGia,
                        ThanhTien = local.ThanhTien,
                        coso = local.coso,
                        Ma_KH = local.Ma_KH,
                        Khach_hang = local.Khach_hang,
                        Huy = local.Huy,
                        DocEntry = local.DocEntry,
                        TT = local.TT,
                    };

                    DeleteList.Add(actual);

                    index++;
                }
            }

            // Nếu mà index bằng số lượng dòng của HashLocal, đồng thời Key của hai dòng cuối cùng
            // ở hai bảng là khác nhau thì khi đó ta tiến thành thêm toàn bộ số dòng còn lại
            // trong HashRemote vào InsertList
            if (index == HashLocal.Count && HashLocal.Last().Key != HashRemote.Last().Key)
            {
                while (index < HashRemote.Count)
                {
                    var remote = HashRemote[index];

                    var actual = new Raw_B1_5_ActualExportReport_RepDAO()
                    {
                        Ma_HH = remote.Ma_HH,
                        Ten_HH = remote.Ten_HH,
                        Donvitinh = remote.Donvitinh,
                        XN = remote.XN,
                        Loai_NX = remote.Loai_NX,
                        SoHD = remote.SoHD,
                        Seri = remote.Seri,
                        KhoaHD = remote.KhoaHD,
                        Ngay_xuat = remote.Ngay_xuat,
                        thoidiem = remote.thoidiem,
                        Soluong = remote.Soluong,
                        DonGia = remote.DonGia,
                        ThanhTien = remote.ThanhTien,
                        coso = remote.coso,
                        Ma_KH = remote.Ma_KH,
                        Khach_hang = remote.Khach_hang,
                        Huy = remote.Huy,
                        DocEntry = remote.DocEntry,
                        TT = remote.TT,
                    };

                    InsertList.Add(actual);

                    index++;
                }
            }

            // Nếu index nhỏ hơn số dòng của HashLocal, tức là số dòng còn lại chưa được so sánh
            // trong HashLocal là các dòng không còn tồn tại trong HashRemote
            // Ta tiến hành thêm toàn bộ chúng vào DeleteList
            else if (index < HashLocal.Count)
            {
                while (index < HashLocal.Count)
                {
                    var local = HashLocal[index];

                    var actual = new Raw_B1_5_ActualExportReport_RepDAO()
                    {
                        Id = local.Id,
                        Ma_HH = local.Ma_HH,
                        Ten_HH = local.Ten_HH,
                        Donvitinh = local.Donvitinh,
                        XN = local.XN,
                        Loai_NX = local.Loai_NX,
                        SoHD = local.SoHD,
                        Seri = local.Seri,
                        KhoaHD = local.KhoaHD,
                        Ngay_xuat = local.Ngay_xuat,
                        thoidiem = local.thoidiem,
                        Soluong = local.Soluong,
                        DonGia = local.DonGia,
                        ThanhTien = local.ThanhTien,
                        coso = local.coso,
                        Ma_KH = local.Ma_KH,
                        Khach_hang = local.Khach_hang,
                        Huy = local.Huy,
                        DocEntry = local.DocEntry,
                        TT = local.TT,
                    };

                    DeleteList.Add(actual);

                    index++;
                }
            }

            // Đến đây ta sẽ tiến hành BulkDelete cho DeleteList
            // và BulkMerge cho InsertList và UpdateList
            // đối với DataContext
            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }

        public async Task Transform()
        {
            await Build_Fact_Report_Revenue();
        }

        public async Task<bool> Build_Fact_Report_Revenue()
        {
            List<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_RepDAOs
                = await DataContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();

            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            List<Dim_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_Customer.ToListAsync();

            List<Dim_DateDAO> Dim_DateDAOs = await DataContext.Dim_Date.ToListAsync();

            List<Dim_ItemDAO> Dim_ItemDAOs = await DataContext.Dim_Item.ToListAsync();

            List<Dim_ItemNewItemGroupDAO> Dim_ItemNewItemGroupDAOs = await DataContext.Dim_ItemNewItemGroup.ToListAsync();

            List<Dim_ItemVATGroupDAO> Dim_ItemVATGroupDAOs = await DataContext.Dim_ItemVATGroup.ToListAsync();

            List<Fact_Report_RevenueDAO> Fact_Report_RevenueDAOs = new List<Fact_Report_RevenueDAO>();

            foreach (var Raw_B1_5_AcutalExportReport_RepDAO in Raw_B1_5_ActualExportReport_RepDAOs)
            {
                var NgayXuat = Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat;

                var CustomerDAO = Dim_CustomerDAOs.Where(x => x.CustomerCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_KH).FirstOrDefault();

                var DateDAO = Dim_DateDAOs.Where(x => x.Date == Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat).FirstOrDefault();

                var ItemDAO = Dim_ItemDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH).FirstOrDefault();

                var NewItemDAO = Raw_Product_GroupDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH
                && ((x.M_StartDate <= NgayXuat) && (x.M_EndDate == null || x.M_EndDate >= NgayXuat))).FirstOrDefault();

                var VATItemDAO = Raw_Product_GroupDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH
                && ((x.GTGT_StartDate <= NgayXuat) && (x.GTGT_EndDate == null || x.GTGT_EndDate >= NgayXuat))).FirstOrDefault();

                if (CustomerDAO != null && ItemDAO != null && DateDAO != null)
                {
                    Fact_Report_RevenueDAO Fact_Report_Revenue = new Fact_Report_RevenueDAO
                    {
                        CustomerId = CustomerDAO.CustomerId,
                        DateKey = DateDAO.DateKey,
                        ItemId = ItemDAO.ItemId,
                        Quantity = Raw_B1_5_AcutalExportReport_RepDAO.Soluong ?? 0,
                        UnitPrice = Raw_B1_5_AcutalExportReport_RepDAO.DonGia ?? 0,
                        Revenue = Raw_B1_5_AcutalExportReport_RepDAO.ThanhTien ?? 0,
                    };
                    if (NewItemDAO != null)
                    {
                        Fact_Report_Revenue.ItemNewItemGroupId = Dim_ItemNewItemGroupDAOs.Select(x => x.ItemNewItemGroupId).FirstOrDefault();
                    }
                    if (VATItemDAO != null)
                    {
                        Fact_Report_Revenue.ItemVATGroupId = Dim_ItemVATGroupDAOs.Select(x => x.ItemVATGroupId).FirstOrDefault();
                    }
                    Fact_Report_RevenueDAOs.Add(Fact_Report_Revenue);
                }
            }
            await DataContext.Fact_Report_Revenue.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_Report_RevenueDAOs);

            return true;
        }

        public async Task TransformByDate()
        {
            await Build_Fact_Report_Revenue(DateTime.Today.AddMonths(-3));
        }

        // Hàm transform bảng Fact theo thời gian xác định trước là 3 tháng kể từ hiện tại
        public async Task<bool> Build_Fact_Report_Revenue(DateTime Date)
        {
            List<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_RepDAOs
                = await DataContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();

            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            List<Dim_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_Customer.ToListAsync();

            List<Dim_DateDAO> Dim_DateDAOs = await DataContext.Dim_Date.Where(x => x.Date >= Date).ToListAsync();

            Dim_DateDAOs = Dim_DateDAOs.OrderBy(x => x.DateKey).ToList();

            List<Dim_ItemDAO> Dim_ItemDAOs = await DataContext.Dim_Item.ToListAsync();

            List<Dim_ItemNewItemGroupDAO> Dim_ItemNewItemGroupDAOs = await DataContext.Dim_ItemNewItemGroup.ToListAsync();

            List<Dim_ItemVATGroupDAO> Dim_ItemVATGroupDAOs = await DataContext.Dim_ItemVATGroup.ToListAsync();

            // List dữ liệu của bảng Fact trong Local trong 3 tháng gần nhất
            // Ta sẽ tiến hành BulkDelete toàn bộ dữ liệu này để
            // transform lại dữ liệu 3 tháng gần nhất
            List<Fact_Report_RevenueDAO> Fact_Report_RevenueLocalDAOs = await DataContext.Fact_Report_Revenue
                .Where(x => x.DateKey >= Dim_DateDAOs.First().DateKey).ToListAsync();

            await DataContext.BulkDeleteAsync(Fact_Report_RevenueLocalDAOs);

            List<Fact_Report_RevenueDAO> Fact_Report_RevenueDAOs = new List<Fact_Report_RevenueDAO>();

            foreach (var Raw_B1_5_AcutalExportReport_RepDAO in Raw_B1_5_ActualExportReport_RepDAOs)
            {
                var NgayXuat = Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat;

                var CustomerDAO = Dim_CustomerDAOs.Where(x => x.CustomerCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_KH).FirstOrDefault();

                var DateDAO = Dim_DateDAOs.Where(x => x.Date == Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat).FirstOrDefault();

                var ItemDAO = Dim_ItemDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH).FirstOrDefault();

                var NewItemDAO = Raw_Product_GroupDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH
                && (x.M_StartDate <= NgayXuat) && (x.M_EndDate == null || x.M_EndDate >= NgayXuat)).FirstOrDefault();

                var VATItemDAO = Raw_Product_GroupDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH
                && (x.GTGT_StartDate <= NgayXuat) && (x.GTGT_EndDate == null || x.GTGT_EndDate >= NgayXuat)).FirstOrDefault();

                if (CustomerDAO != null && ItemDAO != null && DateDAO != null)
                {
                    Fact_Report_RevenueDAO Fact_Report_Revenue = new Fact_Report_RevenueDAO
                    {
                        CustomerId = CustomerDAO.CustomerId,
                        DateKey = DateDAO.DateKey,
                        ItemId = ItemDAO.ItemId,
                        Quantity = Raw_B1_5_AcutalExportReport_RepDAO.Soluong ?? 0,
                        UnitPrice = Raw_B1_5_AcutalExportReport_RepDAO.DonGia ?? 0,
                        Revenue = Raw_B1_5_AcutalExportReport_RepDAO.ThanhTien ?? 0,
                    };
                    if (NewItemDAO != null)
                    {
                        Fact_Report_Revenue.ItemNewItemGroupId = Dim_ItemNewItemGroupDAOs.Select(x => x.ItemNewItemGroupId).FirstOrDefault();
                    }
                    if (VATItemDAO != null)
                    {
                        Fact_Report_Revenue.ItemVATGroupId = Dim_ItemVATGroupDAOs.Select(x => x.ItemVATGroupId).FirstOrDefault();
                    }
                    Fact_Report_RevenueDAOs.Add(Fact_Report_Revenue);
                }
            }

            await DataContext.BulkMergeAsync(Fact_Report_RevenueDAOs);

            return true;
        }
    }
}
