using DW_Test.DWEModels;
using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.ActualAndBookInventoryService
{
    public interface IActualAndBookInventoryService : IServiceScoped
    {
        public Task<bool> Init();
    }
    public class ActualAndBookInventoryService : IActualAndBookInventoryService
    {
        private DataContext DataContext;

        private DWEContext DWEContext;

        public ActualAndBookInventoryService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        public async Task<bool> Init()
        {
            List<DWEModels.Raw_A009DAO> Raw_A009RemoteDAOs = await DWEContext.Raw_A009.ToListAsync();

            List<Models.Raw_A009DAO> Raw_A009LocalDAOs = await DataContext.Raw_A009.ToListAsync();

            if (Raw_A009LocalDAOs.Count == 0)
            {
                await DataContext.BulkMergeAsync(Raw_A009RemoteDAOs);
            }
            else
            {
                List<Raw_A009> HashRemote = Raw_A009RemoteDAOs.Select(x => new Raw_A009(x)).ToList();

                List<Raw_A009> HashLocal = Raw_A009LocalDAOs.Select(x => new Raw_A009(x)).ToList();

                HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

                HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

                List<Models.Raw_A009DAO> InsertList = new List<Models.Raw_A009DAO>();

                List<Models.Raw_A009DAO> UpdateList = new List<Models.Raw_A009DAO>();

                List<Models.Raw_A009DAO> DeleteList = new List<Models.Raw_A009DAO>();

                int index = 0;

                for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
                {
                    if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                    {
                        InsertList.Add(new Models.Raw_A009DAO()
                        {
                            Nhom_SP = HashRemote[j].Nhom_SP,
                            Loai_SP = HashRemote[j].Loai_SP,
                            TenThuKho = HashRemote[j].TenThuKho,
                            ItemCode = HashRemote[j].ItemCode,
                            ItemName = HashRemote[j].ItemName,
                            Nhap = HashRemote[j].Nhap,
                            NhapLKThang = HashRemote[j].NhapLKThang,
                            XuatChungTu = HashRemote[j].XuatChungTu,
                            XuatChungTuLKThang = HashRemote[j].XuatChungTuLKThang,
                            ThucXuat = HashRemote[j].ThucXuat,
                            ThucXuatLKThang = HashRemote[j].ThucXuatLKThang,
                            XuatBan = HashRemote[j].XuatBan,
                            XuatBanLKThang = HashRemote[j].XuatBanLKThang,
                            TonChungTu = HashRemote[j].TonChungTu,
                            TonThucTe = HashRemote[j].TonThucTe,
                            HangGui = HashRemote[j].HangGui,
                            WhsCode = HashRemote[j].WhsCode,
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Models.Raw_A009DAO()
                            {
                                Id = HashLocal[index].Id,
                                Nhom_SP = HashRemote[j].Nhom_SP,
                                Loai_SP = HashRemote[j].Loai_SP,
                                TenThuKho = HashRemote[j].TenThuKho,
                                ItemCode = HashLocal[index].ItemCode,
                                ItemName = HashRemote[j].ItemName,
                                Nhap = HashRemote[j].Nhap,
                                NhapLKThang = HashRemote[j].NhapLKThang,
                                XuatChungTu = HashRemote[j].XuatChungTu,
                                XuatChungTuLKThang = HashRemote[j].XuatChungTuLKThang,
                                ThucXuat = HashRemote[j].ThucXuat,
                                ThucXuatLKThang = HashRemote[j].ThucXuatLKThang,
                                XuatBan = HashRemote[j].XuatBan,
                                XuatBanLKThang = HashRemote[j].XuatBanLKThang,
                                TonChungTu = HashRemote[j].TonChungTu,
                                TonThucTe = HashRemote[j].TonThucTe,
                                HangGui = HashRemote[j].HangGui,
                                WhsCode = HashLocal[index].WhsCode
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Models.Raw_A009DAO()
                        {
                            Id = HashLocal[index].Id,
                            Nhom_SP = HashLocal[index].Nhom_SP,
                            Loai_SP = HashLocal[index].Loai_SP,
                            TenThuKho = HashLocal[index].TenThuKho,
                            ItemCode = HashLocal[index].ItemCode,
                            ItemName = HashLocal[index].ItemName,
                            Nhap = HashLocal[index].Nhap,
                            NhapLKThang = HashLocal[index].NhapLKThang,
                            XuatChungTu = HashLocal[index].XuatChungTu,
                            XuatChungTuLKThang = HashLocal[index].XuatChungTuLKThang,
                            ThucXuat = HashLocal[index].ThucXuat,
                            ThucXuatLKThang = HashLocal[index].ThucXuatLKThang,
                            XuatBan = HashLocal[index].XuatBan,
                            XuatBanLKThang = HashLocal[index].XuatBanLKThang,
                            TonChungTu = HashLocal[index].TonChungTu,
                            TonThucTe = HashLocal[index].TonThucTe,
                            HangGui = HashLocal[index].HangGui,
                            WhsCode = HashLocal[index].WhsCode
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Models.Raw_A009DAO()
                        {
                            Nhom_SP = HashRemote[index].Nhom_SP,
                            Loai_SP = HashRemote[index].Loai_SP,
                            TenThuKho = HashRemote[index].TenThuKho,
                            ItemCode = HashRemote[index].ItemCode,
                            ItemName = HashRemote[index].ItemName,
                            Nhap = HashRemote[index].Nhap,
                            NhapLKThang = HashRemote[index].NhapLKThang,
                            XuatChungTu = HashRemote[index].XuatChungTu,
                            XuatChungTuLKThang = HashRemote[index].XuatChungTuLKThang,
                            ThucXuat = HashRemote[index].ThucXuat,
                            ThucXuatLKThang = HashRemote[index].ThucXuatLKThang,
                            XuatBan = HashRemote[index].XuatBan,
                            XuatBanLKThang = HashRemote[index].XuatBanLKThang,
                            TonChungTu = HashRemote[index].TonChungTu,
                            TonThucTe = HashRemote[index].TonThucTe,
                            HangGui = HashRemote[index].HangGui,
                            WhsCode = HashRemote[index].WhsCode
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Models.Raw_A009DAO()
                        {
                            Id = HashLocal[index].Id,
                            Nhom_SP = HashLocal[index].Nhom_SP,
                            Loai_SP = HashLocal[index].Loai_SP,
                            TenThuKho = HashLocal[index].TenThuKho,
                            ItemCode = HashLocal[index].ItemCode,
                            ItemName = HashLocal[index].ItemName,
                            Nhap = HashLocal[index].Nhap,
                            NhapLKThang = HashLocal[index].NhapLKThang,
                            XuatChungTu = HashLocal[index].XuatChungTu,
                            XuatChungTuLKThang = HashLocal[index].XuatChungTuLKThang,
                            ThucXuat = HashLocal[index].ThucXuat,
                            ThucXuatLKThang = HashLocal[index].ThucXuatLKThang,
                            XuatBan = HashLocal[index].XuatBan,
                            XuatBanLKThang = HashLocal[index].XuatBanLKThang,
                            TonChungTu = HashLocal[index].TonChungTu,
                            TonThucTe = HashLocal[index].TonThucTe,
                            HangGui = HashLocal[index].HangGui,
                            WhsCode = HashLocal[index].WhsCode
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
    }
}
