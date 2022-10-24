using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MProduct_GroupService
{
    public interface IItem_New_Item_GroupService : IServiceScoped
    {
        Task Item_New_Item_GroupTransform();
    }
    public class Item_New_Item_GroupService : IItem_New_Item_GroupService
    {
        private DataContext DataContext;

        public Item_New_Item_GroupService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task Item_New_Item_GroupTransform()
        {
            await Build_Dim_Item_New_Item_Group();
        }

        public async Task<bool> Build_Dim_Item_New_Item_Group()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            var Dim_Item_New_Item_GroupDAOs = await DataContext.Dim_Item_New_Item_Group.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_Item_New_Item_GroupDAO Dim_Item_New_Item_Group = Dim_Item_New_Item_GroupDAOs.
                    Where(x => x.ItemNewItemGroupName == Raw_Product_GroupDAO.ItemName).FirstOrDefault();

                if (Dim_Item_New_Item_Group == null && Raw_Product_GroupDAO.ItemName != null
                    && Raw_Product_GroupDAO.ItemName != "0" && Raw_Product_GroupDAO.M_StartDate != null)
                {
                    Dim_Item_New_Item_Group = new Dim_Item_New_Item_GroupDAO
                    {
                        ItemNewItemGroupName = Raw_Product_GroupDAO.ItemName,
                    };
                    Dim_Item_New_Item_GroupDAOs.Add(Dim_Item_New_Item_Group);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Item_New_Item_GroupDAOs);

            return true;
        }
    }
}
