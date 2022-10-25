using DW_Test.Models;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MTimeService
{
    public interface IQuarterService : IServiceScoped
    {
        public Task<bool> BulkMerge();
    }
    public class QuarterService : IQuarterService
    {
        private DataContext DataContext;
        
        public QuarterService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> BulkMerge()
        {
            try {
                var Dim_QuarterDAOs = await DataContext.Dim_Quarter.ToListAsync();

                DateTime start = new DateTime(2018, 01, 01, 00, 00, 00);
                DateTime end = new DateTime(2025, 12, 31, 23, 59, 59);

                TimeSpan Interval = new TimeSpan(0, 23, 59, 59, 000);

                for (var date = start.Date; date <= end.Date; date = date.AddMonths(3))
                {
                    var month = date.Month;
                    var quarter = 1;
                    if (month == 1)
                    {
                        quarter = 1;
                    }
                    else if (month == 4)
                    {
                        quarter = 2;
                    }
                    else if (month == 7)
                    {
                        quarter = 3;
                    }
                    else if (month == 10)
                    {
                        quarter = 4;
                    }

                    var year = date.Year;

                    var Dim_QuarterDAO = Dim_QuarterDAOs.Where(x =>
                    x.Quarter == quarter && x.Year == year).FirstOrDefault();

                    if (Dim_QuarterDAO == null)
                    {
                        Dim_QuarterDAO = new Dim_QuarterDAO
                        {
                            QuarterKey = year * 100 + quarter,
                            Quarter = quarter,
                            Year = year,
                            QuarterName = "Quý " + quarter,
                            StartAt = date,
                            EndAt = date.AddMonths(3).AddDays(-1).Add(Interval),
                        };
                        Dim_QuarterDAOs.Add(Dim_QuarterDAO);
                    }
                    else
                    {
                        Dim_QuarterDAO.Quarter = quarter;
                        Dim_QuarterDAO.Year = year;
                        Dim_QuarterDAO.QuarterName = "Quý " + quarter;
                        Dim_QuarterDAO.StartAt = date;
                        Dim_QuarterDAO.EndAt = date.AddMonths(3).AddDays(-1).Add(Interval);
                    }
                }
                await DataContext.BulkMergeAsync(Dim_QuarterDAOs);

                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
