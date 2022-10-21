using DW_Test.Models;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MProduct_GroupService
{
    public interface IProduct_GroupService : IServiceScoped
    {
        Task<bool> Import(List<Raw_Product_GroupDAO> Raw_Product_GroupRemoteDAOs);
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
    }
}
