﻿using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
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

namespace DW_Test.Services.MActualService
{
    public interface IActualService : IServiceScoped
    {
        Task<bool> ActualInit();

        Task Transform();
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
                var CustomerDAO = Dim_CustomerDAOs.Where(x => x.CustomerName == Raw_B1_5_AcutalExportReport_RepDAO.Khach_hang
                && x.CustomerCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_KH).FirstOrDefault();

                var DateDAO = Dim_DateDAOs.Where(x => x.Date == Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat).FirstOrDefault();

                var ItemDAO = Dim_ItemDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH
                && x.ItemName == Raw_B1_5_AcutalExportReport_RepDAO.Ten_HH).FirstOrDefault();

                var NewItemDAO = Raw_Product_GroupDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH
                && ((x.M_StartDate <= Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat && x.M_EndDate >= Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat)
                || (x.M_EndDate == null && x.M_StartDate <= Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat))).FirstOrDefault();

                var VATItemDAO = Raw_Product_GroupDAOs.Where(x => x.ItemCode == Raw_B1_5_AcutalExportReport_RepDAO.Ma_HH
                && ((x.GTGT_StartDate <= Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat) && x.GTGT_EndDate >= Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat)
                || (x.GTGT_EndDate == null && x.GTGT_StartDate <= Raw_B1_5_AcutalExportReport_RepDAO.Ngay_xuat)).FirstOrDefault();

                Fact_Report_RevenueDAO Fact_Report_Revenue = Fact_Report_RevenueDAOs
                    .Where(x => x.CustomerId == CustomerDAO?.CustomerId).FirstOrDefault();

                if (Fact_Report_Revenue == null)
                {
                    Fact_Report_Revenue = new Fact_Report_RevenueDAO
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
                }
            }
            await DataContext.Fact_Report_Revenue.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_Report_RevenueDAOs);

            return true;
        }
    }
}
