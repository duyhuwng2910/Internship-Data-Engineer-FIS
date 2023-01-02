using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Specialized_channel_sale_plan_revenue
{
    public interface IRD_Customer_PlanService : IServiceScoped
    {
        public Task Transform();
    }
    public class RD_Customer_PlanService : IRD_Customer_PlanService
    {
        private DataContext DataContext;

        public RD_Customer_PlanService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task Transform()
        {
            await Build_Fact_RD_Customer_MonthPlan();

            await Build_Fact_RD_Customer_QuarterPlan();

            await Build_Fact_RD_Customer_YearPlan();
        }

        private async Task<bool> Build_Fact_RD_Customer_MonthPlan()
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SalePlan_RevenueDAOs
                = await DataContext.Raw_SpecializedChannel_SalePlan_Revenue.ToListAsync();

            List<Fact_RD_CustomerMonthPlanDAO> Fact_RD_Customer_MonthPlanDAOs = new List<Fact_RD_CustomerMonthPlanDAO>();

            List<Dim_RD_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_RD_Customer.ToListAsync();

            List<Dim_MonthDAO> Dim_MonthDAOs = await DataContext.Dim_Month.ToListAsync();

            foreach (var plan in Raw_SalePlan_RevenueDAOs)
            {
                var year = plan.Nam;

                decimal revenue = 0;

                var ID = Dim_CustomerDAOs.Where(x => x.CustomerCode == plan.MaKH)
                                        .Select(x => x.CustomerId).FirstOrDefault();

                for (int i = 1; i <= 12; i++)
                {
                    switch (i)
                    {
                        case 1:
                            revenue = plan.KHThang1;
                            break;
                        case 2:
                            revenue = plan.KHThang2;
                            break;
                        case 3:
                            revenue = plan.KHThang3;
                            break;
                        case 4:
                            revenue = plan.KHThang4;
                            break;
                        case 5:
                            revenue = plan.KHThang5;
                            break;
                        case 6:
                            revenue = plan.KHThang6;
                            break;
                        case 7:
                            revenue = plan.KHThang7;
                            break;
                        case 8:
                            revenue = plan.KHThang8;
                            break;
                        case 9:
                            revenue = plan.KHThang9;
                            break;
                        case 10:
                            revenue = plan.KHThang10;
                            break;
                        case 11:
                            revenue = plan.KHThang11;
                            break;
                        case 12:
                            revenue = plan.KHThang12;
                            break;
                    }

                    if (ID != 0)
                    {
                        Fact_RD_CustomerMonthPlanDAO Month_PlanDAO = new Fact_RD_CustomerMonthPlanDAO()
                        {
                            CustomerId = ID,
                            MonthKey = Dim_MonthDAOs.Where(x => x.Year == year && x.Month == i)
                                                     .Select(x => x.MonthKey).FirstOrDefault(),
                            RevenuePlan = revenue
                        };

                        Fact_RD_Customer_MonthPlanDAOs.Add(Month_PlanDAO);
                    }
                }
            }

            await DataContext.Fact_RD_CustomerMonthPlan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_RD_Customer_MonthPlanDAOs);

            return true;
        }

        private async Task<bool> Build_Fact_RD_Customer_QuarterPlan()
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SalePlan_RevenueDAOs =
                await DataContext.Raw_SpecializedChannel_SalePlan_Revenue.ToListAsync();

            List<Dim_RD_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_RD_Customer.ToListAsync();

            List<Dim_QuarterDAO> Dim_QuarterDAOs = await DataContext.Dim_Quarter.ToListAsync();

            List<Fact_RD_CustomerQuarterPlanDAO> Fact_RD_Customer_QuarterPlanDAOs = new List<Fact_RD_CustomerQuarterPlanDAO>();

            foreach (var plan in Raw_SalePlan_RevenueDAOs)
            {
                var year = plan.Nam;

                var ID = Dim_CustomerDAOs.Where(x => x.CustomerCode == plan.MaKH)
                                        .Select(x => x.CustomerId).FirstOrDefault();

                decimal revenue = 0;

                for (int i = 1; i <= 4; i++)
                {
                    switch (i)
                    {
                        case 1:
                            revenue = plan.KHQuy1;
                            break;
                        case 2:
                            revenue = plan.KHQuy2;
                            break;
                        case 3:
                            revenue = plan.KHQuy3;
                            break;
                        case 4:
                            revenue = plan.KHQuy4;
                            break;
                    }

                    if (ID != 0)
                    {
                        Fact_RD_Customer_QuarterPlanDAOs.Add(new Fact_RD_CustomerQuarterPlanDAO()
                        {
                            CustomerId = ID,
                            QuarterKey = Dim_QuarterDAOs.Where(x => x.Year == year && x.Quarter == i)
                                                        .Select(x => x.QuarterKey).FirstOrDefault(),
                            RevenuePlan = revenue,
                        });
                    }
                }
            }

            await DataContext.Fact_RD_CustomerQuarterPlan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_RD_Customer_QuarterPlanDAOs);

            return true;
        }

        private async Task<bool> Build_Fact_RD_Customer_YearPlan()
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SalePlan_RevenueDAOs =
                await DataContext.Raw_SpecializedChannel_SalePlan_Revenue.ToListAsync();

            List<Dim_RD_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_RD_Customer.ToListAsync();

            List<Dim_YearDAO> Dim_YearDAOs = await DataContext.Dim_Year.ToListAsync();

            List<Fact_RD_CustomerYearPlanDAO> Fact_RD_Customer_YearPlanDAOs =
                new List<Fact_RD_CustomerYearPlanDAO>();

            foreach (var plan in Raw_SalePlan_RevenueDAOs)
            {
                var year = plan.Nam;

                decimal revenue = plan.KHNam;

                var ID = Dim_CustomerDAOs.Where(x => x.CustomerCode == plan.MaKH)
                                        .Select(x => x.CustomerId).FirstOrDefault();

                if (ID != 0)
                {
                    Fact_RD_Customer_YearPlanDAOs.Add(new Fact_RD_CustomerYearPlanDAO()
                    {
                        CustomerId = ID,
                        Year = Dim_YearDAOs.Where(x => x.Year == year)
                                            .Select(x => x.Yearkey).FirstOrDefault(),
                        RevenuePlan = revenue
                    });
                }
            }

            await DataContext.Fact_RD_CustomerYearPlan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_RD_Customer_YearPlanDAOs);

            return true;
        }
    }
}
