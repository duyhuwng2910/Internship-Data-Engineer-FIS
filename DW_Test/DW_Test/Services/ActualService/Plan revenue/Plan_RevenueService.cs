using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.ActualService.Plan_RevenueService
{
    public interface IPlan_RevenueService : IServiceScoped
    {
        Task<bool> Import(List<Raw_Plan_RevenueDAO> Raw_PlanRevenueRemoteDAOs);
    }
    public class Plan_RevenueService : IPlan_RevenueService
    {
        private DataContext DataContext;

        public Plan_RevenueService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Import(List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueRemoteDAOs)
        {
            // Biến var dạng List<> chứa các dòng của bảng Raw_Plan_Revenue
            var Raw_Plan_RevenueLocalDAOs = await DataContext.Raw_Plan_Revenue.ToListAsync();

            // Xoá các data đang có ở trong bảng Raw_Plan_Revenue
            await DataContext.BulkDeleteAsync(Raw_Plan_RevenueLocalDAOs);

            DataContext.BulkMerge(Raw_Plan_RevenueRemoteDAOs);

            return true;
        }
    }
}
