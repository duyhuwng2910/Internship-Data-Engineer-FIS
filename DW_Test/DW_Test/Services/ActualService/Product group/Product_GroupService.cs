using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.ActualSerivce.Product_GroupService
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

            List<Dim_ItemTypeGroupDAO> Dim_ItemTypeGroupLocalDAOs = await DataContext.Dim_ItemTypeGroup.ToListAsync();

            List<Dim_ItemTypeGroupDAO> Dim_ItemTypeGroupRemoteDAOs = new List<Dim_ItemTypeGroupDAO>();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                var Loai_MHang_KH = Raw_Product_GroupDAO.Loai_MHang_KH;

                if (Loai_MHang_KH != "0")
                {
                    Dim_ItemTypeGroupRemoteDAOs.Add(new Dim_ItemTypeGroupDAO
                    {
                        ItemTypeName = Loai_MHang_KH
                    });
                }
            }

            Dim_ItemTypeGroupLocalDAOs = Dim_ItemTypeGroupLocalDAOs.OrderBy(x => x.ItemTypeName).ToList();

            Dim_ItemTypeGroupRemoteDAOs = Dim_ItemTypeGroupRemoteDAOs.OrderBy(x => x.ItemTypeName).ToList();

            List<Dim_ItemTypeGroupDAO> InsertList = new List<Dim_ItemTypeGroupDAO>();

            List<Dim_ItemTypeGroupDAO> DeleteList = new List<Dim_ItemTypeGroupDAO>();

            int index = 0;

            for (int j = 0; j < Dim_ItemTypeGroupRemoteDAOs.Count && index < Dim_ItemTypeGroupLocalDAOs.Count;)
            {
                if (CompareMethod.Compare(Dim_ItemTypeGroupRemoteDAOs[j].ItemTypeName,
                                            Dim_ItemTypeGroupLocalDAOs[index].ItemTypeName) < 0)
                {
                    InsertList.Add(new Dim_ItemTypeGroupDAO()
                    {
                        ItemTypeName = Dim_ItemTypeGroupRemoteDAOs[j].ItemTypeName
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Dim_ItemTypeGroupRemoteDAOs[j].ItemTypeName,
                                            Dim_ItemTypeGroupLocalDAOs[index].ItemTypeName) == 0)
                {
                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Dim_ItemTypeGroupRemoteDAOs[j].ItemTypeName,
                                            Dim_ItemTypeGroupLocalDAOs[index].ItemTypeName) > 0)
                {
                    DeleteList.Add(new Dim_ItemTypeGroupDAO()
                    {
                        ItemTypeName = Dim_ItemTypeGroupLocalDAOs[index].ItemTypeName
                    });

                    index++;
                }
            }

            if (index == Dim_ItemTypeGroupLocalDAOs.Count &&
                Dim_ItemTypeGroupRemoteDAOs.Last().ItemTypeName
                != Dim_ItemTypeGroupLocalDAOs.Last().ItemTypeName)
            {
                while (index < Dim_ItemTypeGroupRemoteDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemTypeGroupDAO()
                    {
                        ItemTypeName = Dim_ItemTypeGroupRemoteDAOs[index].ItemTypeName
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemTypeGroupLocalDAOs.Count)
            {
                while (index < Dim_ItemTypeGroupLocalDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemTypeGroupDAO()
                    {
                        ItemTypeName = Dim_ItemTypeGroupLocalDAOs[index].ItemTypeName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);

            return true;
        }

        // Tranform sang bảng Dim_ItemMainGroup
        private async Task<bool> Build_DimItemMainGroup()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.Nhomchinh_KH)).ToListAsync();

            List<Dim_ItemMainGroupDAO> Dim_ItemMainGroupLocalDAOs = await DataContext.Dim_ItemMainGroup.ToListAsync();

            List<Dim_ItemMainGroupDAO> Dim_ItemMainGroupRemoteDAOs = new List<Dim_ItemMainGroupDAO>();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                if (Raw_Product_GroupDAO.Nhomchinh_KH != "0")
                {
                    Dim_ItemMainGroupRemoteDAOs.Add(new Dim_ItemMainGroupDAO
                    {
                        ItemMainGroupName = Raw_Product_GroupDAO.Nhomchinh_KH,
                    });
                }
            }

            Dim_ItemMainGroupLocalDAOs = Dim_ItemMainGroupLocalDAOs.OrderBy(x => x.ItemMainGroupName).ToList();

            Dim_ItemMainGroupRemoteDAOs = Dim_ItemMainGroupRemoteDAOs.OrderBy(x => x.ItemMainGroupName).ToList();

            List<Dim_ItemMainGroupDAO> InsertList = new List<Dim_ItemMainGroupDAO>();

            List<Dim_ItemMainGroupDAO> DeleteList = new List<Dim_ItemMainGroupDAO>();

            int index = 0;

            for (int j = 0; j < Dim_ItemMainGroupRemoteDAOs.Count && index < Dim_ItemMainGroupLocalDAOs.Count;)
            {
                if (CompareMethod.Compare(Dim_ItemMainGroupRemoteDAOs[j].ItemMainGroupName,
                                            Dim_ItemMainGroupLocalDAOs[index].ItemMainGroupName) < 0)
                {
                    InsertList.Add(new Dim_ItemMainGroupDAO()
                    {
                        ItemMainGroupName = Dim_ItemMainGroupRemoteDAOs[j].ItemMainGroupName
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Dim_ItemMainGroupRemoteDAOs[j].ItemMainGroupName,
                                            Dim_ItemMainGroupLocalDAOs[index].ItemMainGroupName) == 0)
                {
                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Dim_ItemMainGroupRemoteDAOs[j].ItemMainGroupName,
                                            Dim_ItemMainGroupLocalDAOs[index].ItemMainGroupName) > 0)
                {
                    DeleteList.Add(new Dim_ItemMainGroupDAO()
                    {
                        ItemMainGroupName = Dim_ItemMainGroupLocalDAOs[index].ItemMainGroupName
                    });

                    index++;
                }
            }

            if (index == Dim_ItemMainGroupLocalDAOs.Count &&
                Dim_ItemMainGroupRemoteDAOs.Last().ItemMainGroupName
                != Dim_ItemMainGroupLocalDAOs.Last().ItemMainGroupName)
            {
                while (index < Dim_ItemMainGroupRemoteDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemMainGroupDAO()
                    {
                        ItemMainGroupName = Dim_ItemMainGroupRemoteDAOs[index].ItemMainGroupName
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemMainGroupLocalDAOs.Count)
            {
                while (index < Dim_ItemMainGroupLocalDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemMainGroupDAO()
                    {
                        ItemMainGroupName = Dim_ItemMainGroupLocalDAOs[index].ItemMainGroupName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);

            return true;
        }

        // Transform sang bảng Dim_ItemGroupLevel1
        private async Task<bool> Build_Dim_ItemGroupLevel1()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.NhomC1)).ToListAsync();

            List<Dim_ItemGroupLevel1DAO> Dim_ItemGroupLevel1LocalDAOs = await DataContext.Dim_ItemGroupLevel1.ToListAsync();

            List<Dim_ItemGroupLevel1DAO> Dim_ItemGroupLevel1RemoteDAOs = new List<Dim_ItemGroupLevel1DAO>();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                if (Raw_Product_GroupDAO.NhomC1 != "0")
                {
                    Dim_ItemGroupLevel1RemoteDAOs.Add(new Dim_ItemGroupLevel1DAO()
                    {
                        ItemGroupLevel1Name = Raw_Product_GroupDAO.NhomC1,
                    });
                }
            }

            Dim_ItemGroupLevel1LocalDAOs = Dim_ItemGroupLevel1LocalDAOs.OrderBy(x => x.ItemGroupLevel1Name).ToList();

            Dim_ItemGroupLevel1RemoteDAOs = Dim_ItemGroupLevel1RemoteDAOs.OrderBy(x => x.ItemGroupLevel1Name).ToList();

            List<Dim_ItemGroupLevel1DAO> InsertList = new List<Dim_ItemGroupLevel1DAO>();

            List<Dim_ItemGroupLevel1DAO> DeleteList = new List<Dim_ItemGroupLevel1DAO>();

            int index = 0;

            for (int j = 0; j < Dim_ItemGroupLevel1RemoteDAOs.Count && index < Dim_ItemGroupLevel1LocalDAOs.Count;)
            {
                if (CompareMethod.Compare(Dim_ItemGroupLevel1RemoteDAOs[j].ItemGroupLevel1Name,
                                            Dim_ItemGroupLevel1LocalDAOs[index].ItemGroupLevel1Name) < 0)
                {
                    InsertList.Add(new Dim_ItemGroupLevel1DAO()
                    {
                        ItemGroupLevel1Name = Dim_ItemGroupLevel1RemoteDAOs[j].ItemGroupLevel1Name
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Dim_ItemGroupLevel1RemoteDAOs[j].ItemGroupLevel1Name,
                                            Dim_ItemGroupLevel1LocalDAOs[index].ItemGroupLevel1Name) == 0)
                {
                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Dim_ItemGroupLevel1RemoteDAOs[j].ItemGroupLevel1Name,
                                            Dim_ItemGroupLevel1LocalDAOs[index].ItemGroupLevel1Name) > 0)
                {
                    DeleteList.Add(new Dim_ItemGroupLevel1DAO()
                    {
                        ItemGroupLevel1Name = Dim_ItemGroupLevel1LocalDAOs[index].ItemGroupLevel1Name
                    });

                    index++;
                }
            }

            if (index == Dim_ItemGroupLevel1LocalDAOs.Count &&
                Dim_ItemGroupLevel1RemoteDAOs.Last().ItemGroupLevel1Name
                != Dim_ItemGroupLevel1LocalDAOs.Last().ItemGroupLevel1Name)
            {
                while (index < Dim_ItemGroupLevel1RemoteDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemGroupLevel1DAO()
                    {
                        ItemGroupLevel1Name = Dim_ItemGroupLevel1RemoteDAOs[index].ItemGroupLevel1Name
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemGroupLevel1LocalDAOs.Count)
            {
                while (index < Dim_ItemGroupLevel1LocalDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemGroupLevel1DAO()
                    {
                        ItemGroupLevel1Name = Dim_ItemGroupLevel1LocalDAOs[index].ItemGroupLevel1Name
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);

            return true;
        }

        // Transform sang bảng Dim_ItemGroupLevel2
        private async Task<bool> Build_Dim_ItemGroupLevel2()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.NhomC2)).ToListAsync();

            List<Dim_ItemGroupLevel2DAO> Dim_ItemGroupLevel2LocalDAOs = await DataContext.Dim_ItemGroupLevel2.ToListAsync();

            List<Dim_ItemGroupLevel2DAO> Dim_ItemGroupLevel2RemoteDAOs = new List<Dim_ItemGroupLevel2DAO>();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                if (Raw_Product_GroupDAO.NhomC2 != "0")
                {
                    Dim_ItemGroupLevel2RemoteDAOs.Add(new Dim_ItemGroupLevel2DAO()
                    {
                        ItemGroupLevel2Name = Raw_Product_GroupDAO.NhomC2,
                    });
                }
            }

            Dim_ItemGroupLevel2LocalDAOs = Dim_ItemGroupLevel2LocalDAOs.OrderBy(x => x.ItemGroupLevel2Name).ToList();

            Dim_ItemGroupLevel2RemoteDAOs = Dim_ItemGroupLevel2RemoteDAOs.OrderBy(x => x.ItemGroupLevel2Name).ToList();

            List<Dim_ItemGroupLevel2DAO> InsertList = new List<Dim_ItemGroupLevel2DAO>();

            List<Dim_ItemGroupLevel2DAO> DeleteList = new List<Dim_ItemGroupLevel2DAO>();

            int index = 0;

            for (int j = 0; j < Dim_ItemGroupLevel2RemoteDAOs.Count && index < Dim_ItemGroupLevel2LocalDAOs.Count;)
            {
                if (CompareMethod.Compare(Dim_ItemGroupLevel2RemoteDAOs[j].ItemGroupLevel2Name,
                                            Dim_ItemGroupLevel2LocalDAOs[index].ItemGroupLevel2Name) < 0)
                {
                    InsertList.Add(new Dim_ItemGroupLevel2DAO()
                    {
                        ItemGroupLevel2Name = Dim_ItemGroupLevel2RemoteDAOs[j].ItemGroupLevel2Name
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Dim_ItemGroupLevel2RemoteDAOs[j].ItemGroupLevel2Name,
                                            Dim_ItemGroupLevel2LocalDAOs[index].ItemGroupLevel2Name) == 0)
                {
                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Dim_ItemGroupLevel2RemoteDAOs[j].ItemGroupLevel2Name,
                                            Dim_ItemGroupLevel2LocalDAOs[index].ItemGroupLevel2Name) > 0)
                {
                    DeleteList.Add(new Dim_ItemGroupLevel2DAO()
                    {
                        ItemGroupLevel2Name = Dim_ItemGroupLevel2LocalDAOs[index].ItemGroupLevel2Name
                    });

                    index++;
                }
            }

            if (index == Dim_ItemGroupLevel2LocalDAOs.Count &&
                Dim_ItemGroupLevel2RemoteDAOs.Last().ItemGroupLevel2Name
                != Dim_ItemGroupLevel2LocalDAOs.Last().ItemGroupLevel2Name)
            {
                while (index < Dim_ItemGroupLevel2RemoteDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemGroupLevel2DAO()
                    {
                        ItemGroupLevel2Name = Dim_ItemGroupLevel2RemoteDAOs[index].ItemGroupLevel2Name
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemGroupLevel2LocalDAOs.Count)
            {
                while (index < Dim_ItemGroupLevel2LocalDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemGroupLevel2DAO()
                    {
                        ItemGroupLevel2Name = Dim_ItemGroupLevel2LocalDAOs[index].ItemGroupLevel2Name
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);

            return true;
        }

        // Transform bảng Dim_ItemGroupLevel3
        private async Task<bool> Build_Dim_ItemGroupLevel3()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.NhomC3)).ToListAsync();

            List<Dim_ItemGroupLevel3DAO> Dim_ItemGroupLevel3LocalDAOs = await DataContext.Dim_ItemGroupLevel3.ToListAsync();

            List<Dim_ItemGroupLevel3DAO> Dim_ItemGroupLevel3RemoteDAOs = new List<Dim_ItemGroupLevel3DAO>();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                if (Raw_Product_GroupDAO.NhomC3 != "0")
                {
                    Dim_ItemGroupLevel3RemoteDAOs.Add(new Dim_ItemGroupLevel3DAO()
                    {
                        ItemGroupLevel3Name = Raw_Product_GroupDAO.NhomC3,
                    });
                }
            }

            Dim_ItemGroupLevel3LocalDAOs = Dim_ItemGroupLevel3LocalDAOs.OrderBy(x => x.ItemGroupLevel3Name).ToList();

            Dim_ItemGroupLevel3RemoteDAOs = Dim_ItemGroupLevel3RemoteDAOs.OrderBy(x => x.ItemGroupLevel3Name).ToList();

            List<Dim_ItemGroupLevel3DAO> InsertList = new List<Dim_ItemGroupLevel3DAO>();

            List<Dim_ItemGroupLevel3DAO> DeleteList = new List<Dim_ItemGroupLevel3DAO>();

            int index = 0;

            for (int j = 0; j < Dim_ItemGroupLevel3RemoteDAOs.Count && index < Dim_ItemGroupLevel3LocalDAOs.Count;)
            {
                if (CompareMethod.Compare(Dim_ItemGroupLevel3RemoteDAOs[j].ItemGroupLevel3Name,
                                            Dim_ItemGroupLevel3LocalDAOs[index].ItemGroupLevel3Name) < 0)
                {
                    InsertList.Add(new Dim_ItemGroupLevel3DAO()
                    {
                        ItemGroupLevel3Name = Dim_ItemGroupLevel3RemoteDAOs[j].ItemGroupLevel3Name
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Dim_ItemGroupLevel3RemoteDAOs[j].ItemGroupLevel3Name,
                                            Dim_ItemGroupLevel3LocalDAOs[index].ItemGroupLevel3Name) == 0)
                {
                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Dim_ItemGroupLevel3RemoteDAOs[j].ItemGroupLevel3Name,
                                            Dim_ItemGroupLevel3LocalDAOs[index].ItemGroupLevel3Name) > 0)
                {
                    DeleteList.Add(new Dim_ItemGroupLevel3DAO()
                    {
                        ItemGroupLevel3Name = Dim_ItemGroupLevel3LocalDAOs[index].ItemGroupLevel3Name
                    });

                    index++;
                }
            }

            if (index == Dim_ItemGroupLevel3LocalDAOs.Count &&
                Dim_ItemGroupLevel3RemoteDAOs.Last().ItemGroupLevel3Name
                != Dim_ItemGroupLevel3LocalDAOs.Last().ItemGroupLevel3Name)
            {
                while (index < Dim_ItemGroupLevel3RemoteDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemGroupLevel3DAO()
                    {
                        ItemGroupLevel3Name = Dim_ItemGroupLevel3RemoteDAOs[index].ItemGroupLevel3Name
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemGroupLevel3LocalDAOs.Count)
            {
                while (index < Dim_ItemGroupLevel3LocalDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemGroupLevel3DAO()
                    {
                        ItemGroupLevel3Name = Dim_ItemGroupLevel3LocalDAOs[index].ItemGroupLevel3Name
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);

            return true;
        }

        // Transform bảng Dim_ItemLedSmartGroup
        private async Task<bool> Build_Dim_ItemLedSmartGroup()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.Nhom_LEDSMRT1)).ToListAsync();

            List<Dim_ItemLedSmartGroupDAO> Dim_ItemLedSmartGroupLocalDAOs =
                await DataContext.Dim_ItemLedSmartGroup.ToListAsync();

            List<Dim_ItemLedSmartGroupDAO> Dim_ItemLedSmartGroupRemoteDAOs = new List<Dim_ItemLedSmartGroupDAO>();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                if (Raw_Product_GroupDAO.Nhom_LEDSMRT1 != "0")
                {
                    Dim_ItemLedSmartGroupRemoteDAOs.Add(new Dim_ItemLedSmartGroupDAO
                    {
                        ItemLedSmartGroupName = Raw_Product_GroupDAO.Nhom_LEDSMRT1,
                    });
                }
            }

            Dim_ItemLedSmartGroupLocalDAOs = Dim_ItemLedSmartGroupLocalDAOs.OrderBy(x => x.ItemLedSmartGroupName).ToList();

            Dim_ItemLedSmartGroupRemoteDAOs = Dim_ItemLedSmartGroupRemoteDAOs.OrderBy(x => x.ItemLedSmartGroupName).ToList();

            List<Dim_ItemLedSmartGroupDAO> InsertList = new List<Dim_ItemLedSmartGroupDAO>();

            List<Dim_ItemLedSmartGroupDAO> DeleteList = new List<Dim_ItemLedSmartGroupDAO>();

            int index = 0;

            for (int j = 0; j < Dim_ItemLedSmartGroupRemoteDAOs.Count && index < Dim_ItemLedSmartGroupLocalDAOs.Count;)
            {
                if (CompareMethod.Compare(Dim_ItemLedSmartGroupRemoteDAOs[j].ItemLedSmartGroupName,
                                            Dim_ItemLedSmartGroupLocalDAOs[index].ItemLedSmartGroupName) < 0)
                {
                    InsertList.Add(new Dim_ItemLedSmartGroupDAO()
                    {
                        ItemLedSmartGroupName = Dim_ItemLedSmartGroupRemoteDAOs[j].ItemLedSmartGroupName
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Dim_ItemLedSmartGroupRemoteDAOs[j].ItemLedSmartGroupName,
                                            Dim_ItemLedSmartGroupLocalDAOs[index].ItemLedSmartGroupName) == 0)
                {
                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Dim_ItemLedSmartGroupRemoteDAOs[j].ItemLedSmartGroupName,
                                            Dim_ItemLedSmartGroupLocalDAOs[index].ItemLedSmartGroupName) > 0)
                {
                    DeleteList.Add(new Dim_ItemLedSmartGroupDAO()
                    {
                        ItemLedSmartGroupName = Dim_ItemLedSmartGroupLocalDAOs[index].ItemLedSmartGroupName
                    });

                    index++;
                }
            }

            if (index == Dim_ItemLedSmartGroupLocalDAOs.Count &&
                Dim_ItemLedSmartGroupRemoteDAOs.Last().ItemLedSmartGroupName
                != Dim_ItemLedSmartGroupLocalDAOs.Last().ItemLedSmartGroupName)
            {
                while (index < Dim_ItemLedSmartGroupRemoteDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemLedSmartGroupDAO()
                    {
                        ItemLedSmartGroupName = Dim_ItemLedSmartGroupRemoteDAOs[index].ItemLedSmartGroupName
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemLedSmartGroupLocalDAOs.Count)
            {
                while (index < Dim_ItemLedSmartGroupLocalDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemLedSmartGroupDAO()
                    {
                        ItemLedSmartGroupName = Dim_ItemLedSmartGroupLocalDAOs[index].ItemLedSmartGroupName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);

            return true;
        }

        // Transform bảng Dim_ItemSingleLedSmartGroup
        private async Task<bool> Build_Dim_ItemSingleLedSmartGroup()
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group
                .Where(x => !string.IsNullOrEmpty(x.Nhom_SMARTDONLE)).ToListAsync();

            List<Dim_ItemSingleLedSmartGroupDAO> Dim_ItemSingleLedSmartGroupLocalDAOs
                = await DataContext.Dim_ItemSingleLedSmartGroup.ToListAsync();

            List<Dim_ItemSingleLedSmartGroupDAO> Dim_ItemSingleLedSmartGroupRemoteDAOs
                = new List<Dim_ItemSingleLedSmartGroupDAO>();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                if (Raw_Product_GroupDAO.Nhom_SMARTDONLE != "0")
                {
                    Dim_ItemSingleLedSmartGroupRemoteDAOs.Add(new Dim_ItemSingleLedSmartGroupDAO
                    {
                        ItemSingleLedSmartGroupName = Raw_Product_GroupDAO.Nhom_SMARTDONLE,
                    });
                }
            }

            Dim_ItemSingleLedSmartGroupLocalDAOs = Dim_ItemSingleLedSmartGroupLocalDAOs.OrderBy(x => x.ItemSingleLedSmartGroupName).ToList();

            Dim_ItemSingleLedSmartGroupRemoteDAOs = Dim_ItemSingleLedSmartGroupRemoteDAOs.OrderBy(x => x.ItemSingleLedSmartGroupName).ToList();

            List<Dim_ItemSingleLedSmartGroupDAO> InsertList = new List<Dim_ItemSingleLedSmartGroupDAO>();

            List<Dim_ItemSingleLedSmartGroupDAO> DeleteList = new List<Dim_ItemSingleLedSmartGroupDAO>();

            int index = 0;

            for (int j = 0; j < Dim_ItemSingleLedSmartGroupRemoteDAOs.Count && index < Dim_ItemSingleLedSmartGroupLocalDAOs.Count;)
            {
                if (CompareMethod.Compare(Dim_ItemSingleLedSmartGroupRemoteDAOs[j].ItemSingleLedSmartGroupName,
                                            Dim_ItemSingleLedSmartGroupLocalDAOs[index].ItemSingleLedSmartGroupName) < 0)
                {
                    InsertList.Add(new Dim_ItemSingleLedSmartGroupDAO()
                    {
                        ItemSingleLedSmartGroupName = Dim_ItemSingleLedSmartGroupRemoteDAOs[j].ItemSingleLedSmartGroupName
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Dim_ItemSingleLedSmartGroupRemoteDAOs[j].ItemSingleLedSmartGroupName,
                                            Dim_ItemSingleLedSmartGroupLocalDAOs[index].ItemSingleLedSmartGroupName) == 0)
                {
                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Dim_ItemSingleLedSmartGroupRemoteDAOs[j].ItemSingleLedSmartGroupName,
                                            Dim_ItemSingleLedSmartGroupLocalDAOs[index].ItemSingleLedSmartGroupName) > 0)
                {
                    DeleteList.Add(new Dim_ItemSingleLedSmartGroupDAO()
                    {
                        ItemSingleLedSmartGroupName = Dim_ItemSingleLedSmartGroupLocalDAOs[index].ItemSingleLedSmartGroupName
                    });

                    index++;
                }
            }

            if (index == Dim_ItemSingleLedSmartGroupLocalDAOs.Count &&
                Dim_ItemSingleLedSmartGroupRemoteDAOs.Last().ItemSingleLedSmartGroupName
                != Dim_ItemSingleLedSmartGroupLocalDAOs.Last().ItemSingleLedSmartGroupName)
            {
                while (index < Dim_ItemSingleLedSmartGroupRemoteDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemSingleLedSmartGroupDAO()
                    {
                        ItemSingleLedSmartGroupName = Dim_ItemSingleLedSmartGroupRemoteDAOs[index].ItemSingleLedSmartGroupName
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemSingleLedSmartGroupLocalDAOs.Count)
            {
                while (index < Dim_ItemSingleLedSmartGroupLocalDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemSingleLedSmartGroupDAO()
                    {
                        ItemSingleLedSmartGroupName = Dim_ItemSingleLedSmartGroupLocalDAOs[index].ItemSingleLedSmartGroupName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);

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

            List<Raw_Product_GroupDAO> Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            List<Dim_ItemMappingDAO> Dim_ItemMappingLocalDAOs = await DataContext.Dim_ItemMapping.ToListAsync();

            List<Dim_ItemMapping> HashLocal = Dim_ItemMappingLocalDAOs
                                            .Select(x => new Dim_ItemMapping(x)).ToList();

            List<Dim_ItemMappingDAO> Dim_ItemMappingRemoteDAOs = new List<Dim_ItemMappingDAO>();

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

                Dim_ItemMappingDAO Dim_ItemMapping = new Dim_ItemMappingDAO()
                {
                    ItemId = ItemDAO?.ItemId ?? null,
                    ItemCode = ItemDAO?.ItemCode ?? null,
                    ItemTypeId = ItemTypeGroupDAO?.ItemTypeId ?? null,
                    ItemMainGroupId = ItemMainGroupDAO?.ItemMainGroupId ?? null,
                    ItemGroupLevel1Id = ItemGroupLevel1DAO?.ItemGroupLevel1Id ?? null,
                    ItemGroupLevel2Id = ItemGroupLevel2DAO?.ItemGroupLevel2Id ?? null,
                    ItemGroupLevel3Id = ItemGroupLevel3DAO?.ItemGroupLevel3Id ?? null,
                    ItemLedSmartGroupId = ItemLedSmartGroupDAO?.ItemLedSmartGroupId ?? null,
                    ItemSingleLedSmartGroupId = ItemSingleLedSmartGroupDAO?.ItemSingleLedSmartGroupId ?? null
                };

                Dim_ItemMappingRemoteDAOs.Add(Dim_ItemMapping);
            }

            List<Dim_ItemMapping> HashRemote = Dim_ItemMappingRemoteDAOs
                                              .Select(x => new Dim_ItemMapping(x)).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            List<Dim_ItemMappingDAO> InsertList = new List<Dim_ItemMappingDAO>();

            List<Dim_ItemMappingDAO> UpdateList = new List<Dim_ItemMappingDAO>();

            List<Dim_ItemMappingDAO> DeleteList = new List<Dim_ItemMappingDAO>();

            int index = 0;

            for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
            {
                if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                {
                    InsertList.Add(new Dim_ItemMappingDAO()
                    {
                        ItemId = HashRemote[j].ItemId ?? null,
                        ItemCode = HashRemote[j].ItemCode ?? null,
                        ItemTypeId = HashRemote[j].ItemTypeId ?? null,
                        ItemMainGroupId = HashRemote[j].ItemMainGroupId ?? null,
                        ItemGroupLevel1Id = HashRemote[j].ItemGroupLevel1Id ?? null,
                        ItemGroupLevel2Id = HashRemote[j].ItemGroupLevel2Id ?? null,
                        ItemGroupLevel3Id = HashRemote[j].ItemGroupLevel3Id ?? null,
                        ItemLedSmartGroupId = HashRemote[j].ItemLedSmartGroupId ?? null,
                        ItemSingleLedSmartGroupId = HashRemote[j].ItemSingleLedSmartGroupId ?? null
                    });

                    j++;
                }
                else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                {
                    if (HashRemote[j].Value != HashLocal[index].Value)
                    {
                        UpdateList.Add(new Dim_ItemMappingDAO()
                        {
                            ItemId = HashLocal[index].ItemId ?? null,
                            ItemCode = HashLocal[index].ItemCode ?? null,
                            ItemTypeId = HashRemote[j].ItemTypeId ?? null,
                            ItemMainGroupId = HashRemote[j].ItemMainGroupId ?? null,
                            ItemGroupLevel1Id = HashRemote[j].ItemGroupLevel1Id ?? null,
                            ItemGroupLevel2Id = HashRemote[j].ItemGroupLevel2Id ?? null,
                            ItemGroupLevel3Id = HashRemote[j].ItemGroupLevel3Id ?? null,
                            ItemLedSmartGroupId = HashRemote[j].ItemLedSmartGroupId ?? null,
                            ItemSingleLedSmartGroupId = HashRemote[j].ItemSingleLedSmartGroupId ?? null
                        });
                    }

                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                {
                    DeleteList.Add(new Dim_ItemMappingDAO()
                    {
                        Item_MappingId = HashLocal[index].Item_MappingId,
                        ItemId = HashLocal[index].ItemId ?? null,
                        ItemCode = HashLocal[index].ItemCode ?? null,
                        ItemTypeId = HashLocal[index].ItemTypeId ?? null,
                        ItemMainGroupId = HashLocal[index].ItemMainGroupId ?? null,
                        ItemGroupLevel1Id = HashLocal[index].ItemGroupLevel1Id ?? null,
                        ItemGroupLevel2Id = HashLocal[index].ItemGroupLevel2Id ?? null,
                        ItemGroupLevel3Id = HashLocal[index].ItemGroupLevel3Id ?? null,
                        ItemLedSmartGroupId = HashLocal[index].ItemLedSmartGroupId ?? null,
                        ItemSingleLedSmartGroupId = HashLocal[index].ItemSingleLedSmartGroupId ?? null
                    });

                    index++;
                }
            }

            if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
            {
                while (index < HashRemote.Count)
                {
                    InsertList.Add(new Dim_ItemMappingDAO()
                    {
                        ItemId = HashRemote[index].ItemId ?? null,
                        ItemCode = HashRemote[index].ItemCode ?? null,
                        ItemTypeId = HashRemote[index].ItemTypeId ?? null,
                        ItemMainGroupId = HashRemote[index].ItemMainGroupId ?? null,
                        ItemGroupLevel1Id = HashRemote[index].ItemGroupLevel1Id ?? null,
                        ItemGroupLevel2Id = HashRemote[index].ItemGroupLevel2Id ?? null,
                        ItemGroupLevel3Id = HashRemote[index].ItemGroupLevel3Id ?? null,
                        ItemLedSmartGroupId = HashRemote[index].ItemLedSmartGroupId ?? null,
                        ItemSingleLedSmartGroupId = HashRemote[index].ItemSingleLedSmartGroupId ?? null
                    });

                    index++;
                }
            }
            else if (index < HashLocal.Count)
            {
                while (index < HashLocal.Count)
                {
                    DeleteList.Add(new Dim_ItemMappingDAO()
                    {
                        Item_MappingId = HashLocal[index].Item_MappingId,
                        ItemId = HashLocal[index].ItemId ?? null,
                        ItemCode = HashLocal[index].ItemCode ?? null,
                        ItemTypeId = HashLocal[index].ItemTypeId ?? null,
                        ItemMainGroupId = HashLocal[index].ItemMainGroupId ?? null,
                        ItemGroupLevel1Id = HashLocal[index].ItemGroupLevel1Id ?? null,
                        ItemGroupLevel2Id = HashLocal[index].ItemGroupLevel2Id ?? null,
                        ItemGroupLevel3Id = HashLocal[index].ItemGroupLevel3Id ?? null,
                        ItemLedSmartGroupId = HashLocal[index].ItemLedSmartGroupId ?? null,
                        ItemSingleLedSmartGroupId = HashLocal[index].ItemSingleLedSmartGroupId ?? null
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }
    }
}
