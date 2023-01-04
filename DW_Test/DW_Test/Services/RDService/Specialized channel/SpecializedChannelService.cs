using DocumentFormat.OpenXml.InkML;
using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using Nest;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Specialized_channel
{
    public interface ISpecializedChannelService : IServiceScoped
    {
        public Task<bool> Init(List<Raw_SpecializedChannelDAO> Remote);

        public Task Transform();
    }
    public class SpecializedChannelService : ISpecializedChannelService
    {
        private DataContext DataContext;

        public SpecializedChannelService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        // Init dữ liệu vào bảng Raw_SpecializedChannel
        public async Task<bool> Init(List<Raw_SpecializedChannelDAO> Remote)
        {
            List<Raw_SpecializedChannelDAO> Local = await DataContext.Raw_SpecializedChannel.ToListAsync();

            List<Raw_SpecializedChannel> HashRemote = Remote.Select(x => new Raw_SpecializedChannel(x)).ToList();

            List<Raw_SpecializedChannel> HashLocal = Local.Select(x => new Raw_SpecializedChannel(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Raw_SpecializedChannelDAO> InsertList = new List<Raw_SpecializedChannelDAO>();

            List<Raw_SpecializedChannelDAO> UpdateList = new List<Raw_SpecializedChannelDAO>();

            List<Raw_SpecializedChannelDAO> DeleteList = new List<Raw_SpecializedChannelDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                await DataContext.BulkMergeAsync(Remote);
            }
            else
            {
                for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
                {
                    if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                    {
                        InsertList.Add(new Raw_SpecializedChannelDAO()
                        {
                            TenMien = HashRemote[j].TenMien,
                            TenKenh = HashRemote[j].TenKenh,
                            SPC1 = HashRemote[j].SPC1
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Raw_SpecializedChannelDAO()
                            {
                                Id = HashLocal[index].Id,
                                TenMien = HashLocal[index].TenMien,
                                TenKenh = HashLocal[index].TenKenh,
                                SPC1 = HashRemote[j].SPC1
                            });
                        }
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Raw_SpecializedChannelDAO()
                        {
                            Id = HashLocal[index].Id,
                            TenMien = HashLocal[index].TenMien,
                            TenKenh = HashLocal[index].TenKenh,
                            SPC1 = HashLocal[index].SPC1
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Raw_SpecializedChannelDAO()
                        {
                            TenMien = HashRemote[index].TenMien,
                            TenKenh = HashRemote[index].TenKenh,
                            SPC1 = HashRemote[index].SPC1
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Raw_SpecializedChannelDAO()
                        {
                            Id = HashLocal[index].Id,
                            TenMien = HashLocal[index].TenMien,
                            TenKenh = HashLocal[index].TenKenh,
                            SPC1 = HashLocal[index].SPC1
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
                await DataContext.BulkMergeAsync(UpdateList);
            }

            await Transform();

            return true;
        }

        // Transform dữ liệu từ các bảng Raw vào các bảng Dim sau
        public async Task Transform()
        {
            await Build_Dim_RD_SaleChannel();

            await Build_Dim_Region();

            await Build_Dim_SpecializedChannelMapping();

            await Build_Dim_ProductSaleChannelMapping();
        }

        // Transform dữ liệu sang bảng Dim_RD_SaleChannel
        public async Task<bool> Build_Dim_RD_SaleChannel()
        {
            List<Raw_SpecializedChannelDAO> SpecializedChannelDAOs = await DataContext.Raw_SpecializedChannel.ToListAsync();

            List<Dim_RD_SaleChannelDAO> Remote = new List<Dim_RD_SaleChannelDAO>();

            foreach(var channel in SpecializedChannelDAOs)
            {
                if (channel.TenKenh != null)
                {
                    Remote.Add(new Dim_RD_SaleChannelDAO()
                    {
                        SaleChannelName = channel.TenKenh
                    });
                }
            }

            List<Dim_RD_SaleChannelDAO> Local = await DataContext.Dim_RD_SaleChannel.ToListAsync();

            Remote = Remote.OrderBy(x => x.SaleChannelName).ToList();

            Local = Local.OrderBy(x => x.SaleChannelName).ToList();

            List<Dim_RD_SaleChannelDAO> InsertList = new List<Dim_RD_SaleChannelDAO>();

            List<Dim_RD_SaleChannelDAO> DeleteList = new List<Dim_RD_SaleChannelDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                await DataContext.BulkMergeAsync(Remote);
            }
            else
            {
                for (int j = 0; j < Remote.Count && index < Local.Count;)
                {
                    if (CompareMethod.Compare(Remote[j].SaleChannelName, Local[index].SaleChannelName) < 0)
                    {
                        InsertList.Add(new Dim_RD_SaleChannelDAO()
                        {
                            SaleChannelName = Remote[j].SaleChannelName
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(Remote[j].SaleChannelName, Local[index].SaleChannelName) == 0)
                    {
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(Remote[j].SaleChannelName, Local[index].SaleChannelName) > 0)
                    {
                        DeleteList.Add(new Dim_RD_SaleChannelDAO()
                        {
                            SaleChannelId = Local[index].SaleChannelId,
                            SaleChannelName = Local[index].SaleChannelName
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Remote.Last().SaleChannelName != Local.Last().SaleChannelName)
                {
                    while (index < Remote.Count)
                    {
                        InsertList.Add(new Dim_RD_SaleChannelDAO()
                        {
                            SaleChannelName = Remote[index].SaleChannelName
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_RD_SaleChannelDAO()
                        {
                            SaleChannelId = Local[index].SaleChannelId,
                            SaleChannelName = Local[index].SaleChannelName
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
            }

            return true;
        }

        // Transform dữ liệu sang bảng Dim_Region
        public async Task<bool> Build_Dim_Region()
        {
            List<Raw_SpecializedChannelDAO> SpecializedChannelDAOs = await DataContext.Raw_SpecializedChannel.ToListAsync();

            List<Dim_RegionDAO> Remote = new List<Dim_RegionDAO>();

            foreach (var channel in SpecializedChannelDAOs)
            {
                if (channel.TenMien != null)
                {
                    Remote.Add(new Dim_RegionDAO()
                    {
                        RegionName = channel.TenMien
                    });
                }
            }

            List<Dim_RegionDAO> Local = await DataContext.Dim_Region.ToListAsync();

            Remote = Remote.OrderBy(x => x.RegionName).ToList();

            Local = Local.OrderBy(x => x.RegionName).ToList();

            List<Dim_RegionDAO> InsertList = new List<Dim_RegionDAO>();

            List<Dim_RegionDAO> DeleteList = new List<Dim_RegionDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                await DataContext.BulkMergeAsync(Remote);
            }
            else
            {
                for (int j = 0; j < Remote.Count && index < Local.Count;)
                {
                    if (CompareMethod.Compare(Remote[j].RegionName, Local[index].RegionName) < 0)
                    {
                        InsertList.Add(new Dim_RegionDAO()
                        {
                            RegionName = Remote[j].RegionName
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(Remote[j].RegionName, Local[index].RegionName) == 0)
                    {
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(Remote[j].RegionName, Local[index].RegionName) > 0)
                    {
                        DeleteList.Add(new Dim_RegionDAO()
                        {
                            RegionId = Local[index].RegionId,
                            RegionName = Local[index].RegionName
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Remote.Last().RegionName != Local.Last().RegionName)
                {
                    while (index < Remote.Count)
                    {
                        InsertList.Add(new Dim_RegionDAO()
                        {
                            RegionName = Remote[index].RegionName
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_RegionDAO()
                        {
                            RegionId = Local[index].RegionId,
                            RegionName = Local[index].RegionName
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
            }

            return true;
        }

        // Transform dữ liệu sang bảng Dim_SpecializedChannelMapping 
        public async Task<bool> Build_Dim_SpecializedChannelMapping()
        {
            List<Raw_SpecializedChannelDAO> SpecializedChannelDAOs = await DataContext.Raw_SpecializedChannel.ToListAsync();

            List<Dim_RegionDAO> RegionDAOs = await DataContext.Dim_Region.ToListAsync();

            List<Dim_RD_SaleChannelDAO> SaleChannelDAOs = await DataContext.Dim_RD_SaleChannel.ToListAsync();

            List<Dim_SpecializedChannelMappingDAO> Remote = new List<Dim_SpecializedChannelMappingDAO>();

            foreach (var channel in SpecializedChannelDAOs)
            {
                var region = RegionDAOs.Where(x => x.RegionName == channel.TenMien).FirstOrDefault();

                var saleChannel = SaleChannelDAOs.Where(x => x.SaleChannelName == channel.TenKenh).FirstOrDefault();

                Remote.Add(new Dim_SpecializedChannelMappingDAO()
                {
                    RegionId = region.RegionId,
                    SaleChannelId = saleChannel.SaleChannelId
                });
            }

            List<Dim_SpecializedChannelMappingDAO> Local = await DataContext.Dim_SpecializedChannelMapping.ToListAsync();

            Remote = Remote.OrderBy(x => x.SaleChannelId).ToList();

            Local = Local.OrderBy(x => x.SaleChannelId).ToList();

            List<Dim_SpecializedChannelMappingDAO> InsertList = new List<Dim_SpecializedChannelMappingDAO>();

            List<Dim_SpecializedChannelMappingDAO> UpdateList = new List<Dim_SpecializedChannelMappingDAO>();

            List<Dim_SpecializedChannelMappingDAO> DeleteList = new List<Dim_SpecializedChannelMappingDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                await DataContext.BulkMergeAsync(Remote);
            }
            else
            {
                for (int j = 0; j < Remote.Count && index < Local.Count;)
                {
                    if (Remote[j].SaleChannelId < Local[index].SaleChannelId)
                    {
                        InsertList.Add(new Dim_SpecializedChannelMappingDAO()
                        {
                            RegionId = Remote[j].RegionId,
                            SaleChannelId = Remote[j].SaleChannelId
                        });

                        j++;
                    }
                    else if (Remote[j].SaleChannelId == Local[index].SaleChannelId)
                    {
                        if (Remote[j].RegionId != Local[index].RegionId)
                        {
                            UpdateList.Add(new Dim_SpecializedChannelMappingDAO()
                            {
                                MappingId = Local[index].MappingId,
                                RegionId = Remote[j].RegionId,
                                SaleChannelId = Local[index].SaleChannelId
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (Remote[j].SaleChannelId > Local[index].SaleChannelId)
                    {
                        DeleteList.Add(new Dim_SpecializedChannelMappingDAO()
                        {
                            MappingId = Local[index].MappingId,
                            RegionId = Local[index].RegionId,
                            SaleChannelId = Local[index].SaleChannelId
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Remote.Last().SaleChannelId != Local.Last().SaleChannelId)
                {
                    while (index < Remote.Count)
                    {
                        InsertList.Add(new Dim_SpecializedChannelMappingDAO()
                        {
                            RegionId = Remote[index].RegionId,
                            SaleChannelId = Remote[index].SaleChannelId
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_SpecializedChannelMappingDAO()
                        {
                            MappingId = Local[index].MappingId,
                            RegionId = Local[index].RegionId,
                            SaleChannelId = Local[index].SaleChannelId
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

        // Transform dữ liệu sang bảng Dim_ProductSaleChannelMapping
        public async Task<bool> Build_Dim_ProductSaleChannelMapping()
        {
            List<Raw_SpecializedChannelDAO> SpecializedChannelDAOs = await DataContext.Raw_SpecializedChannel.ToListAsync();

            List<Dim_RD_SaleChannelDAO> SaleChannelDAOs = await DataContext.Dim_RD_SaleChannel.ToListAsync();

            List<Dim_RD_ItemGroupLevel1DAO> ItemGroupLevel1DAOs = await DataContext.Dim_RD_ItemGroupLevel1.ToListAsync();

            List<Dim_ProductSaleChannelMappingDAO> Remote = new List<Dim_ProductSaleChannelMappingDAO>();

            foreach (var channel in SpecializedChannelDAOs)
            {
                var item = ItemGroupLevel1DAOs.Where(x => x.ItemGroupLevel1Name == channel.SPC1).FirstOrDefault();

                var saleChannel = SaleChannelDAOs.Where(x => x.SaleChannelName == channel.TenKenh).FirstOrDefault();

                Remote.Add(new Dim_ProductSaleChannelMappingDAO()
                {
                    ItemGroupLevel1Id = item.ItemGroupLevel1Id,
                    SaleChannelId = saleChannel.SaleChannelId
                });
            }

            List<Dim_ProductSaleChannelMappingDAO> Local = await DataContext.Dim_ProductSaleChannelMapping.ToListAsync();

            Remote = Remote.OrderBy(x => x.SaleChannelId).ToList();

            Local = Local.OrderBy(x => x.SaleChannelId).ToList();

            List<Dim_ProductSaleChannelMappingDAO> InsertList = new List<Dim_ProductSaleChannelMappingDAO>();

            List<Dim_ProductSaleChannelMappingDAO> UpdateList = new List<Dim_ProductSaleChannelMappingDAO>();

            List<Dim_ProductSaleChannelMappingDAO> DeleteList = new List<Dim_ProductSaleChannelMappingDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                await DataContext.BulkMergeAsync(Remote);
            }
            else
            {
                for (int j = 0; j < Remote.Count && index < Local.Count;)
                {
                    if (Remote[j].SaleChannelId < Local[index].SaleChannelId)
                    {
                        InsertList.Add(new Dim_ProductSaleChannelMappingDAO()
                        {
                            ItemGroupLevel1Id = Remote[j].ItemGroupLevel1Id,
                            SaleChannelId = Remote[j].SaleChannelId
                        });

                        j++;
                    }
                    else if (Remote[j].SaleChannelId == Local[index].SaleChannelId)
                    {
                        if (Remote[j].ItemGroupLevel1Id != Local[index].ItemGroupLevel1Id)
                        {
                            UpdateList.Add(new Dim_ProductSaleChannelMappingDAO()
                            {
                                MappingId = Local[index].MappingId,
                                ItemGroupLevel1Id = Remote[j].ItemGroupLevel1Id,
                                SaleChannelId = Local[index].SaleChannelId
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (Remote[j].SaleChannelId > Local[index].SaleChannelId)
                    {
                        DeleteList.Add(new Dim_ProductSaleChannelMappingDAO()
                        {
                            MappingId = Local[index].MappingId,
                            ItemGroupLevel1Id = Local[index].ItemGroupLevel1Id,
                            SaleChannelId = Local[index].SaleChannelId
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Remote.Last().SaleChannelId != Local.Last().SaleChannelId)
                {
                    while (index < Remote.Count)
                    {
                        InsertList.Add(new Dim_ProductSaleChannelMappingDAO()
                        {
                            ItemGroupLevel1Id = Remote[index].ItemGroupLevel1Id,
                            SaleChannelId = Remote[index].SaleChannelId
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_ProductSaleChannelMappingDAO()
                        {
                            MappingId = Local[index].MappingId,
                            ItemGroupLevel1Id = Local[index].ItemGroupLevel1Id,
                            SaleChannelId = Local[index].SaleChannelId
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
