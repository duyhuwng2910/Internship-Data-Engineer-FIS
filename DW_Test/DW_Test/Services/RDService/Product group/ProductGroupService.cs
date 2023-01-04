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

        public Task Transform();
    }
    public class ProductGroupService : IProductGroupService
    {
        private DataContext DataContext;

        public ProductGroupService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        // Init dữ liệu vào bảng Raw_Product_ProductGroup
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
                await DataContext.BulkMergeAsync(Remote);
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

            await Transform();

            return true;
        }

        // Transform dữ liệu từ các bảng Raw vào các bảng Dim dưới đây
        public async Task Transform()
        {
            await Build_Dim_RD_Item();

            await Build_Dim_RD_ItemGroupLevel1();

            await Build_Dim_RD_ItemGroupLevel2();

            await Build_Dim_ProductMapping();
        }

        // Transform dữ liệu vào bảng Dim_RD_Item
        public async Task<bool> Build_Dim_RD_Item()
        {
            List<Raw_Product_ProductGroupDAO> ProductGroupDAOs =
                await DataContext.Raw_Product_ProductGroup.ToListAsync();

            List<Dim_ItemDAO> Dim_ItemDAOs = await DataContext.Dim_Item.ToListAsync();

            List<Raw_A012DAO> Raw_A012DAOs = await DataContext.Raw_A012.ToListAsync();

            List<Dim_RD_ItemDAO> Remote = new List<Dim_RD_ItemDAO>();

            foreach (var product in ProductGroupDAOs)
            {
                var item = Dim_ItemDAOs.Where(x => x.ItemCode == product.MaSP).FirstOrDefault();

                var raw = Raw_A012DAOs.Where(x => x.ItemCode == product.MaSP).FirstOrDefault();

                if (item != null && raw != null)
                {
                    Remote.Add(new Dim_RD_ItemDAO()
                    {
                        ItemId = item.ItemId,
                        ItemCode = item.ItemCode,
                        ItemName = product.TenSP,
                        Quality = product.ChatLuong,
                        Performance = product.CongSuat,
                        LightColor = product.NhietDoMau,
                        UnitPrice = decimal.TryParse(raw.P0003_GiaC1MN.ToString(), out decimal price) ? price : 0
                    });
                }
            }

            List<Dim_RD_ItemDAO> Local = await DataContext.Dim_RD_Item.ToListAsync();

            List<Dim_RD_Item> HashRemote = Remote.Select(x => new Dim_RD_Item(x)).ToList();

            List<Dim_RD_Item> HashLocal = Local.Select(x => new Dim_RD_Item(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Dim_RD_ItemDAO> InsertList = new List<Dim_RD_ItemDAO>();

            List<Dim_RD_ItemDAO> UpdateList = new List<Dim_RD_ItemDAO>();

            List<Dim_RD_ItemDAO> DeleteList = new List<Dim_RD_ItemDAO>();

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
                        InsertList.Add(new Dim_RD_ItemDAO()
                        {
                            ItemId = HashRemote[j].ItemId,
                            ItemCode = HashRemote[j].ItemCode,
                            ItemName = HashRemote[j].ItemName,
                            Quality = HashRemote[j].Quality,
                            Performance = HashRemote[j].Performance,
                            LightColor = HashRemote[j].LightColor,
                            UnitPrice = HashRemote[j].UnitPrice
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Dim_RD_ItemDAO()
                            {
                                ItemId = HashLocal[index].ItemId,
                                ItemCode = HashLocal[index].ItemCode,
                                ItemName = HashRemote[j].ItemName,
                                Quality = HashRemote[j].Quality,
                                Performance = HashRemote[j].Performance,
                                LightColor = HashRemote[j].LightColor,
                                UnitPrice = HashRemote[j].UnitPrice
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Dim_RD_ItemDAO()
                        {
                            ItemId = HashLocal[index].ItemId,
                            ItemCode = HashLocal[index].ItemCode,
                            ItemName = HashLocal[index].ItemName,
                            Quality = HashLocal[index].Quality,
                            Performance = HashLocal[index].Performance,
                            LightColor = HashLocal[index].LightColor,
                            UnitPrice = HashLocal[index].UnitPrice
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Dim_RD_ItemDAO()
                        {
                            ItemId = HashRemote[index].ItemId,
                            ItemCode = HashRemote[index].ItemCode,
                            ItemName = HashRemote[index].ItemName,
                            Quality = HashRemote[index].Quality,
                            Performance = HashRemote[index].Performance,
                            LightColor = HashRemote[index].LightColor,
                            UnitPrice = HashRemote[index].UnitPrice
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Dim_RD_ItemDAO()
                        {
                            ItemId = HashLocal[index].ItemId,
                            ItemCode = HashLocal[index].ItemCode,
                            ItemName = HashLocal[index].ItemName,
                            Quality = HashLocal[index].Quality,
                            Performance = HashLocal[index].Performance,
                            LightColor = HashLocal[index].LightColor,
                            UnitPrice = HashLocal[index].UnitPrice
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

        // Transform dữ liệu vào bảng Dim_RD_ItemGroupLevel1
        public async Task<bool> Build_Dim_RD_ItemGroupLevel1()
        {
            List<Raw_Product_ProductGroupDAO> ProductGroupDAOs = await DataContext.Raw_Product_ProductGroup.ToListAsync();

            List<Dim_RD_ItemGroupLevel1DAO> Remote = new List<Dim_RD_ItemGroupLevel1DAO>();

            foreach (var product in ProductGroupDAOs)
            {
                if (product.SPC1 != "0")
                {
                    Remote.Add(new Dim_RD_ItemGroupLevel1DAO()
                    {
                        ItemGroupLevel1Name = product.SPC1
                    });
                }
            }

            List<Dim_RD_ItemGroupLevel1DAO> Local = await DataContext.Dim_RD_ItemGroupLevel1.ToListAsync();

            Remote = Remote.OrderBy(x => x.ItemGroupLevel1Name).ToList();

            Local = Local.OrderBy(x => x.ItemGroupLevel1Name).ToList();

            List<Dim_RD_ItemGroupLevel1DAO> InsertList = new List<Dim_RD_ItemGroupLevel1DAO>();

            List<Dim_RD_ItemGroupLevel1DAO> DeleteList = new List<Dim_RD_ItemGroupLevel1DAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                await DataContext.BulkMergeAsync(Remote);
            }
            else
            {
                for (int j = 0; j < Remote.Count && index < Local.Count;)
                {
                    if (CompareMethod.Compare(Remote[j].ItemGroupLevel1Name, Local[index].ItemGroupLevel1Name) < 0)
                    {
                        InsertList.Add(new Dim_RD_ItemGroupLevel1DAO()
                        {
                            ItemGroupLevel1Name = Remote[j].ItemGroupLevel1Name
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(Remote[j].ItemGroupLevel1Name, Local[index].ItemGroupLevel1Name) == 0)
                    {
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(Remote[j].ItemGroupLevel1Name, Local[index].ItemGroupLevel1Name) > 0)
                    {
                        DeleteList.Add(new Dim_RD_ItemGroupLevel1DAO()
                        {
                            ItemGroupLevel1Id = Local[index].ItemGroupLevel1Id,
                            ItemGroupLevel1Name = Local[index].ItemGroupLevel1Name
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Remote.Last().ItemGroupLevel1Name != Local.Last().ItemGroupLevel1Name)
                {
                    while (index < Remote.Count)
                    {
                        InsertList.Add(new Dim_RD_ItemGroupLevel1DAO()
                        {
                            ItemGroupLevel1Name = Remote[index].ItemGroupLevel1Name
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_RD_ItemGroupLevel1DAO()
                        {
                            ItemGroupLevel1Id = Local[index].ItemGroupLevel1Id,
                            ItemGroupLevel1Name = Local[index].ItemGroupLevel1Name
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
            }

            return true;
        }

        // Transform dữ liệu vào bảng Dim_RD_ItemGroupLevel2
        public async Task<bool> Build_Dim_RD_ItemGroupLevel2()
        {
            List<Raw_Product_ProductGroupDAO> ProductGroupDAOs = await DataContext.Raw_Product_ProductGroup.ToListAsync();

            List<Dim_RD_ItemGroupLevel2DAO> Remote = new List<Dim_RD_ItemGroupLevel2DAO>();

            foreach (var product in ProductGroupDAOs)
            {
                if (product.SPC2 != "0")
                {
                    Remote.Add(new Dim_RD_ItemGroupLevel2DAO()
                    {
                        ItemGroupLevel2Name = product.SPC2
                    });
                }
            }

            List<Dim_RD_ItemGroupLevel2DAO> Local = await DataContext.Dim_RD_ItemGroupLevel2.ToListAsync();

            Remote = Remote.OrderBy(x => x.ItemGroupLevel2Name).ToList();

            Local = Local.OrderBy(x => x.ItemGroupLevel2Name).ToList();

            List<Dim_RD_ItemGroupLevel2DAO> InsertList = new List<Dim_RD_ItemGroupLevel2DAO>();

            List<Dim_RD_ItemGroupLevel2DAO> DeleteList = new List<Dim_RD_ItemGroupLevel2DAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                await DataContext.BulkMergeAsync(Remote);
            }
            else
            {
                for (int j = 0; j < Remote.Count && index < Local.Count;)
                {
                    if (CompareMethod.Compare(Remote[j].ItemGroupLevel2Name, Local[index].ItemGroupLevel2Name) < 0)
                    {
                        InsertList.Add(new Dim_RD_ItemGroupLevel2DAO()
                        {
                            ItemGroupLevel2Name = Remote[j].ItemGroupLevel2Name
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(Remote[j].ItemGroupLevel2Name, Local[index].ItemGroupLevel2Name) == 0)
                    {
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(Remote[j].ItemGroupLevel2Name, Local[index].ItemGroupLevel2Name) > 0)
                    {
                        DeleteList.Add(new Dim_RD_ItemGroupLevel2DAO()
                        {
                            ItemGroupLevel2Id = Local[index].ItemGroupLevel2Id,
                            ItemGroupLevel2Name = Local[index].ItemGroupLevel2Name
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Remote.Last().ItemGroupLevel2Name != Local.Last().ItemGroupLevel2Name)
                {
                    while (index < Remote.Count)
                    {
                        InsertList.Add(new Dim_RD_ItemGroupLevel2DAO()
                        {
                            ItemGroupLevel2Name = Remote[index].ItemGroupLevel2Name
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_RD_ItemGroupLevel2DAO()
                        {
                            ItemGroupLevel2Id = Local[index].ItemGroupLevel2Id,
                            ItemGroupLevel2Name = Local[index].ItemGroupLevel2Name
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
            }

            return true;
        }

        // Transform dữ liệu vào bảng Dim_ProductMapping
        public async Task<bool> Build_Dim_ProductMapping()
        {
            List<Raw_Product_ProductGroupDAO> ProductGroupDAOs = await DataContext.Raw_Product_ProductGroup.ToListAsync();

            List<Dim_RD_ItemDAO> ItemDAOs = await DataContext.Dim_RD_Item.ToListAsync();

            List<Dim_RD_ItemGroupLevel1DAO> ItemGroupLevel1DAOs = await DataContext.Dim_RD_ItemGroupLevel1.ToListAsync();

            List<Dim_RD_ItemGroupLevel2DAO> ItemGroupLevel2DAOs = await DataContext.Dim_RD_ItemGroupLevel2.ToListAsync();

            List<Dim_ProductMappingDAO> Remote = new List<Dim_ProductMappingDAO>();

            foreach (var product in ProductGroupDAOs)
            {
                var item = ItemDAOs.Where(x => x.ItemCode == product.MaSP).FirstOrDefault();

                var itemLevel1 = ItemGroupLevel1DAOs.Where(x => x.ItemGroupLevel1Name == product.SPC1).FirstOrDefault();

                var itemLevel2 = ItemGroupLevel2DAOs.Where(x => x.ItemGroupLevel2Name == product.SPC2).FirstOrDefault();

                if (item != null)
                {
                    Remote.Add(new Dim_ProductMappingDAO()
                    {
                        ItemId = item.ItemId,
                        ItemGroupLevel1Id = itemLevel1.ItemGroupLevel1Id,
                        ItemGroupLevel2Id = itemLevel2.ItemGroupLevel2Id
                    });
                }
            }

            List<Dim_ProductMappingDAO> Local = await DataContext.Dim_ProductMapping.ToListAsync();

            List<Dim_ProductMapping> HashRemote = Remote.Select(x => new Dim_ProductMapping(x)).ToList();

            List<Dim_ProductMapping> HashLocal = Local.Select(x => new Dim_ProductMapping(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Dim_ProductMappingDAO> InsertList = new List<Dim_ProductMappingDAO>();

            List<Dim_ProductMappingDAO> UpdateList = new List<Dim_ProductMappingDAO>();

            List<Dim_ProductMappingDAO> DeleteList = new List<Dim_ProductMappingDAO>();

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
                        InsertList.Add(new Dim_ProductMappingDAO()
                        {
                            ItemId = HashRemote[j].ItemId,
                            ItemGroupLevel1Id = HashRemote[j].ItemGroupLevel1Id,
                            ItemGroupLevel2Id = HashRemote[j].ItemGroupLevel2Id
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Dim_ProductMappingDAO()
                            {
                                MappingId = HashLocal[index].MappingId,
                                ItemId = HashLocal[index].ItemId,
                                ItemGroupLevel1Id = HashRemote[j].ItemGroupLevel1Id,
                                ItemGroupLevel2Id = HashRemote[j].ItemGroupLevel2Id
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Dim_ProductMappingDAO()
                        {
                            MappingId = HashLocal[index].MappingId,
                            ItemId = HashLocal[index].ItemId,
                            ItemGroupLevel1Id = HashLocal[index].ItemGroupLevel1Id,
                            ItemGroupLevel2Id = HashLocal[index].ItemGroupLevel2Id
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Dim_ProductMappingDAO()
                        {
                            ItemId = HashRemote[index].ItemId,
                            ItemGroupLevel1Id = HashRemote[index].ItemGroupLevel1Id,
                            ItemGroupLevel2Id = HashRemote[index].ItemGroupLevel2Id
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Dim_ProductMappingDAO()
                        {
                            MappingId = HashLocal[index].MappingId,
                            ItemId = HashLocal[index].ItemId,
                            ItemGroupLevel1Id = HashLocal[index].ItemGroupLevel1Id,
                            ItemGroupLevel2Id = HashLocal[index].ItemGroupLevel2Id
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
