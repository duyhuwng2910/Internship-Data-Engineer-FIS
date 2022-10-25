using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Task = System.Threading.Tasks.Task;

namespace DW_Test.Services.MPlan_RevenueService
{
    public interface ICounty_PlanService : IServiceScoped
    {
        Task County_PlanTransform();
    }
    public class County_PlanService : ICounty_PlanService
    {
        private DataContext DataContext;

        public County_PlanService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }
        public async Task County_PlanTransform()
        {
            await Build_Fact_County_Month_Plan();
            await Build_Fact_County_Quarter_Plan();
            await Build_Fact_County_Year_Plan();
        }

        // Tạo bảng Fact_County_Month_Plan
        private async Task<bool> Build_Fact_County_Month_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue
                .Where(x => !string.IsNullOrEmpty(x.Tinh)).ToListAsync();

            List<Fact_County_Month_PlanDAO > Fact_County_Month_PlanDAOs = new List<Fact_County_Month_PlanDAO>();

            List<Dim_CountyDAO> Dim_CountyDAOs = await DataContext.Dim_County.ToListAsync();

            List<Dim_MonthDAO> Dim_MonthDAOs = await DataContext.Dim_Month.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = 0;

                var CountyID = Dim_CountyDAOs.Where(x => x.CountyName == Raw_Plan_RevenueDAO.Tinh).Select(x => x.CountyId).FirstOrDefault();

                for (int i = 1; i <= 12; i++)
                {
                    switch (i)
                    {
                        case 1:
                            revenue = Raw_Plan_RevenueDAO.KHThang1;
                            break;
                        case 2:
                            revenue = Raw_Plan_RevenueDAO.KHThang2;
                            break;
                        case 3:
                            revenue = Raw_Plan_RevenueDAO.KHThang3;
                            break;
                        case 4:
                            revenue = Raw_Plan_RevenueDAO.KHThang4;
                            break;
                        case 5:
                            revenue = Raw_Plan_RevenueDAO.KHThang5;
                            break;
                        case 6:
                            revenue = Raw_Plan_RevenueDAO.KHThang6;
                            break;
                        case 7:
                            revenue = Raw_Plan_RevenueDAO.KHThang7;
                            break;
                        case 8:
                            revenue = Raw_Plan_RevenueDAO.KHThang8;
                            break;
                        case 9:
                            revenue = Raw_Plan_RevenueDAO.KHThang9;
                            break;
                        case 10:
                            revenue = Raw_Plan_RevenueDAO.KHThang10;
                            break;
                        case 11:
                            revenue = Raw_Plan_RevenueDAO.KHThang11;
                            break;
                        case 12:
                            revenue = Raw_Plan_RevenueDAO.KHThang12;
                            break;
                    }
                    if (CountyID != 0)
                    {
                        Fact_County_Month_PlanDAO Fact_County_Month_Plan = new Fact_County_Month_PlanDAO()
                        {
                            CountyId = CountyID,
                            MonthKey = Dim_MonthDAOs.Where(x => x.Year == year && x.Month == i).Select(x => x.MonthKey).FirstOrDefault(),
                            Revenue = revenue,
                        };
                        Fact_County_Month_PlanDAOs.Add(Fact_County_Month_Plan);
                    }
                }
            }
            await DataContext.Fact_County_Month_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_County_Month_PlanDAOs);

            return true;
        }

        // Tạo bảng Fact_County_Quarter_Plan
        private async Task<bool> Build_Fact_County_Quarter_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue
                .Where(x => !string.IsNullOrEmpty(x.Tinh)).ToListAsync();

            List<Fact_County_Quarter_PlanDAO> Fact_County_Quarter_PlanDAOs = new List<Fact_County_Quarter_PlanDAO>();

            List<Dim_CountyDAO> Dim_CountyDAOs = await DataContext.Dim_County.ToListAsync();

            List<Dim_QuarterDAO> Dim_QuarterDAOs = await DataContext.Dim_Quarter.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = 0;

                var CountyID = Dim_CountyDAOs.Where(x => x.CountyName == Raw_Plan_RevenueDAO.Tinh).Select(x => x.CountyId).FirstOrDefault();

                for (int i = 1; i <= 4; i++)
                {
                    switch (i)
                    {
                        case 1:
                            revenue = Raw_Plan_RevenueDAO.KHQuy1;
                            break;
                        case 2:
                            revenue = Raw_Plan_RevenueDAO.KHQuy2;
                            break;
                        case 3:
                            revenue = Raw_Plan_RevenueDAO.KHQuy3;
                            break;
                        case 4:
                            revenue = Raw_Plan_RevenueDAO.KHQuy4;
                            break;
                    }
                    if (CountyID != 0)
                    {
                        Fact_County_Quarter_PlanDAO Fact_County_Quarter_Plan = new Fact_County_Quarter_PlanDAO()
                        {
                            CountyId = CountyID,
                            QuarterKey = Dim_QuarterDAOs.Where(x => x.Year == year && x.Quarter == i).Select(x => x.QuarterKey).FirstOrDefault(),
                            Revenue = revenue,
                        };
                        Fact_County_Quarter_PlanDAOs.Add(Fact_County_Quarter_Plan);
                    }
                }
            }
            await DataContext.Fact_County_Quarter_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_County_Quarter_PlanDAOs);

            return true;
        }

        // Tạo bảng Fact_County_Year_Plan
        private async Task<bool> Build_Fact_County_Year_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue
                .Where(x => !string.IsNullOrEmpty(x.Tinh)).ToListAsync();

            List<Fact_County_Year_PlanDAO> Fact_County_Year_PlanDAOs = new List<Fact_County_Year_PlanDAO>();

            List<Dim_CountyDAO> Dim_CountyDAOs = await DataContext.Dim_County.ToListAsync();

            List<Dim_YearDAO> Dim_YearDAOs = await DataContext.Dim_Year.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = Raw_Plan_RevenueDAO.KHNam;

                var CountyID = Dim_CountyDAOs.Where(x => x.CountyName == Raw_Plan_RevenueDAO.Tinh).Select(x => x.CountyId).FirstOrDefault();

                if (CountyID != 0)
                {
                    Fact_County_Year_PlanDAO Fact_County_Year_Plan = new Fact_County_Year_PlanDAO
                    {
                        CountyId = CountyID,
                        Year = Dim_YearDAOs.Where(x => x.Year == year).Select(x => x.Yearkey).FirstOrDefault(),
                        Revenue = revenue,
                    };
                    Fact_County_Year_PlanDAOs.Add(Fact_County_Year_Plan);
                }
            }
            await DataContext.Fact_County_Year_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_County_Year_PlanDAOs);

            return true;
        }
    }
}
