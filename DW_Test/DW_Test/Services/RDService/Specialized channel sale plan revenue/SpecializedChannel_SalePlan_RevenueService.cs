using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Specialized_channel_sale_plan_revenue
{
    public interface ISpecializedChannel_SalePlan_RevenueService : IServiceScoped
    {
        public Task<bool> Init(List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Remote);
    }
    public class SpecializedChannel_SalePlan_RevenueService : ISpecializedChannel_SalePlan_RevenueService
    {
        private DataContext DataContext;

        public SpecializedChannel_SalePlan_RevenueService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Init(List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Remote)
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Local =
                await DataContext.Raw_SpecializedChannel_SalePlan_Revenue.ToListAsync();

            List<Raw_SpecializedChannel_SalePlan_Revenue> HashRemote = Remote
                .Select(x => new Raw_SpecializedChannel_SalePlan_Revenue(x)).ToList();

            List<Raw_SpecializedChannel_SalePlan_Revenue> HashLocal = Local.
                Select(x => new Raw_SpecializedChannel_SalePlan_Revenue(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> InsertList = new List<Raw_SpecializedChannel_SalePlan_RevenueDAO>();

            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> UpdateList = new List<Raw_SpecializedChannel_SalePlan_RevenueDAO>();

            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> DeleteList = new List<Raw_SpecializedChannel_SalePlan_RevenueDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var remote in Remote)
                {
                    Local.Add(new Raw_SpecializedChannel_SalePlan_RevenueDAO()
                    {
                        TenMien = remote.TenMien,
                        TenKenh = remote.TenKenh,
                        MaKH = remote.MaKH,
                        TenKH = remote.TenKH,
                        KHNam = remote.KHNam,
                        KHQuy1 = remote.KHQuy1,
                        KHQuy2 = remote.KHQuy2,
                        KHQuy3 = remote.KHQuy3,
                        KHQuy4 = remote.KHQuy4,
                        KHThang1 = remote.KHThang1,
                        KHThang2 = remote.KHThang2,
                        KHThang3 = remote.KHThang3,
                        KHThang4 = remote.KHThang4,
                        KHThang5 = remote.KHThang5,
                        KHThang6 = remote.KHThang6,
                        KHThang7 = remote.KHThang7,
                        KHThang8 = remote.KHThang8,
                        KHThang9 = remote.KHThang9,
                        KHThang10 = remote.KHThang10,
                        KHThang11 = remote.KHThang11,
                        KHThang12 = remote.KHThang12,
                        Nam = remote.Nam,
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
                        InsertList.Add(new Raw_SpecializedChannel_SalePlan_RevenueDAO()
                        {
                            TenMien = HashRemote[j].TenMien,
                            TenKenh = HashRemote[j].TenKenh,
                            MaKH = HashRemote[j].MaKH,
                            TenKH = HashRemote[j].TenKH,
                            KHNam = HashRemote[j].KHNam,
                            KHQuy1 = HashRemote[j].KHQuy1,
                            KHQuy2 = HashRemote[j].KHQuy2,
                            KHQuy3 = HashRemote[j].KHQuy3,
                            KHQuy4 = HashRemote[j].KHQuy4,
                            KHThang1 = HashRemote[j].KHThang1,
                            KHThang2 = HashRemote[j].KHThang2,
                            KHThang3 = HashRemote[j].KHThang3,
                            KHThang4 = HashRemote[j].KHThang4,
                            KHThang5 = HashRemote[j].KHThang5,
                            KHThang6 = HashRemote[j].KHThang6,
                            KHThang7 = HashRemote[j].KHThang7,
                            KHThang8 = HashRemote[j].KHThang8,
                            KHThang9 = HashRemote[j].KHThang9,
                            KHThang10 = HashRemote[j].KHThang10,
                            KHThang11 = HashRemote[j].KHThang11,
                            KHThang12 = HashRemote[j].KHThang12,
                            Nam = HashRemote[j].Nam,
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value) 
                        {
                            UpdateList.Add(new Raw_SpecializedChannel_SalePlan_RevenueDAO()
                            {
                                Id = HashLocal[index].Id,
                                TenMien = HashLocal[index].TenMien,
                                TenKenh = HashLocal[index].TenKenh,
                                MaKH = HashLocal[index].MaKH,
                                TenKH = HashLocal[index].TenKH,
                                KHNam = HashRemote[j].KHNam,
                                KHQuy1 = HashRemote[j].KHQuy1,
                                KHQuy2 = HashRemote[j].KHQuy2,
                                KHQuy3 = HashRemote[j].KHQuy3,
                                KHQuy4 = HashRemote[j].KHQuy4,
                                KHThang1 = HashRemote[j].KHThang1,
                                KHThang2 = HashRemote[j].KHThang2,
                                KHThang3 = HashRemote[j].KHThang3,
                                KHThang4 = HashRemote[j].KHThang4,
                                KHThang5 = HashRemote[j].KHThang5,
                                KHThang6 = HashRemote[j].KHThang6,
                                KHThang7 = HashRemote[j].KHThang7,
                                KHThang8 = HashRemote[j].KHThang8,
                                KHThang9 = HashRemote[j].KHThang9,
                                KHThang10 = HashRemote[j].KHThang10,
                                KHThang11 = HashRemote[j].KHThang11,
                                KHThang12 = HashRemote[j].KHThang12,
                                Nam = HashRemote[j].Nam,
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Raw_SpecializedChannel_SalePlan_RevenueDAO()
                        {
                            Id = HashLocal[index].Id,
                            TenMien = HashLocal[index].TenMien,
                            TenKenh = HashLocal[index].TenKenh,
                            MaKH = HashLocal[index].MaKH,
                            TenKH = HashLocal[index].TenKH,
                            KHNam = HashLocal[index].KHNam,
                            KHQuy1 = HashLocal[index].KHQuy1,
                            KHQuy2 = HashLocal[index].KHQuy2,
                            KHQuy3 = HashLocal[index].KHQuy3,
                            KHQuy4 = HashLocal[index].KHQuy4,
                            KHThang1 = HashLocal[index].KHThang1,
                            KHThang2 = HashLocal[index].KHThang2,
                            KHThang3 = HashLocal[index].KHThang3,
                            KHThang4 = HashLocal[index].KHThang4,
                            KHThang5 = HashLocal[index].KHThang5,
                            KHThang6 = HashLocal[index].KHThang6,
                            KHThang7 = HashLocal[index].KHThang7,
                            KHThang8 = HashLocal[index].KHThang8,
                            KHThang9 = HashLocal[index].KHThang9,
                            KHThang10 = HashLocal[index].KHThang10,
                            KHThang11 = HashLocal[index].KHThang11,
                            KHThang12 = HashLocal[index].KHThang12,
                            Nam = HashLocal[index].Nam,
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count) 
                    {
                        InsertList.Add(new Raw_SpecializedChannel_SalePlan_RevenueDAO()
                        {
                            TenMien = HashRemote[index].TenMien,
                            TenKenh = HashRemote[index].TenKenh,
                            MaKH = HashRemote[index].MaKH,
                            TenKH = HashRemote[index].TenKH,
                            KHNam = HashRemote[index].KHNam,
                            KHQuy1 = HashRemote[index].KHQuy1,
                            KHQuy2 = HashRemote[index].KHQuy2,
                            KHQuy3 = HashRemote[index].KHQuy3,
                            KHQuy4 = HashRemote[index].KHQuy4,
                            KHThang1 = HashRemote[index].KHThang1,
                            KHThang2 = HashRemote[index].KHThang2,
                            KHThang3 = HashRemote[index].KHThang3,
                            KHThang4 = HashRemote[index].KHThang4,
                            KHThang5 = HashRemote[index].KHThang5,
                            KHThang6 = HashRemote[index].KHThang6,
                            KHThang7 = HashRemote[index].KHThang7,
                            KHThang8 = HashRemote[index].KHThang8,
                            KHThang9 = HashRemote[index].KHThang9,
                            KHThang10 = HashRemote[index].KHThang10,
                            KHThang11 = HashRemote[index].KHThang11,
                            KHThang12 = HashRemote[index].KHThang12,
                            Nam = HashRemote[index].Nam,
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Raw_SpecializedChannel_SalePlan_RevenueDAO()
                        {
                            Id = HashLocal[index].Id,
                            TenMien = HashLocal[index].TenMien,
                            TenKenh = HashLocal[index].TenKenh,
                            MaKH = HashLocal[index].MaKH,
                            TenKH = HashLocal[index].TenKH,
                            KHNam = HashLocal[index].KHNam,
                            KHQuy1 = HashLocal[index].KHQuy1,
                            KHQuy2 = HashLocal[index].KHQuy2,
                            KHQuy3 = HashLocal[index].KHQuy3,
                            KHQuy4 = HashLocal[index].KHQuy4,
                            KHThang1 = HashLocal[index].KHThang1,
                            KHThang2 = HashLocal[index].KHThang2,
                            KHThang3 = HashLocal[index].KHThang3,
                            KHThang4 = HashLocal[index].KHThang4,
                            KHThang5 = HashLocal[index].KHThang5,
                            KHThang6 = HashLocal[index].KHThang6,
                            KHThang7 = HashLocal[index].KHThang7,
                            KHThang8 = HashLocal[index].KHThang8,
                            KHThang9 = HashLocal[index].KHThang9,
                            KHThang10 = HashLocal[index].KHThang10,
                            KHThang11 = HashLocal[index].KHThang11,
                            KHThang12 = HashLocal[index].KHThang12,
                            Nam = HashLocal[index].Nam,
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
                await DataContext.BulkMergeAsync(DeleteList);
            }

            return true;
        }
    }
}
