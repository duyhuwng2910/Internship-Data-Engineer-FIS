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
        Task Transform();
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
            List<Raw_Item_RepDAO> Raw_Item_RepLocalDAOS = await DataContext.Raw_Item_Rep.ToListAsync();
            List<DWEModels.Raw_Item_RepDAO> Raw_Item_RepRemoteDAOs = await DWEContext.Raw_Item_Rep.ToListAsync();

            await DataContext.BulkDeleteAsync(Raw_Item_RepLocalDAOS);
            List<Raw_Item_RepDAO> Raw_Item_RepNewDAOs = Raw_Item_RepRemoteDAOs.Select(x => new Raw_Item_RepDAO()
            {
                ItemCode = x.ItemCode,
                ItemName = x.ItemName,
            }).ToList();

            await DataContext.BulkMergeAsync(Raw_Item_RepNewDAOs);

            return true;
        }
        public async Task Transform()
        {
            await Build_Dim_Item();
        }
        private async Task<bool> Build_Dim_Item()
        {
            List<Raw_Item_RepDAO> Raw_Item_RepDAOs = await DataContext.Raw_Item_Rep.ToListAsync();
            List<Dim_ItemDAO> Dim_ItemDAOs = await DataContext.Dim_Item.ToListAsync();

            foreach (var Raw_Item_RepDAO in Raw_Item_RepDAOs)
            {
                Dim_ItemDAO Dim_Item = Dim_ItemDAOs.Where(x => x.ItemCode == Raw_Item_RepDAO.ItemCode).FirstOrDefault();


                if (Dim_Item == null)
                {
                    var Dim_ItemDAO = new Dim_ItemDAO
                    {
                        ItemName = Raw_Item_RepDAO.ItemName,
                        ItemCode = Raw_Item_RepDAO.ItemCode,
                    };
                    Dim_ItemDAOs.Add(Dim_ItemDAO);
                }
                else if (Dim_Item != null)
                {
                    Dim_Item.ItemName = Raw_Item_RepDAO.ItemName;
                }
            }


            await DataContext.BulkMergeAsync(Dim_ItemDAOs);
            return true;
        }
    }
}
