using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Dim_ItemDAO = DW_Test.Models.Dim_ItemDAO;
using Raw_Item_RepDAO = DW_Test.Models.Raw_Item_RepDAO;

namespace DW_Test.Services.MItemService
{
    public interface IItemService : IServiceScoped
    {
        Task<bool> ItemInit();

        Task<bool> IncrementalItemInit();
        Task ItemTransform();
    }
    public class ItemService : IItemService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;

        public ItemService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        public async Task<bool> ItemInit()
        {
            List<Raw_Item_RepDAO> Raw_Item_RepLocalDAOs = await DataContext.Raw_Item_Rep.ToListAsync();
            List<DWEModels.Raw_Item_RepDAO> Raw_Item_RepRemoteDAOs = await DWEContext.Raw_Item_Rep.ToListAsync();

            await DataContext.BulkDeleteAsync(Raw_Item_RepLocalDAOs);
            List<Raw_Item_RepDAO> Raw_Item_RepNewDAOs = Raw_Item_RepRemoteDAOs.Select(x => new Raw_Item_RepDAO()
            {
                ItemCode = x.ItemCode,
                ItemName = x.ItemName,
            }).ToList();

            await DataContext.BulkMergeAsync(Raw_Item_RepNewDAOs);

            return true;
        }

        public async Task<bool> IncrementalItemInit()
        {
            List<Raw_Item_RepDAO> Raw_Item_RepLocalDAOs = await DataContext.Raw_Item_Rep.ToListAsync();

            List<DWEModels.Raw_Item_RepDAO> Raw_Item_RepRemoteDAOs = await DWEContext.Raw_Item_Rep.ToListAsync();

            List<Raw_Item_RepDAO> InsertList = new List<Raw_Item_RepDAO>();

            List<Raw_Item_RepDAO> UpdateList = new List<Raw_Item_RepDAO>();

            List<Raw_Item_RepDAO> DeleteList = new List<Raw_Item_RepDAO>();

            int index = 0;

            for (int j = 0; j < Raw_Item_RepRemoteDAOs.Count && index < Raw_Item_RepLocalDAOs.Count;)
            {
                if (Raw_Item_RepRemoteDAOs[j].ItemCode.CompareTo
                    (Raw_Item_RepLocalDAOs[index].ItemCode) < 0)
                {
                    InsertList.Add(new Raw_Item_RepDAO()
                    {
                        ItemCode = Raw_Item_RepRemoteDAOs[j].ItemCode,
                        ItemName = Raw_Item_RepRemoteDAOs[j].ItemName,
                    });
                    
                    j++;
                }
                else if (Raw_Item_RepRemoteDAOs[j].ItemCode.CompareTo
                    (Raw_Item_RepLocalDAOs[index].ItemCode) == 0)
                {
                    if (Raw_Item_RepRemoteDAOs[j].ItemName != Raw_Item_RepLocalDAOs[index].ItemName)
                    {
                        UpdateList.Add(new Raw_Item_RepDAO()
                        {
                            Id = Raw_Item_RepLocalDAOs[index].Id,
                            ItemCode = Raw_Item_RepRemoteDAOs[j].ItemCode,
                            ItemName = Raw_Item_RepRemoteDAOs[j].ItemName
                        });
                    }

                    index++;

                    j++;
                }
                else
                {
                    DeleteList.Add(new Raw_Item_RepDAO()
                    {
                        Id = Raw_Item_RepLocalDAOs[index].Id,
                        ItemCode = Raw_Item_RepLocalDAOs[index].ItemCode,
                        ItemName = Raw_Item_RepLocalDAOs[index].ItemName
                    });

                    index++;
                }
            }

            if (index == Raw_Item_RepLocalDAOs.Count)
            {
                while (index < Raw_Item_RepRemoteDAOs.Count)
                {
                    InsertList.Add(new Raw_Item_RepDAO()
                    {
                        ItemCode = Raw_Item_RepRemoteDAOs[index].ItemCode,
                        ItemName = Raw_Item_RepRemoteDAOs[index].ItemName,
                    });

                    index++;
                }
            } else if (index < Raw_Item_RepLocalDAOs.Count)
            {
                while (index < Raw_Item_RepLocalDAOs.Count)
                {
                    DeleteList.Add(new Raw_Item_RepDAO()
                    {
                        Id = Raw_Item_RepLocalDAOs[index].Id,
                        ItemCode = Raw_Item_RepLocalDAOs[index].ItemCode,
                        ItemName = Raw_Item_RepLocalDAOs[index].ItemName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }

        public async Task ItemTransform()
        {
            await Build_Dim_Item();
        }

        // Tạo bảng dim_item
        private async Task<bool> Build_Dim_Item()
        {
            List<Raw_Item_RepDAO> Raw_Item_RepDAOs = await DataContext.Raw_Item_Rep
                .Where(x => !string.IsNullOrEmpty(x.ItemCode)).ToListAsync();
            List<Dim_ItemDAO> Dim_ItemDAOs = await DataContext.Dim_Item.ToListAsync();

            foreach (var Raw_Item_RepDAO in Raw_Item_RepDAOs)
            {
                Dim_ItemDAO Dim_Item = Dim_ItemDAOs.Where(x => x.ItemCode == Raw_Item_RepDAO.ItemCode).FirstOrDefault();

                if (Dim_Item == null)
                {
                    Dim_Item = new Dim_ItemDAO
                    {
                        ItemName = Raw_Item_RepDAO.ItemName,
                        ItemCode = Raw_Item_RepDAO.ItemCode,
                    };
                    Dim_ItemDAOs.Add(Dim_Item);
                }
                else
                {
                    Dim_Item.ItemName = Raw_Item_RepDAO.ItemName;
                }
            }
            await DataContext.BulkMergeAsync(Dim_ItemDAOs);
            
            return true;
        }
    }
}
