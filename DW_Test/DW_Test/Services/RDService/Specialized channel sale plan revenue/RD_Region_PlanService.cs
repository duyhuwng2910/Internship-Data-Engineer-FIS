using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Specialized_channel_sale_plan_revenue
{
    public interface IRD_Region_PlanService : IServiceScoped
    {
        public Task Transform();
    }
    public class RD_Region_PlanService : IRD_Region_PlanService
    {
        private DataContext DataContext;

        public RD_Region_PlanService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task Transform()
        {
            await Build_Fact_RD_Region_MonthPlan();

            await Build_Fact_RD_Region_QuarterPlan();

            await Build_Fact_RD_Region_YearPlan();
        }

        private async Task<bool> Build_Fact_RD_Region_MonthPlan()
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SalePlan_RevenueDAOs
                = await DataContext.Raw_SpecializedChannel_SalePlan_Revenue.ToListAsync();

            List<Fact_RD_RegionMonthPlanDAO> Fact_RD_Region_MonthPlanDAOs = new List<Fact_RD_RegionMonthPlanDAO>();

            List<Dim_RegionDAO> Dim_RegionDAOs = await DataContext.Dim_Region.ToListAsync();

            List<Dim_MonthDAO> Dim_MonthDAOs = await DataContext.Dim_Month.ToListAsync();

            foreach (var plan in Raw_SalePlan_RevenueDAOs)
            {
                var year = plan.Nam;

                decimal revenue = 0;

                var ID = Dim_RegionDAOs.Where(x => x.RegionName == plan.TenMien)
                                        .Select(x => x.RegionId).FirstOrDefault();

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
                        Fact_RD_RegionMonthPlanDAO Month_PlanDAO = new Fact_RD_RegionMonthPlanDAO()
                        {
                            RegionId = ID,
                            MonthKey = Dim_MonthDAOs.Where(x => x.Year == year && x.Month == i)
                                                     .Select(x => x.MonthKey).FirstOrDefault(),
                            RevenuePlan = revenue
                        };

                        Fact_RD_Region_MonthPlanDAOs.Add(Month_PlanDAO);
                    }
                }
            }

            await DataContext.Fact_RD_RegionMonthPlan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_RD_Region_MonthPlanDAOs);

            return true;
        }

        private async Task<bool> Build_Fact_RD_Region_QuarterPlan()
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SalePlan_RevenueDAOs =
                await DataContext.Raw_SpecializedChannel_SalePlan_Revenue.ToListAsync();

            List<Dim_RegionDAO> Dim_RegionDAOs = await DataContext.Dim_Region.ToListAsync();

            List<Dim_QuarterDAO> Dim_QuarterDAOs = await DataContext.Dim_Quarter.ToListAsync();

            List<Fact_RD_RegionQuarterPlanDAO> Fact_RD_Region_QuarterPlanDAOs = new List<Fact_RD_RegionQuarterPlanDAO>();
          
            foreach(var plan in Raw_SalePlan_RevenueDAOs)
            {
                var year = plan.Nam;

                var ID = Dim_RegionDAOs.Where(x => x.RegionName == plan.TenMien)
                                        .Select(x => x.RegionId).FirstOrDefault();

                decimal revenue = 0;

                for (int i = 1; i <= 4; i++)
                {
                    switch(i)
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
                        Fact_RD_Region_QuarterPlanDAOs.Add(new Fact_RD_RegionQuarterPlanDAO()
                        {
                            RegionId = ID,
                            QuarterKey = Dim_QuarterDAOs.Where(x => x.Year == year && x.Quarter == i)
                                                        .Select(x => x.QuarterKey).FirstOrDefault(),
                            RevenuePlan = revenue,
                        });
                    }
                }
            }

            await DataContext.Fact_RD_CustomerQuarterPlan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_RD_Region_QuarterPlanDAOs);

            return true;
        }

        private async Task<bool> Build_Fact_RD_Region_YearPlan()
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SalePlan_RevenueDAOs =
                await DataContext.Raw_SpecializedChannel_SalePlan_Revenue.ToListAsync();

            List<Dim_RegionDAO> Dim_RegionDAOs = await DataContext.Dim_Region.ToListAsync();

            List<Dim_YearDAO> Dim_YearDAOs = await DataContext.Dim_Year.ToListAsync();

            List<Fact_RD_RegionYearPlanDAO> Fact_RD_Region_YearPlanDAOs = new List<Fact_RD_RegionYearPlanDAO>();

            foreach (var plan in Raw_SalePlan_RevenueDAOs)
            {
                var year = plan.Nam;

                decimal revenue = plan.KHNam;

                var ID = Dim_RegionDAOs.Where(x => x.RegionName == plan.TenMien)
                                        .Select(x => x.RegionId).FirstOrDefault();

                if (ID != 0)
                {
                    Fact_RD_Region_YearPlanDAOs.Add(new Fact_RD_RegionYearPlanDAO()
                    {
                        RegionId = ID,
                        Year = Dim_YearDAOs.Where(x => x.Year == year)
                                            .Select(x => x.Yearkey).FirstOrDefault(),
                        RevenuePlan = revenue
                    });
                }
            }

            await DataContext.Fact_RD_RegionYearPlan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_RD_Region_YearPlanDAOs);
 
            return true;
        }
    }
}
