using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MProduct_GroupService
{
    public interface IItem_VAT_GroupService : IServiceScoped
    {
        Task Item_VAT_GroupTransform();
    }
    public class Item_VAT_GroupService : IItem_VAT_GroupService
    {
        private DataContext DataContext;

        public Item_VAT_GroupService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task Item_VAT_GroupTransform()
        {
            await Build_Dim_Item_VAT_Group();
        }

        public async Task<bool> Build_Dim_Item_VAT_Group()
        {
            var Raw_Product_GroupDAOs = await DataContext.Raw_Product_Group.ToListAsync();

            var Dim_Item_VAT_GroupDAOs = await DataContext.Dim_Item_VAT_Group.ToListAsync();

            foreach (var Raw_Product_GroupDAO in Raw_Product_GroupDAOs)
            {
                Dim_Item_VAT_GroupDAO Dim_Item_VAT_Group = Dim_Item_VAT_GroupDAOs.
                    Where(x => x.ItemVATGroupName == Raw_Product_GroupDAO.ItemName).FirstOrDefault();

                if (Dim_Item_VAT_Group == null && Raw_Product_GroupDAO.ItemName != null 
                    && Raw_Product_GroupDAO.ItemName != "0" && Raw_Product_GroupDAO.GTGT_StartDate != null)
                {
                    Dim_Item_VAT_Group = new Dim_Item_VAT_GroupDAO
                    {
                        ItemVATGroupName = Raw_Product_GroupDAO.ItemName,
                    };
                    Dim_Item_VAT_GroupDAOs.Add(Dim_Item_VAT_Group);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Item_VAT_GroupDAOs);

            return true;
        }
    }
}
