using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MPlan_RevenueService
{
    public interface ISaleRoom_PlanService : IServiceScoped
    {
        Task SaleRoom_PlanTransform();
    }
    public class SaleRoom_PlanService : ISaleRoom_PlanService
    {
        private DataContext DataContext;

        public SaleRoom_PlanService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task SaleRoom_PlanTransform()
        {
            await Build_Fact_SaleRoom_Month_Plan();
            await Build_Fact_SaleRoom_Quarter_Plan();
            await Build_Fact_SaleRoom_Year_Plan();
        }

        // Tạo bảng Fact_SaleRoom_Month_Plan
        private async Task<bool> Build_Fact_SaleRoom_Month_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue
                .Where(x => !string.IsNullOrEmpty(x.PhongBanHang)).ToListAsync();

            List<Fact_SaleRoom_Month_PlanDAO> Fact_SaleRoom_Month_PlanDAOs = new List<Fact_SaleRoom_Month_PlanDAO>();

            List<Dim_SaleRoomDAO> Dim_SaleRoomDAOs = await DataContext.Dim_SaleRoom.ToListAsync();

            List<Dim_MonthDAO> Dim_MonthDAOs = await DataContext.Dim_Month.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = 0;

                var SaleRoomID = Dim_SaleRoomDAOs.Where(x => x.SaleRoomName == Raw_Plan_RevenueDAO.PhongBanHang).Select(x => x.SaleRoomId).FirstOrDefault();

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
                    if (SaleRoomID != 0)
                    {
                        Fact_SaleRoom_Month_PlanDAO Fact_SaleRoom_Month_Plan = new Fact_SaleRoom_Month_PlanDAO()
                        {
                            SaleRoomId = SaleRoomID,
                            MonthKey = Dim_MonthDAOs.Where(x => x.Year == year && x.Month == i).Select(x => x.MonthKey).FirstOrDefault(),
                            Revenue = revenue,
                        };
                        Fact_SaleRoom_Month_PlanDAOs.Add(Fact_SaleRoom_Month_Plan);
                    }
                }
            }
            await DataContext.Fact_SaleRoom_Month_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_SaleRoom_Month_PlanDAOs);

            return true;
        }

        // Tạo bảng Fact_SaleRoom_Quarter_Plan
        private async Task<bool> Build_Fact_SaleRoom_Quarter_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue
                .Where(x => !string.IsNullOrEmpty(x.PhongBanHang)).ToListAsync();

            List<Fact_SaleRoom_Quarter_PlanDAO> Fact_SaleRoom_Quarter_PlanDAOs = new List<Fact_SaleRoom_Quarter_PlanDAO>();

            List<Dim_SaleRoomDAO> Dim_SaleRoomDAOs = await DataContext.Dim_SaleRoom.ToListAsync();

            List<Dim_QuarterDAO> Dim_QuarterDAOs = await DataContext.Dim_Quarter.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = 0;

                var SaleRoomID = Dim_SaleRoomDAOs.Where(x => x.SaleRoomName == Raw_Plan_RevenueDAO.PhongBanHang).Select(x => x.SaleRoomId).FirstOrDefault();

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
                    if (SaleRoomID != 0)
                    {
                        Fact_SaleRoom_Quarter_PlanDAO Fact_SaleRoom_Quarter_Plan = new Fact_SaleRoom_Quarter_PlanDAO()
                        {
                            SaleRoomId = SaleRoomID,
                            QuarterKey = Dim_QuarterDAOs.Where(x => x.Year == year && x.Quarter == i).Select(x => x.QuarterKey).FirstOrDefault(),
                            Revenue = revenue,
                        };
                        Fact_SaleRoom_Quarter_PlanDAOs.Add(Fact_SaleRoom_Quarter_Plan);
                    }
                }
            }
            await DataContext.Fact_SaleRoom_Quarter_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_SaleRoom_Quarter_PlanDAOs);

            return true;
        }

        // Tạo bảng Fact_SaleRoom_Year_Plan
        private async Task<bool> Build_Fact_SaleRoom_Year_Plan()
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue
                .Where(x => !string.IsNullOrEmpty(x.PhongBanHang)).ToListAsync();

            List<Fact_SaleRoom_Year_PlanDAO> Fact_SaleRoom_Year_PlanDAOs = new List<Fact_SaleRoom_Year_PlanDAO>();

            List<Dim_SaleRoomDAO> Dim_SaleRoomDAOs = await DataContext.Dim_SaleRoom.ToListAsync();

            List<Dim_YearDAO> Dim_YearDAOs = await DataContext.Dim_Year.ToListAsync();

            foreach (var Raw_Plan_RevenueDAO in Raw_Plan_RevenueDAOs)
            {
                var year = Raw_Plan_RevenueDAO.Year;

                decimal revenue = Raw_Plan_RevenueDAO.KHNam;

                var SaleRoomID = Dim_SaleRoomDAOs.Where(x => x.SaleRoomName == Raw_Plan_RevenueDAO.PhongBanHang).Select(x => x.SaleRoomId).FirstOrDefault();

                if (SaleRoomID != 0)
                {
                    Fact_SaleRoom_Year_PlanDAO Fact_SaleRoom_Year_Plan = new Fact_SaleRoom_Year_PlanDAO
                    {
                        SaleRoomId = SaleRoomID,
                        Year = Dim_YearDAOs.Where(x => x.Year == year).Select(x => x.Yearkey).FirstOrDefault(),
                        Revenue = revenue,
                    };
                    Fact_SaleRoom_Year_PlanDAOs.Add(Fact_SaleRoom_Year_Plan);
                }
            }
            await DataContext.Fact_SaleRoom_Year_Plan.DeleteFromQueryAsync();

            await DataContext.BulkMergeAsync(Fact_SaleRoom_Year_PlanDAOs);

            return true;
        }
    }
}
