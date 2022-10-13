using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Raw_Customer_RepDAO = DW_Test.Models.Raw_Customer_RepDAO;

namespace DW_Test.Services.MCustomerService
{
    public interface ICustomerService : IServiceScoped
    {
        Task<bool> CustomerInit();
    }

    public class CustomerService : ICustomerService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;

        public CustomerService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        public async Task<bool> CustomerInit()
        {
            List<DWEModels.Raw_Customer_RepDAO> Raw_Customer_RepRemoteDAOs = await DWEContext.Raw_Customer_Rep.ToListAsync();
            List<Raw_Customer_RepDAO> Raw_Customer_RepLocalDAOs = await DataContext.Raw_Customer_Rep.ToListAsync();

            // Hàm dùng để xoá dữ liệu nếu có trên bảng
            await DataContext.BulkDeleteAsync(Raw_Customer_RepLocalDAOs);

            List<Raw_Customer_RepDAO> Raw_Customer_NewDAOs = Raw_Customer_RepRemoteDAOs.Select(x => new Raw_Customer_RepDAO()
            {
                CustomerCode = x.CustomerCode,
                CustomerName = x.CustomerName,
                CountryCode = x.CountryCode,
                CountryName = x.CountryName,
                SaleBranch = x.SaleBranch,
                SaleChannel = x.SaleChannel,
                SaleRoom = x.SaleRoom,
                CountyCode = x.CountyCode,
                CountyName = x.CountryName,
            }).ToList();

            await DataContext.BulkMergeAsync(Raw_Customer_NewDAOs);

            return true;
        }
    }
}
