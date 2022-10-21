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
            var Dim_Date_MappingDAOs = await DataContext.Dim_Date_Mapping.ToListAsync();
            DateTime start = new DateTime(2018, 01, 01, 00, 00, 00);
            DateTime end = new DateTime(2025, 12, 31, 23, 59, 59);

            for (var date = start.Date; date <= end.Date; date = date.AddDays(1))
            {
                var day = date.Day;
                var month = date.Month;
                var year = date.Year;
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

                var Dim_Date_MappingDAO = Dim_Date_MappingDAOs.Where(x =>
                x.Day == day && x.Month == month && x.Year == year).FirstOrDefault();

                if (Dim_Date_MappingDAO == null)
                {
                    Dim_Date_MappingDAO = new Dim_Date_MappingDAO
                    {
                        DateKey = year * 10000 + month * 100 + day,
                        MonthKey = year * 100 + month,
                        QuarterKey = year * 100 + quarter,
                        Date = date,
                        Day = day,
                        Month = month,
                        Quarter = quarter,
                        Year = year,
                    };

                    Dim_Date_MappingDAOs.Add(Dim_Date_MappingDAO);
                }
            }

            await DataContext.BulkMergeAsync(Dim_Date_MappingDAOs);

            return true;
        }
    }
}
