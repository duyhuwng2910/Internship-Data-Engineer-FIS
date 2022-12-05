using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MProduct_GroupService
{
    public interface IProduct_GroupService : IServiceScoped
    {
        Task<bool> Import(List<Raw_Product_GroupDAO> Raw_Product_GroupRemoteDAOs);

        Task Product_GroupTransform();
    }
    public class Product_GroupService : IProduct_GroupService
    {
        private DataContext DataContext;

        public Product_GroupService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Import(List<Raw_Product_GroupDAO> Raw_Product_GroupRemoteDAOs)
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupLocalDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            List<Raw_Product_Group> HashLocal = Raw_Product_GroupLocalDAOs
                .Select(x => new Raw_Product_Group(x)).ToList();

            List<Raw_Product_Group> HashRemote = Raw_Product_GroupRemoteDAOs
                .Select(x => new Raw_Product_Group(x)).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            List<Raw_Product_GroupDAO> InsertList = new List<Raw_Product_GroupDAO>();

            List<Raw_Product_GroupDAO> UpdateList = new List<Raw_Product_GroupDAO>();

            List<Raw_Product_GroupDAO> DeleteList = new List<Raw_Product_GroupDAO>();

            int index = 0;

            for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
            {
                if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                {
                    var remote = HashRemote[j];

                    var group = new Raw_Product_GroupDAO()
                    {
                        ItemCode = remote.ItemCode,
                        ItemName = remote.ItemName,
                        Loai_MHang_KH = remote.Loai_MHang_KH,
                        Nhomchinh_KH = remote.Nhomchinh_KH,
                        NhomC1 = remote.NhomC1,
                        NhomC2 = remote.NhomC2,
                        NhomC3 = remote.NhomC3,
                        Nhom_LEDSMRT1 = remote.Nhom_LEDSMRT1,
                        Nhom_SMARTDONLE = remote.Nhom_SMARTDONLE
                    };

                    InsertList.Add(group);

                    j++;
                }
                else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                {
                    if (HashRemote[j].Value != HashLocal[index].Value)
                    {
                        var remote = HashRemote[j];

                        var group = new Raw_Product_GroupDAO()
                        {
                            Id = HashLocal[index].Id,
                            ItemCode = HashLocal[index].ItemCode,
                            ItemName = remote.ItemName,
                            Loai_MHang_KH = remote.Loai_MHang_KH,
                            Nhomchinh_KH = remote.Nhomchinh_KH,
                            NhomC1 = remote.NhomC1,
                            NhomC2 = remote.NhomC2,
                            NhomC3 = remote.NhomC3,
                            Nhom_LEDSMRT1 = remote.Nhom_LEDSMRT1,
                            Nhom_SMARTDONLE = remote.Nhom_SMARTDONLE
                        };

                        UpdateList.Add(group);
                    }

                    index++;

                    j++;
                }
                else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                {
                    var local = HashLocal[index];

                    var group = new Raw_Product_GroupDAO()
                    {
                        Id = local.Id,
                        ItemCode = local.ItemCode,
                        ItemName = local.ItemName,
                        Loai_MHang_KH = local.Loai_MHang_KH,
                        Nhomchinh_KH = local.Nhomchinh_KH,
                        NhomC1 = local.NhomC1,
                        NhomC2 = local.NhomC2,
                        NhomC3 = local.NhomC3,
                        Nhom_LEDSMRT1 = local.Nhom_LEDSMRT1,
                        Nhom_SMARTDONLE = local.Nhom_SMARTDONLE
                    };

                    DeleteList.Add(group);

                    index++;
                }
            }

            if (index == HashLocal.Count && HashLocal.Last().Key != HashRemote.Last().Key)
            {
                while (index < HashRemote.Count)
                {
                    var remote = HashRemote[index];

                    var group = new Raw_Product_GroupDAO()
                    {
                        ItemCode = remote.ItemCode,
                        ItemName = remote.ItemName,
                        Loai_MHang_KH = remote.Loai_MHang_KH,
                        Nhomchinh_KH = remote.Nhomchinh_KH,
                        NhomC1 = remote.NhomC1,
                        NhomC2 = remote.NhomC2,
                        NhomC3 = remote.NhomC3,
                        Nhom_LEDSMRT1 = remote.Nhom_LEDSMRT1,
                        Nhom_SMARTDONLE = remote.Nhom_SMARTDONLE
                    };

                    InsertList.Add(group);

                    index++;
                }
            }
            else if (index < HashLocal.Count)
            {
                while (index < HashLocal.Count)
                {
                    var local = HashLocal[index];

                    var group = new Raw_Product_GroupDAO()
                    {
                        Id = local.Id,
                        ItemCode = local.ItemCode,
                        ItemName = local.ItemName,
                        Loai_MHang_KH = local.Loai_MHang_KH,
                        Nhomchinh_KH = local.Nhomchinh_KH,
                        NhomC1 = local.NhomC1,
                        NhomC2 = local.NhomC2,
                        NhomC3 = local.NhomC3,
                        Nhom_LEDSMRT1 = local.Nhom_LEDSMRT1,
                        Nhom_SMARTDONLE = local.Nhom_SMARTDONLE
                    };

                    DeleteList.Add(group);

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }

        public async Task Product_GroupTransform()
        {
            await Build_Dim_ItemTypeGroup();
            await Build_DimItemMainGroup();
            await Build_Dim_ItemGroupLevel1();
            await Build_Dim_ItemGroupLevel2();
            await Build_Dim_ItemGroupLevel3();
            await Build_Dim_ItemLedSmartGroup();
            await Build_Dim_ItemSingleLedSmartGroup();
            await Build_Dim_ItemMapping();
        }

        // hàm build bảng Dim_ItemTypeGroup
        private async Task<bool> Build_Dim_ItemTypeGroup()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.Loai_MHang_KH)).ToListAsync();

            var Dim_ItemTypeGroupDAOs = await DataContext.Dim_ItemTypeGroup.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                var Loai_MHang_KH = Raw_Product_GroupDAO.Loai_MHang_KH;
                Dim_ItemTypeGroupDAO Dim_ItemTypeGroupDAO = Dim_ItemTypeGroupDAOs
                    .Where(x => x.ItemTypeName == Loai_MHang_KH).FirstOrDefault();
                if (Dim_ItemTypeGroupDAO == null && Loai_MHang_KH != "0")
                {
                    Dim_ItemTypeGroupDAO = new Dim_ItemTypeGroupDAO
                    {
                        ItemTypeName = Loai_MHang_KH,
                    };
                    Dim_ItemTypeGroupDAOs.Add(Dim_ItemTypeGroupDAO);
                }
            }

            await DataContext.BulkMergeAsync(Dim_ItemTypeGroupDAOs);

            return true;
        }

        // Tranform sang bảng Dim_ItemMainGroup
        private async Task<bool> Build_DimItemMainGroup()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.Nhomchinh_KH)).ToListAsync();

            List<Dim_ItemMainGroupDAO> Dim_ItemMainGroupDAOs = await DataContext.Dim_ItemMainGroup.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_ItemMainGroupDAO Dim_ItemMainGroup = Dim_ItemMainGroupDAOs
                    .Where(x => x.ItemMainGroupName == Raw_Product_GroupDAO.Nhomchinh_KH).FirstOrDefault();

                if (Dim_ItemMainGroup == null && Raw_Product_GroupDAO.Nhomchinh_KH != "0")
                {
                    Dim_ItemMainGroup = new Dim_ItemMainGroupDAO
                    {
                        ItemMainGroupName = Raw_Product_GroupDAO.Nhomchinh_KH,
                    };
                    Dim_ItemMainGroupDAOs.Add(Dim_ItemMainGroup);
                }
            }
            await DataContext.BulkMergeAsync(Dim_ItemMainGroupDAOs);

            return true;
        }

        // Transform sang bảng Dim_ItemGroupLevel1
        private async Task<bool> Build_Dim_ItemGroupLevel1()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.NhomC1)).ToListAsync();

            var Dim_ItemGroupLevel1DAOs = await DataContext.Dim_ItemGroupLevel1.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_ItemGroupLevel1DAO Dim_ItemGroupLevel1 = Dim_ItemGroupLevel1DAOs.
                    Where(x => x.ItemGroupLevel1Name == Raw_Product_GroupDAO.NhomC1).FirstOrDefault();

                if (Dim_ItemGroupLevel1 == null && Raw_Product_GroupDAO.NhomC1 != "0")
                {
                    Dim_ItemGroupLevel1 = new Dim_ItemGroupLevel1DAO
                    {
                        ItemGroupLevel1Name = Raw_Product_GroupDAO.NhomC1,
                    };
                    Dim_ItemGroupLevel1DAOs.Add(Dim_ItemGroupLevel1);
                }
            }
            await DataContext.BulkMergeAsync(Dim_ItemGroupLevel1DAOs);

            return true;
        }

        // Transform sang bảng Dim_ItemGroupLevel2
        private async Task<bool> Build_Dim_ItemGroupLevel2()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.NhomC2)).ToListAsync();

            var Dim_ItemGroupLevel2DAOs = await DataContext.Dim_ItemGroupLevel2.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_ItemGroupLevel2DAO Dim_ItemGroupLevel2 = Dim_ItemGroupLevel2DAOs.
                    Where(x => x.ItemGroupLevel2Name == Raw_Product_GroupDAO.NhomC2).FirstOrDefault();

                if (Dim_ItemGroupLevel2 == null && Raw_Product_GroupDAO.NhomC2 != "0")
                {
                    Dim_ItemGroupLevel2 = new Dim_ItemGroupLevel2DAO
                    {
                        ItemGroupLevel2Name = Raw_Product_GroupDAO.NhomC2,
                    };
                    Dim_ItemGroupLevel2DAOs.Add(Dim_ItemGroupLevel2);
                }
            }
            await DataContext.BulkMergeAsync(Dim_ItemGroupLevel2DAOs);

            return true;
        }

        // Transform bảng Dim_ItemGroupLevel3
        private async Task<bool> Build_Dim_ItemGroupLevel3()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.NhomC3)).ToListAsync();

            var Dim_ItemGroupLevel3DAOs = await DataContext.Dim_ItemGroupLevel3.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_ItemGroupLevel3DAO Dim_ItemGroupLevel3 = Dim_ItemGroupLevel3DAOs.
                    Where(x => x.ItemGroupLevel3Name == Raw_Product_GroupDAO.NhomC3).FirstOrDefault();

                if (Dim_ItemGroupLevel3 == null && Raw_Product_GroupDAO.NhomC3 != "0")
                {
                    Dim_ItemGroupLevel3 = new Dim_ItemGroupLevel3DAO
                    {
                        ItemGroupLevel3Name = Raw_Product_GroupDAO.NhomC3,
                    };
                    Dim_ItemGroupLevel3DAOs.Add(Dim_ItemGroupLevel3);
                }
            }
            await DataContext.BulkMergeAsync(Dim_ItemGroupLevel3DAOs);

            return true;
        }

        // Transform bảng Dim_ItemLedSmartGroup
        private async Task<bool> Build_Dim_ItemLedSmartGroup()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.Nhom_LEDSMRT1)).ToListAsync();

            var Dim_ItemLedSmartGroupDAOs = await DataContext.Dim_ItemLedSmartGroup.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_ItemLedSmartGroupDAO Dim_ItemLedSmartGroup = Dim_ItemLedSmartGroupDAOs
                    .Where(x => x.ItemLedSmartGroupName == Raw_Product_GroupDAO.Nhom_LEDSMRT1).FirstOrDefault();
                if (Dim_ItemLedSmartGroup == null && Raw_Product_GroupDAO.Nhom_LEDSMRT1 != "0")
                {
                    Dim_ItemLedSmartGroup = new Dim_ItemLedSmartGroupDAO
                    {
                        ItemLedSmartGroupName = Raw_Product_GroupDAO.Nhom_LEDSMRT1,
                    };
                    Dim_ItemLedSmartGroupDAOs.Add(Dim_ItemLedSmartGroup);
                }

            }
            await DataContext.BulkMergeAsync(Dim_ItemLedSmartGroupDAOs);

            return true;
        }

        // Transform bảng Dim_ItemSingleLedSmartGroup
        private async Task<bool> Build_Dim_ItemSingleLedSmartGroup()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.Nhom_SMARTDONLE)).ToListAsync();

            List<Dim_ItemSingleLedSmartGroupDAO> Dim_ItemSingleLedSmartGroupDAOs = await DataContext.Dim_ItemSingleLedSmartGroup.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_ItemSingleLedSmartGroupDAO Dim_ItemSingleLedSmartGroup = Dim_ItemSingleLedSmartGroupDAOs
                    .Where(x => x.ItemSingleLedSmartGroupName == Raw_Product_GroupDAO.Nhom_SMARTDONLE).FirstOrDefault();

                if (Dim_ItemSingleLedSmartGroup == null && Raw_Product_GroupDAO.Nhom_SMARTDONLE != "0")
                {
                    Dim_ItemSingleLedSmartGroup = new Dim_ItemSingleLedSmartGroupDAO
                    {
                        ItemSingleLedSmartGroupName = Raw_Product_GroupDAO.Nhom_SMARTDONLE,
                    };
                    Dim_ItemSingleLedSmartGroupDAOs.Add(Dim_ItemSingleLedSmartGroup);
                }
            }
            await DataContext.BulkMergeAsync(Dim_ItemSingleLedSmartGroupDAOs);

            return true;
        }

        private async Task<bool> Build_Dim_ItemMapping()
        {
            List<Dim_ItemDAO> ItemDAOs = await DataContext.Dim_Item.ToListAsync();
            List<Dim_ItemTypeGroupDAO> ItemTypeGroupDAOs = await DataContext.Dim_ItemTypeGroup.ToListAsync();
            List<Dim_ItemMainGroupDAO> ItemMainGroupDAOs = await DataContext.Dim_ItemMainGroup.ToListAsync();
            List<Dim_ItemGroupLevel1DAO> ItemGroupLevel1DAOs = await DataContext.Dim_ItemGroupLevel1.ToListAsync();
            List<Dim_ItemGroupLevel2DAO> ItemGroupLevel2DAOs = await DataContext.Dim_ItemGroupLevel2.ToListAsync();
            List<Dim_ItemGroupLevel3DAO> ItemGroupLevel3DAOs = await DataContext.Dim_ItemGroupLevel3.ToListAsync();
            List<Dim_ItemLedSmartGroupDAO> ItemLedSmartGroupDAOs = await DataContext.Dim_ItemLedSmartGroup.ToListAsync();
            List<Dim_ItemSingleLedSmartGroupDAO> ItemSingleLedSmartGroupDAOs = await DataContext.Dim_ItemSingleLedSmartGroup.ToListAsync();

            List<Dim_ItemMappingDAO> DimItemMappingDAOs = await DataContext.Dim_ItemMapping.ToListAsync();

            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                var ItemDAO = ItemDAOs.Where(x => x.ItemCode == Raw_Product_GroupDAO.ItemCode).FirstOrDefault();
                var ItemTypeGroupDAO = ItemTypeGroupDAOs
                    .Where(x => x.ItemTypeName == Raw_Product_GroupDAO.Loai_MHang_KH).FirstOrDefault();
                var ItemMainGroupDAO = ItemMainGroupDAOs
                    .Where(x => x.ItemMainGroupName == Raw_Product_GroupDAO.Nhomchinh_KH).FirstOrDefault();
                var ItemGroupLevel1DAO = ItemGroupLevel1DAOs
                    .Where(x => x.ItemGroupLevel1Name == Raw_Product_GroupDAO.NhomC1).FirstOrDefault();
                var ItemGroupLevel2DAO = ItemGroupLevel2DAOs
                    .Where(x => x.ItemGroupLevel2Name == Raw_Product_GroupDAO.NhomC2).FirstOrDefault();
                var ItemGroupLevel3DAO = ItemGroupLevel3DAOs
                    .Where(x => x.ItemGroupLevel3Name == Raw_Product_GroupDAO.NhomC3).FirstOrDefault();
                var ItemLedSmartGroupDAO = ItemLedSmartGroupDAOs
                    .Where(x => x.ItemLedSmartGroupName == Raw_Product_GroupDAO.Nhom_LEDSMRT1).FirstOrDefault();
                var ItemSingleLedSmartGroupDAO = ItemSingleLedSmartGroupDAOs
                    .Where(x => x.ItemSingleLedSmartGroupName == Raw_Product_GroupDAO.Nhom_SMARTDONLE).FirstOrDefault();

                Dim_ItemMappingDAO Dim_ItemMapping = DimItemMappingDAOs.
                    Where(x => x.ItemId == ItemDAO?.ItemId).FirstOrDefault();

                if (Dim_ItemMapping == null)
                {
                    Dim_ItemMapping = new Dim_ItemMappingDAO
                    {
                        ItemId = ItemDAO?.ItemId ?? null,
                        ItemCode = ItemDAO?.ItemCode ?? null,
                        ItemTypeId = ItemTypeGroupDAO?.ItemTypeId ?? null,
                        ItemMainGroupId = ItemMainGroupDAO?.ItemMainGroupId ?? null,
                        ItemGroupLevel1Id = ItemGroupLevel1DAO?.ItemGroupLevel1Id ?? null,
                        ItemGroupLevel2Id = ItemGroupLevel2DAO?.ItemGroupLevel2Id ?? null,
                        ItemGroupLevel3Id = ItemGroupLevel3DAO?.ItemGroupLevel3Id ?? null,
                        ItemLedSmartGroupId = ItemLedSmartGroupDAO?.ItemLedSmartGroupId ?? null,
                    };
                    DimItemMappingDAOs.Add(Dim_ItemMapping);
                }
                else
                {
                    Dim_ItemMapping.ItemCode = ItemDAO?.ItemCode ?? null;
                    Dim_ItemMapping.ItemTypeId = ItemTypeGroupDAO?.ItemTypeId ?? null;
                    Dim_ItemMapping.ItemMainGroupId = ItemMainGroupDAO?.ItemMainGroupId ?? null;
                    Dim_ItemMapping.ItemGroupLevel1Id = ItemGroupLevel1DAO?.ItemGroupLevel1Id ?? null;
                    Dim_ItemMapping.ItemGroupLevel2Id = ItemGroupLevel2DAO?.ItemGroupLevel2Id ?? null;
                    Dim_ItemMapping.ItemGroupLevel3Id = ItemGroupLevel3DAO?.ItemGroupLevel3Id ?? null;
                    Dim_ItemMapping.ItemLedSmartGroupId = ItemLedSmartGroupDAO?.ItemLedSmartGroupId ?? null;
                }
            }
            await DataContext.BulkMergeAsync(DimItemMappingDAOs);

            return true;
        }
    }
}
