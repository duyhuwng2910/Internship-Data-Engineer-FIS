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
        Task Transform();
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
        public async Task Transform()
        {
            await Build_Dim_Item_Type_Group();
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
    }
}
