using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Product_group
{
    public interface IProductGroupService : IServiceScoped
    {
        public Task<bool> Init(List<Raw_Product_ProductGroupDAO> remote);
    }
    public class ProductGroupService : IProductGroupService
    {
        private DataContext DataContext;

        public ProductGroupService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Init(List<Raw_Product_ProductGroupDAO> Remote)
        {
            List<Raw_Product_ProductGroupDAO> Local = await DataContext.Raw_Product_ProductGroup.ToListAsync();

            List<Raw_Product_ProductGroup> HashRemote = Remote.Select(x => new Raw_Product_ProductGroup(x)).ToList();

            List<Raw_Product_ProductGroup> HashLocal = Local.Select(x => new Raw_Product_ProductGroup(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Raw_Product_ProductGroupDAO> InsertList = new List<Raw_Product_ProductGroupDAO>();

            List<Raw_Product_ProductGroupDAO> UpdateList = new List<Raw_Product_ProductGroupDAO>();

            List<Raw_Product_ProductGroupDAO> DeleteList = new List<Raw_Product_ProductGroupDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var remote in Remote)
                {
                    Local.Add(new Raw_Product_ProductGroupDAO()
                    {
                        MaSP = remote.MaSP,
                        TenSP = remote.TenSP,
                        SPC1 = remote.SPC1,
                        SPC2 = remote.SPC2,
                        CongSuat = remote.CongSuat,
                        NhietDoMau = remote.NhietDoMau,
                        ChatLuong = remote.ChatLuong,
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
                        InsertList.Add(new Raw_Product_ProductGroupDAO()
                        {
                            MaSP = HashRemote[j].MaSP,
                            TenSP = HashRemote[j].TenSP,
                            SPC1 = HashRemote[j].SPC1,
                            SPC2 = HashRemote[j].SPC2,
                            CongSuat = HashRemote[j].CongSuat,
                            NhietDoMau = HashRemote[j].NhietDoMau,
                            ChatLuong = HashRemote[j].ChatLuong,
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Raw_Product_ProductGroupDAO()
                            {
                                Id = HashLocal[index].Id,
                                MaSP = HashLocal[index].MaSP,
                                TenSP = HashLocal[index].TenSP,
                                SPC1 = HashRemote[j].SPC1,
                                SPC2 = HashRemote[j].SPC2,
                                CongSuat = HashRemote[j].CongSuat,
                                NhietDoMau = HashRemote[j].NhietDoMau,
                                ChatLuong = HashRemote[j].ChatLuong,
                            });
                        }
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Raw_Product_ProductGroupDAO()
                        {
                            Id = HashLocal[index].Id,
                            MaSP = HashLocal[index].MaSP,
                            TenSP = HashLocal[index].TenSP,
                            SPC1 = HashLocal[index].SPC1,
                            SPC2 = HashLocal[index].SPC2,
                            CongSuat = HashLocal[index].CongSuat,
                            NhietDoMau = HashLocal[index].NhietDoMau,
                            ChatLuong = HashLocal[index].ChatLuong,
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Raw_Product_ProductGroupDAO()
                        {
                            MaSP = HashRemote[index].MaSP,
                            TenSP = HashRemote[index].TenSP,
                            SPC1 = HashRemote[index].SPC1,
                            SPC2 = HashRemote[index].SPC2,
                            CongSuat = HashRemote[index].CongSuat,
                            NhietDoMau = HashRemote[index].NhietDoMau,
                            ChatLuong = HashRemote[index].ChatLuong,
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Raw_Product_ProductGroupDAO()
                        {
                            Id = HashLocal[index].Id,
                            MaSP = HashLocal[index].MaSP,
                            TenSP = HashLocal[index].TenSP,
                            SPC1 = HashLocal[index].SPC1,
                            SPC2 = HashLocal[index].SPC2,
                            CongSuat = HashLocal[index].CongSuat,
                            NhietDoMau = HashLocal[index].NhietDoMau,
                            ChatLuong = HashLocal[index].ChatLuong,
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
