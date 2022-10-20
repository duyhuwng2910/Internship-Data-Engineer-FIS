using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Spreadsheet;
using DW_Test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Task = System.Threading.Tasks.Task;

namespace DW_Test.Services.MUnit_SalePlanService
{
    public interface IUnit_SalePlanService : IServiceScoped
    {
        Task<bool> Import(List<Raw_Plan_RevenueDAO> Raw_PlanRevenueRemoteDAOs);
    }
    public class Unit_SalePlanService : IUnit_SalePlanService
    {
        private DataContext DataContext;

        public Unit_SalePlanService(DataContext DataContext)
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
