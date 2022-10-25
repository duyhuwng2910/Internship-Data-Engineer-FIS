using DocumentFormat.OpenXml.Bibliography;
using DW_Test.Models;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MTimeService
{
    public interface IDateMappingService : IServiceScoped
    {
        public Task<bool> BulkMerge();
    }
    public class DateMappingService : IDateMappingService
    {
        private DataContext DataContext;

        public DateMappingService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> BulkMerge()
        {
            var Dim_DateMappingDAOs = await DataContext.Dim_DateMapping.ToListAsync();

            DateTime start = new DateTime(2018, 01, 01, 00, 00, 00);
            DateTime end = new DateTime(2025, 12, 31, 23, 59, 59);

            for (var date = start.Date; date <= end.Date; date = date.AddDays(1))
            {
                var day = date.Day;
                var month = date.Month;
                var year = date.Year;
                var quarter = 1;

                if (month == 1 || month == 2 || month == 3)
                {
                    quarter = 1;
                }
                else if (month == 4 || month == 5 || month == 6)
                {
                    quarter = 2;
                }
                else if (month == 7 || month == 8 || month == 9)
                {
                    quarter = 3;
                }
                else
                {
                    quarter = 4;
                }

                var Dim_DateMappingDAO = Dim_DateMappingDAOs.Where(x =>
                x.Day == day && x.Month == month && x.Year == year).FirstOrDefault();

                if (Dim_DateMappingDAO == null)
                {
                    Dim_DateMappingDAO = new Dim_DateMappingDAO
                    {
                        DateKey = year * 10000 + month * 100 + day,
                        MonthKey = year * 100 + month,
                        QuarterKey = year * 100 + quarter,
                        YearKey = year,
                        Date = date,
                        Day = day,
                        Month = month,
                        Quarter = quarter,
                        Year = year,
                    };
                    Dim_DateMappingDAOs.Add(Dim_DateMappingDAO);
                }
                else
                {
                    Dim_DateMappingDAO.MonthKey = year * 100 + month;
                    Dim_DateMappingDAO.QuarterKey = year * 100 + quarter;
                    Dim_DateMappingDAO.YearKey = year;
                    Dim_DateMappingDAO.Date = date;
                    Dim_DateMappingDAO.Day = day;
                    Dim_DateMappingDAO.Month = month;
                    Dim_DateMappingDAO.Quarter = quarter;
                    Dim_DateMappingDAO.Year = year;
                }
            }

            await DataContext.BulkMergeAsync(Dim_DateMappingDAOs);

            return true;
        }
    }
}
