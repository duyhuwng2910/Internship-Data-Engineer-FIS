using DW_Test.DWEModels;
using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Consignment_report
{
    public interface IConsignmentService : IServiceScoped
    {
        public Task<bool> Dim_WarehouseInit();

        public Task<bool> Init();

        public Task Transform();
    }
    public class ConsignmentService : IConsignmentService
    {
        private DWEContext DWEContext;

        private DataContext DataContext;

        public ConsignmentService(DWEContext DWEContext, DataContext DataContext)
        {
            this.DWEContext = DWEContext;
            this.DataContext = DataContext;
        }

        public async Task<bool> Dim_WarehouseInit()
        {
            List<DWEModels.Dim_WarehouseDAO> Remote = await DWEContext.Dim_Warehouse.ToListAsync();

            List<Models.Dim_WarehouseDAO> Local = await DataContext.Dim_Warehouse.ToListAsync();

            List<Dim_Warehouse> HashRemote = Remote.Select(x => new Dim_Warehouse(x)).ToList();

            List<Dim_Warehouse> HashLocal = Local.Select(x => new Dim_Warehouse(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Models.Dim_WarehouseDAO> InsertList = new List<Models.Dim_WarehouseDAO>();

            List<Models.Dim_WarehouseDAO> UpdateList = new List<Models.Dim_WarehouseDAO>();

            List<Models.Dim_WarehouseDAO> DeleteList = new List<Models.Dim_WarehouseDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var remote in Remote)
                {
                    Local.Add(new Models.Dim_WarehouseDAO()
                    {
                        WhsCode = remote.WhsCode,
                        Location = remote.Location,
                        WhsBranchName = remote.WhsBranchName,
                        WarehouseLevel1Name = remote.WarehouseLevel1Name,
                        WarehouseLevel2Name = remote.WarehouseLevel2Name
                    });
                }
                await DataContext.BulkMergeAsync(Local);
            }
            else
            {
                for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
                {
                    if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                    {
                        InsertList.Add(new Models.Dim_WarehouseDAO()
                        {
                            WhsCode = HashRemote[j].WhsCode,
                            Location = HashRemote[j].Location,
                            WhsBranchName = HashRemote[j].WhsBranchName,
                            WarehouseLevel1Name = HashRemote[j].WarehouseLevel1Name,
                            WarehouseLevel2Name = HashRemote[j].WarehouseLevel2Name
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Models.Dim_WarehouseDAO()
                            {
                                WarehouseId = HashLocal[index].WarehouseId,
                                WhsCode = HashLocal[index].WhsCode,
                                Location = HashRemote[j].Location,
                                WhsBranchName = HashRemote[j].WhsBranchName,
                                WarehouseLevel1Name = HashRemote[j].WarehouseLevel1Name,
                                WarehouseLevel2Name = HashRemote[j].WarehouseLevel2Name
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Models.Dim_WarehouseDAO()
                        {
                            WarehouseId = HashLocal[index].WarehouseId,
                            WhsCode = HashLocal[index].WhsCode,
                            Location = HashLocal[index].Location,
                            WhsBranchName = HashLocal[index].WhsBranchName,
                            WarehouseLevel1Name = HashLocal[index].WarehouseLevel1Name,
                            WarehouseLevel2Name = HashLocal[index].WarehouseLevel2Name
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Models.Dim_WarehouseDAO()
                        {
                            WhsCode = HashRemote[index].WhsCode,
                            Location = HashRemote[index].Location,
                            WhsBranchName = HashRemote[index].WhsBranchName,
                            WarehouseLevel1Name = HashRemote[index].WarehouseLevel1Name,
                            WarehouseLevel2Name = HashRemote[index].WarehouseLevel2Name
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Models.Dim_WarehouseDAO()
                        {
                            WarehouseId = HashLocal[index].WarehouseId,
                            WhsCode = HashLocal[index].WhsCode,
                            Location = HashLocal[index].Location,
                            WhsBranchName = HashLocal[index].WhsBranchName,
                            WarehouseLevel1Name = HashLocal[index].WarehouseLevel1Name,
                            WarehouseLevel2Name = HashLocal[index].WarehouseLevel2Name
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
                await DataContext.BulkMergeAsync(UpdateList);
            }

            return true;
        }

        public async Task<bool> Init()
        {
            List<DWEModels.Raw_B003DAO> Raw_B003RemoteDAOs = await DWEContext.Raw_B003.ToListAsync();

            List<Models.Raw_B003DAO> Raw_B003LocalDAOs = await DataContext.Raw_B003.ToListAsync();

            List<Raw_B003> HashRemote = Raw_B003RemoteDAOs.Select(x => new Raw_B003(x)).ToList();

            List<Raw_B003> HashLocal = Raw_B003LocalDAOs.Select(x => new Raw_B003(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Models.Raw_B003DAO> InsertList = new List<Models.Raw_B003DAO>();

            List<Models.Raw_B003DAO> UpdateList = new List<Models.Raw_B003DAO>();

            List<Models.Raw_B003DAO> DeleteList = new List<Models.Raw_B003DAO>();

            int index = 0;

            if (Raw_B003LocalDAOs.Count == 0)
            {
                await DataContext.BulkMergeAsync(Raw_B003RemoteDAOs);
            }
            else
            {
                for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
                {
                    if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                    {
                        InsertList.Add(new Models.Raw_B003DAO()
                        {
                            DocEntry = HashRemote[j].DocEntry,
                            BPLName = HashRemote[j].BPLName,
                            LineNum = HashRemote[j].LineNum,
                            ItemCode = HashRemote[j].ItemCode,
                            Ten_HH = HashRemote[j].Ten_HH,
                            U_KM = HashRemote[j].U_KM,
                            Donvitinh = HashRemote[j].Donvitinh,
                            Soluong_gui = HashRemote[j].Soluong_gui,
                            Luongxuat = HashRemote[j].Luongxuat,
                            Conton = HashRemote[j].Conton,
                            DonGiaHoaDon = HashRemote[j].DonGiaHoaDon,
                            ThanhTien = HashRemote[j].ThanhTien,
                            Thuesuat = HashRemote[j].Thuesuat,
                            NgayHoaDon = HashRemote[j].NgayHoaDon,
                            KhoaHD = HashRemote[j].KhoaHD,
                            SoHD = HashRemote[j].SoHD,
                            Seri = HashRemote[j].Seri,
                            Kho = HashRemote[j].Kho,
                            U_Code = HashRemote[j].U_Code,
                            U_Description_vn = HashRemote[j].U_Description_vn,
                            Ma_KH = HashRemote[j].Ma_KH,
                            TenKH = HashRemote[j].TenKH,
                            TenKHLe = HashRemote[j].TenKHLe,
                            PhongBH = HashRemote[j].PhongBH,
                            Thukho = HashRemote[j].Thukho,
                            XN = HashRemote[j].XN,
                            Loai_NX = HashRemote[j].Loai_NX,
                            BP = HashRemote[j].BP
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Models.Raw_B003DAO()
                            {
                                Id = HashLocal[index].Id,
                                DocEntry = HashRemote[j].DocEntry,
                                BPLName = HashRemote[j].BPLName,
                                LineNum = HashRemote[j].LineNum,
                                ItemCode = HashLocal[index].ItemCode,
                                Ten_HH = HashRemote[j].Ten_HH,
                                U_KM = HashRemote[j].U_KM,
                                Donvitinh = HashRemote[j].Donvitinh,
                                Soluong_gui = HashRemote[j].Soluong_gui,
                                Luongxuat = HashRemote[j].Luongxuat,
                                Conton = HashRemote[j].Conton,
                                DonGiaHoaDon = HashRemote[j].DonGiaHoaDon,
                                ThanhTien = HashRemote[j].ThanhTien,
                                Thuesuat = HashRemote[j].Thuesuat,
                                NgayHoaDon = HashRemote[j].NgayHoaDon,
                                KhoaHD = HashRemote[j].KhoaHD,
                                SoHD = HashRemote[j].SoHD,
                                Seri = HashRemote[j].Seri,
                                Kho = HashRemote[j].Kho,
                                U_Code = HashLocal[index].U_Code,
                                U_Description_vn = HashRemote[j].U_Description_vn,
                                Ma_KH = HashRemote[j].Ma_KH,
                                TenKH = HashRemote[j].TenKH,
                                TenKHLe = HashRemote[j].TenKHLe,
                                PhongBH = HashRemote[j].PhongBH,
                                Thukho = HashRemote[j].Thukho,
                                XN = HashRemote[j].XN,
                                Loai_NX = HashRemote[j].Loai_NX,
                                BP = HashRemote[j].BP
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Models.Raw_B003DAO()
                        {
                            Id = HashLocal[index].Id,
                            DocEntry = HashLocal[index].DocEntry,
                            BPLName = HashLocal[index].BPLName,
                            LineNum = HashLocal[index].LineNum,
                            ItemCode = HashLocal[index].ItemCode,
                            Ten_HH = HashLocal[index].Ten_HH,
                            U_KM = HashLocal[index].U_KM,
                            Donvitinh = HashLocal[index].Donvitinh,
                            Soluong_gui = HashLocal[index].Soluong_gui,
                            Luongxuat = HashLocal[index].Luongxuat,
                            Conton = HashLocal[index].Conton,
                            DonGiaHoaDon = HashLocal[index].DonGiaHoaDon,
                            ThanhTien = HashLocal[index].ThanhTien,
                            Thuesuat = HashLocal[index].Thuesuat,
                            NgayHoaDon = HashLocal[index].NgayHoaDon,
                            KhoaHD = HashLocal[index].KhoaHD,
                            SoHD = HashLocal[index].SoHD,
                            Seri = HashLocal[index].Seri,
                            Kho = HashLocal[index].Kho,
                            U_Code = HashLocal[index].U_Code,
                            U_Description_vn = HashLocal[index].U_Description_vn,
                            Ma_KH = HashLocal[index].Ma_KH,
                            TenKH = HashLocal[index].TenKH,
                            TenKHLe = HashLocal[index].TenKHLe,
                            PhongBH = HashLocal[index].PhongBH,
                            Thukho = HashLocal[index].Thukho,
                            XN = HashLocal[index].XN,
                            Loai_NX = HashLocal[index].Loai_NX,
                            BP = HashLocal[index].BP
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Models.Raw_B003DAO()
                        {
                            DocEntry = HashRemote[index].DocEntry,
                            BPLName = HashRemote[index].BPLName,
                            LineNum = HashRemote[index].LineNum,
                            ItemCode = HashRemote[index].ItemCode,
                            Ten_HH = HashRemote[index].Ten_HH,
                            U_KM = HashRemote[index].U_KM,
                            Donvitinh = HashRemote[index].Donvitinh,
                            Soluong_gui = HashRemote[index].Soluong_gui,
                            Luongxuat = HashRemote[index].Luongxuat,
                            Conton = HashRemote[index].Conton,
                            DonGiaHoaDon = HashRemote[index].DonGiaHoaDon,
                            ThanhTien = HashRemote[index].ThanhTien,
                            Thuesuat = HashRemote[index].Thuesuat,
                            NgayHoaDon = HashRemote[index].NgayHoaDon,
                            KhoaHD = HashRemote[index].KhoaHD,
                            SoHD = HashRemote[index].SoHD,
                            Seri = HashRemote[index].Seri,
                            Kho = HashRemote[index].Kho,
                            U_Code = HashRemote[index].U_Code,
                            U_Description_vn = HashRemote[index].U_Description_vn,
                            Ma_KH = HashRemote[index].Ma_KH,
                            TenKH = HashRemote[index].TenKH,
                            TenKHLe = HashRemote[index].TenKHLe,
                            PhongBH = HashRemote[index].PhongBH,
                            Thukho = HashRemote[index].Thukho,
                            XN = HashRemote[index].XN,
                            Loai_NX = HashRemote[index].Loai_NX,
                            BP = HashRemote[index].BP
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Models.Raw_B003DAO()
                        {
                            Id = HashLocal[index].Id,
                            DocEntry = HashLocal[index].DocEntry,
                            BPLName = HashLocal[index].BPLName,
                            LineNum = HashLocal[index].LineNum,
                            ItemCode = HashLocal[index].ItemCode,
                            Ten_HH = HashLocal[index].Ten_HH,
                            U_KM = HashLocal[index].U_KM,
                            Donvitinh = HashLocal[index].Donvitinh,
                            Soluong_gui = HashLocal[index].Soluong_gui,
                            Luongxuat = HashLocal[index].Luongxuat,
                            Conton = HashLocal[index].Conton,
                            DonGiaHoaDon = HashLocal[index].DonGiaHoaDon,
                            ThanhTien = HashLocal[index].ThanhTien,
                            Thuesuat = HashLocal[index].Thuesuat,
                            NgayHoaDon = HashLocal[index].NgayHoaDon,
                            KhoaHD = HashLocal[index].KhoaHD,
                            SoHD = HashLocal[index].SoHD,
                            Seri = HashLocal[index].Seri,
                            Kho = HashLocal[index].Kho,
                            U_Code = HashLocal[index].U_Code,
                            U_Description_vn = HashLocal[index].U_Description_vn,
                            Ma_KH = HashLocal[index].Ma_KH,
                            TenKH = HashLocal[index].TenKH,
                            TenKHLe = HashLocal[index].TenKHLe,
                            PhongBH = HashLocal[index].PhongBH,
                            Thukho = HashLocal[index].Thukho,
                            XN = HashLocal[index].XN,
                            Loai_NX = HashLocal[index].Loai_NX,
                            BP = HashLocal[index].BP
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
                await DataContext.BulkMergeAsync(UpdateList);
            }

            return true;
        }

        public async Task Transform()
        {
            await Build_Fact_Item_Whs_Consignment();
        }

        private async Task<bool> Build_Fact_Item_Whs_Consignment()
        {
            List<Models.Raw_B003DAO> Raw_B003DAOs = await DataContext.Raw_B003.ToListAsync();

            List<Models.Dim_RD_ItemDAO> Dim_RD_ItemDAOs = await DataContext.Dim_RD_Item.ToListAsync();

            List<Models.Dim_RD_CustomerDAO> Dim_RD_CustomerDAOs = await DataContext.Dim_RD_Customer.ToListAsync();

            List<Models.Dim_WarehouseDAO> Dim_WarehouseDAOs = await DataContext.Dim_Warehouse.ToListAsync();

            List<Models.Fact_Item_Whs_ConsignmentDAO> Fact_Item_Whs_ConsignmentDAOs = new List<Models.Fact_Item_Whs_ConsignmentDAO>();
            
            foreach(var raw in Raw_B003DAOs)
            {
                var customer = Dim_RD_CustomerDAOs.Where(x => x.CustomerCode == raw.Ma_KH).FirstOrDefault();

                var item = Dim_RD_ItemDAOs.Where(x => x.ItemCode == raw.ItemCode).FirstOrDefault();

                var warehouse = Dim_WarehouseDAOs.Where(x => x.WhsCode == raw.Kho).FirstOrDefault();

                if (customer != null && item != null && warehouse != null)
                {
                    Fact_Item_Whs_ConsignmentDAOs.Add(new Models.Fact_Item_Whs_ConsignmentDAO()
                    {
                        ItemId = item.ItemId,
                        WarehouseId = warehouse.WarehouseId,
                        Consignment = raw.Soluong_gui,
                        CustomerId = customer.CustomerId
                    });
                }
            }

            await DataContext.Fact_Item_Whs_Consignment.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_Item_Whs_ConsignmentDAOs);

            return true;
        }
    }
}
