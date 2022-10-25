using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MPlan_RevenueService
{
    public interface ISale_Branch_PlanService : IServiceScoped
    {
        Task Sale_Branch_PlanTransform();
    }
    public class Sale_Branch_PlanService : ISale_Branch_PlanService
    {
        private DataContext DataContext;

        public Sale_Branch_PlanService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task Sale_Branch_PlanTransform()
        {
            await Build_Fact_Sale_Branch_Month_Plan();
            await Build_Fact_Sale_Branch_Quarter_Plan();
            await Build_Fact_Sale_Branch_Year_Plan();
        }

        // Tạo bảng Fact_Sale_Branch_Month_Plan
        public async Task<bool> Build_Fact_Sale_Branch_Month_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue
                .Where(x => x.VungChiNhanh != null).ToListAsync();

            List<Fact_Sale_Branch_Month_PlanDAO> Fact_Sale_Branch_Month_PlanDAOs = new List<Fact_Sale_Branch_Month_PlanDAO>();

            List<Dim_Sale_BranchDAO> Dim_Sale_BranchDAOs = await DataContext.Dim_Sale_Branch.ToListAsync();

            List<Dim_MonthDAO> Dim_MonthDAOs = await DataContext.Dim_Month.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = 0;

                var Sale_BranchID = Dim_Sale_BranchDAOs.Where(x => x.SaleBranchName == Raw_Plan_RevenueDAO.VungChiNhanh).Select(x => x.SaleBranchId).FirstOrDefault();

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
                    if (Sale_BranchID != 0)
                    {
                        Fact_Sale_Branch_Month_PlanDAO Fact_Sale_Branch_Month_Plan = new Fact_Sale_Branch_Month_PlanDAO()
                        {
                            SaleBranchId = Sale_BranchID,
                            MonthKey = Dim_MonthDAOs.Where(x => x.Year == year && x.Month == i).Select(x => x.MonthKey).FirstOrDefault(),
                            Revenue = revenue,
                        };
                        Fact_Sale_Branch_Month_PlanDAOs.Add(Fact_Sale_Branch_Month_Plan);
                    }
                }
            }
            await DataContext.Fact_Sale_Branch_Month_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_Sale_Branch_Month_PlanDAOs);

            return true;
        }

        // Tạo bảng Fact_Sale_Branch_Quarter_Plan
        public async Task<bool> Build_Fact_Sale_Branch_Quarter_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue.Where(x => x.VungChiNhanh != null).ToListAsync();

            List<Fact_Sale_Branch_Quarter_PlanDAO> Fact_Sale_Branch_Quarter_PlanDAOs = new List<Fact_Sale_Branch_Quarter_PlanDAO>();

            List<Dim_Sale_BranchDAO> Dim_Sale_BranchDAOs = await DataContext.Dim_Sale_Branch.ToListAsync();

            List<Dim_QuarterDAO> Dim_QuarterDAOs = await DataContext.Dim_Quarter.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = 0;

                var Sale_BranchID = Dim_Sale_BranchDAOs.Where(x => x.SaleBranchName == Raw_Plan_RevenueDAO.VungChiNhanh).Select(x => x.SaleBranchId).FirstOrDefault();

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
                    if (Sale_BranchID != 0)
                    {
                        Fact_Sale_Branch_Quarter_PlanDAO Fact_Sale_Branch_Quarter_Plan = new Fact_Sale_Branch_Quarter_PlanDAO()
                        {
                            SaleBranchId = Sale_BranchID,
                            QuarterKey = Dim_QuarterDAOs.Where(x => x.Year == year && x.Quarter == i).Select(x => x.QuarterKey).FirstOrDefault(),
                            Revenue = revenue,
                        };
                        Fact_Sale_Branch_Quarter_PlanDAOs.Add(Fact_Sale_Branch_Quarter_Plan);
                    }
                }
            }
            await DataContext.Fact_Sale_Branch_Quarter_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_Sale_Branch_Quarter_PlanDAOs);

            return true;
        }

        // Tạo bảng Fact_Sale_Branch_Year_Plan
        public async Task<bool> Build_Fact_Sale_Branch_Year_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue.Where(x => x.VungChiNhanh != null).ToListAsync();

            List<Fact_Sale_Branch_Year_PlanDAO> Fact_Sale_Branch_Year_PlanDAOs = new List<Fact_Sale_Branch_Year_PlanDAO>();

            List<Dim_Sale_BranchDAO> Dim_Sale_BranchDAOs = await DataContext.Dim_Sale_Branch.ToListAsync();

            List<Dim_YearDAO> Dim_YearDAOs = await DataContext.Dim_Year.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = Raw_Plan_RevenueDAO.KHNam;

                var Sale_BranchID = Dim_Sale_BranchDAOs.Where(x => x.SaleBranchName == Raw_Plan_RevenueDAO.VungChiNhanh).Select(x => x.SaleBranchId).FirstOrDefault();

                if (Sale_BranchID != 0)
                {
                    Fact_Sale_Branch_Year_PlanDAO Fact_Sale_Branch_Year_Plan = new Fact_Sale_Branch_Year_PlanDAO
                    {
                        SaleBranchId = Sale_BranchID,
                        Year = Dim_YearDAOs.Where(x => x.Year == year).Select(x => x.Year).FirstOrDefault(),
                        Revenue = revenue,
                    };
                    Fact_Sale_Branch_Year_PlanDAOs.Add(Fact_Sale_Branch_Year_Plan);
                }
            }
            await DataContext.Fact_Sale_Branch_Year_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_Sale_Branch_Year_PlanDAOs);

            return true;
        }
    }
}
