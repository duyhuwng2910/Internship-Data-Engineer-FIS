using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Raw_Item_RepDAO = DW_Test.Models.Raw_Item_RepDAO;

namespace DW_Test.Services.MItemService
{
    public interface IItemService : IServiceScoped
    {
        Task<bool> ItemInit();
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
    }
}
