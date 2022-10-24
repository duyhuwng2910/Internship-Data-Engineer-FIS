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

            await DataContext.BulkDeleteAsync(Raw_Product_GroupLocalDAOs);

            DataContext.BulkMerge(Raw_Product_GroupRemoteDAOs);

            return true;
        }

        public async Task Product_GroupTransform()
        {
            await Build_Dim_Item_Type_Group();
            await Build_Dim_Item_Main_Group();
            await Build_Dim_Item_Group_Level_1();
            await Build_Dim_Item_Group_Level_2();
            await Build_Dim_Item_Group_Level_3();
            await Build_Dim_Item_Led_Smart_Group();
            await Build_Dim_Item_Mapping();
        }

        // hàm build bảng Dim_Item_Type_Group
        private async Task<bool> Build_Dim_Item_Type_Group()
        {
            var Dim_Item_Type_GroupDAOs = await DataContext.Dim_Item_Type_Group.ToListAsync();

            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();
            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                var Loai_MHang_KH = Raw_Product_GroupDAO.Loai_MHang_KH;
                Dim_Item_Type_GroupDAO Dim_Item_Type_GroupDAO = Dim_Item_Type_GroupDAOs
                    .Where(x => x.ItemTypeName == Loai_MHang_KH).FirstOrDefault();
                if (Dim_Item_Type_GroupDAO == null && Loai_MHang_KH != null && Loai_MHang_KH != "0")
                {
                    Dim_Item_Type_GroupDAO = new Dim_Item_Type_GroupDAO
                    {
                        ItemTypeName = Loai_MHang_KH,
                    };
                    Dim_Item_Type_GroupDAOs.Add(Dim_Item_Type_GroupDAO);
                }

            }
            await DataContext.BulkMergeAsync(Dim_Item_Type_GroupDAOs);

            return true;
        }

        // Tranform sang bảng dim_item_main_group
        private async Task<bool> Build_Dim_Item_Main_Group()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            List<Dim_Item_Main_GroupDAO> Dim_Item_Main_GroupDAOs = await DataContext.Dim_Item_Main_Group.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_Item_Main_GroupDAO Dim_Item_Main_Group = Dim_Item_Main_GroupDAOs
                    .Where(x => x.ItemMainGroupName == Raw_Product_GroupDAO.Nhomchinh_KH).FirstOrDefault();

                if (Dim_Item_Main_Group == null && Raw_Product_GroupDAO.Nhomchinh_KH != null && Raw_Product_GroupDAO.Nhomchinh_KH != "0")
                {
                    Dim_Item_Main_Group = new Dim_Item_Main_GroupDAO
                    {
                        ItemMainGroupName = Raw_Product_GroupDAO.Nhomchinh_KH,
                    };
                    Dim_Item_Main_GroupDAOs.Add(Dim_Item_Main_Group);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Item_Main_GroupDAOs);

            return true;
        }

        // Transform sang bảng dim_item_group_level_1
        private async Task<bool> Build_Dim_Item_Group_Level_1()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            var Dim_Item_Group_Level_1DAOs = await DataContext.Dim_Item_Group_Level_1.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_Item_Group_Level_1DAO Dim_Item_Group_Level_1 = Dim_Item_Group_Level_1DAOs.
                    Where(x => x.ItemGroupLevel1Name == Raw_Product_GroupDAO.NhomC1).FirstOrDefault();

                if (Dim_Item_Group_Level_1 == null && Raw_Product_GroupDAO.NhomC1 != null && Raw_Product_GroupDAO.NhomC1 != "0")
                {
                    Dim_Item_Group_Level_1 = new Dim_Item_Group_Level_1DAO
                    {
                        ItemGroupLevel1Name = Raw_Product_GroupDAO.NhomC1,
                    };
                    Dim_Item_Group_Level_1DAOs.Add(Dim_Item_Group_Level_1);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Item_Group_Level_1DAOs);

            return true;
        }

        // Transform sang bảng dim_item_group_level_2
        private async Task<bool> Build_Dim_Item_Group_Level_2()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            var Dim_Item_Group_Level_2DAOs = await DataContext.Dim_Item_Group_Level_2.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_Item_Group_Level_2DAO Dim_Item_Group_Level_2 = Dim_Item_Group_Level_2DAOs.
                    Where(x => x.ItemGroupLevel2Name == Raw_Product_GroupDAO.NhomC2).FirstOrDefault();

                if (Dim_Item_Group_Level_2 == null && Raw_Product_GroupDAO.NhomC2 != null && Raw_Product_GroupDAO.NhomC2 != "0")
                {
                    Dim_Item_Group_Level_2 = new Dim_Item_Group_Level_2DAO
                    {
                        ItemGroupLevel2Name = Raw_Product_GroupDAO.NhomC2,
                    };
                    Dim_Item_Group_Level_2DAOs.Add(Dim_Item_Group_Level_2);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Item_Group_Level_2DAOs);

            return true;
        }

        // Transform bảng dim_item_group_level_3
        private async Task<bool> Build_Dim_Item_Group_Level_3()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            var Dim_Item_Group_Level_3DAOs = await DataContext.Dim_Item_Group_Level_3.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_Item_Group_Level_3DAO Dim_Item_Group_Level_3 = Dim_Item_Group_Level_3DAOs.
                    Where(x => x.ItemGroupLevel3Name == Raw_Product_GroupDAO.NhomC3).FirstOrDefault();

                if (Dim_Item_Group_Level_3 == null && Raw_Product_GroupDAO.NhomC3 != null && Raw_Product_GroupDAO.NhomC3 != "0")
                {
                    Dim_Item_Group_Level_3 = new Dim_Item_Group_Level_3DAO
                    {
                        ItemGroupLevel3Name = Raw_Product_GroupDAO.NhomC3,
                    };
                    Dim_Item_Group_Level_3DAOs.Add(Dim_Item_Group_Level_3);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Item_Group_Level_3DAOs);

            return true;
        }

        // Transform bảng dim_item_led_smart_group
        private async Task<bool> Build_Dim_Item_Led_Smart_Group()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            var Dim_Item_Led_Smart_GroupDAOs = await DataContext.Dim_Item_Led_Smart_Group.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_Item_Led_Smart_GroupDAO Dim_Item_Led_Smart_Group = Dim_Item_Led_Smart_GroupDAOs
                    .Where(x => x.ItemLedSmartGroupName == Raw_Product_GroupDAO.Nhom_LEDSMRT1).FirstOrDefault();
                if (Dim_Item_Led_Smart_Group == null && Raw_Product_GroupDAO.Nhom_LEDSMRT1 != null
                    && Raw_Product_GroupDAO.Nhom_LEDSMRT1 != "0")
                {
                    Dim_Item_Led_Smart_Group = new Dim_Item_Led_Smart_GroupDAO
                    {
                        ItemLedSmartGroupName = Raw_Product_GroupDAO.Nhom_LEDSMRT1,
                    };
                    Dim_Item_Led_Smart_GroupDAOs.Add(Dim_Item_Led_Smart_Group);
                }

            }
            await DataContext.BulkMergeAsync(Dim_Item_Led_Smart_GroupDAOs);

            return true;
        }

        private async Task<bool> Build_Dim_Item_Mapping()
        {
            List<Dim_ItemDAO> ItemDAOs = await DataContext.Dim_Item.ToListAsync();
            List<Dim_Item_Type_GroupDAO> ItemTypeGroupDAOs = await DataContext.Dim_Item_Type_Group.ToListAsync();
            List<Dim_Item_Main_GroupDAO> ItemMainGroupDAOs = await DataContext.Dim_Item_Main_Group.ToListAsync();
            List<Dim_Item_Group_Level_1DAO> ItemGroupLevel1DAOs = await DataContext.Dim_Item_Group_Level_1.ToListAsync();
            List<Dim_Item_Group_Level_2DAO> ItemGroupLevel2DAOs = await DataContext.Dim_Item_Group_Level_2.ToListAsync();
            List<Dim_Item_Group_Level_3DAO> ItemGroupLevel3DAOs = await DataContext.Dim_Item_Group_Level_3.ToListAsync();
            List<Dim_Item_Led_Smart_GroupDAO> ItemLedSmartGroupDAOs = await DataContext.Dim_Item_Led_Smart_Group.ToListAsync();
            List<Dim_Item_MappingDAO> DimItemMappingDAOs = await DataContext.Dim_Item_Mapping.ToListAsync();

            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                var ItemDAO = ItemDAOs.Where(x => x.ItemCode == Raw_Product_GroupDAO.ItemCode).FirstOrDefault();
                var ItemTypeGroupDAO = ItemTypeGroupDAOs.Where(x => x.ItemTypeName == Raw_Product_GroupDAO.Loai_MHang_KH).FirstOrDefault();
                var ItemMainGroupDAO = ItemMainGroupDAOs.Where(x => x.ItemMainGroupName == Raw_Product_GroupDAO.Nhomchinh_KH).FirstOrDefault();
                var ItemGroupLevel1DAO = ItemGroupLevel1DAOs.Where(x => x.ItemGroupLevel1Name == Raw_Product_GroupDAO.NhomC1).FirstOrDefault();
                var ItemGroupLevel2DAO = ItemGroupLevel2DAOs.Where(x => x.ItemGroupLevel2Name == Raw_Product_GroupDAO.NhomC2).FirstOrDefault();
                var ItemGroupLevel3DAO = ItemGroupLevel3DAOs.Where(x => x.ItemGroupLevel3Name == Raw_Product_GroupDAO.NhomC3).FirstOrDefault();
                var ItemLedSmartGroupDAO = ItemLedSmartGroupDAOs.Where(x => x.ItemLedSmartGroupName == Raw_Product_GroupDAO.Nhom_LEDSMRT1).FirstOrDefault();

                Dim_Item_MappingDAO Dim_Item_Mapping = DimItemMappingDAOs.
                    Where(x => x.ItemId == ItemDAO?.ItemId).FirstOrDefault();

                if (Dim_Item_Mapping == null)
                {
                    Dim_Item_Mapping = new Dim_Item_MappingDAO
                    {
                        ItemId = ItemDAO?.ItemId ?? null,
                        ItemTypeId = ItemTypeGroupDAO?.ItemTypeId ?? null,
                        ItemMainGroupId = ItemMainGroupDAO?.ItemMainGroupId ?? null,
                        ItemGroupLevel1Id = ItemGroupLevel1DAO?.ItemGroupLevel1Id ?? null,
                        ItemGroupLevel2Id = ItemGroupLevel2DAO?.ItemGroupLevel2Id ?? null,
                        ItemGroupLevel3Id = ItemGroupLevel3DAO?.ItemGroupLevel3Id ?? null,
                        ItemLedSmartGroupId = ItemLedSmartGroupDAO?.ItemLedSmartGroupId ?? null,
                    };
                    DimItemMappingDAOs.Add(Dim_Item_Mapping);
                }
                else
                {
                    Dim_Item_Mapping.ItemTypeId = ItemTypeGroupDAO?.ItemTypeId ?? null;
                    Dim_Item_Mapping.ItemMainGroupId = ItemMainGroupDAO?.ItemMainGroupId ?? null;
                    Dim_Item_Mapping.ItemGroupLevel1Id = ItemGroupLevel1DAO?.ItemGroupLevel1Id ?? null;
                    Dim_Item_Mapping.ItemGroupLevel2Id = ItemGroupLevel2DAO?.ItemGroupLevel2Id ?? null;
                    Dim_Item_Mapping.ItemGroupLevel3Id = ItemGroupLevel3DAO?.ItemGroupLevel3Id ?? null;
                    Dim_Item_Mapping.ItemLedSmartGroupId = ItemLedSmartGroupDAO?.ItemLedSmartGroupId ?? null;
                }
            }
            await DataContext.BulkMergeAsync(DimItemMappingDAOs);

            return true;
        }
    }
}
