using DW_Test.Models;
using Elastic.Apm.Api;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MTimeService
{
    public interface IYearService : IServiceScoped
    {
        public Task<bool> BulkMerge();
    }
    public class YearService : IYearService 
    {
        private DataContext DataContext;

        public YearService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> BulkMerge()
        {
            var Dim_YearDAOs = await DataContext.Dim_Year.ToListAsync();

            DateTime start = new DateTime(2018, 01, 01, 00, 00, 00);
            DateTime end = new DateTime(2025, 12, 31, 23, 59, 59);

            TimeSpan Interval = new TimeSpan(0, 23, 59, 59, 000);

            for (var date = start.Date; date <= end.Date; date = date.AddYears(1))
            {
                var year = date.Year;

                var Dim_YearDAO = Dim_YearDAOs.Where(x =>
                x.Year == year).FirstOrDefault();

                if (Dim_YearDAO == null)
                {
                    Dim_YearDAO = new Dim_YearDAO
                    {
                        Yearkey = year,
                        Year = year,
                        StartAt = date,
                        EndAt = date.AddYears(1).AddDays(-1).Add(Interval),
                    };
                    Dim_YearDAOs.Add(Dim_YearDAO);
                }
                else
                {
                    Dim_YearDAO.Year = year;
                    Dim_YearDAO.StartAt = date;
                    Dim_YearDAO.EndAt = date.AddYears(1).AddDays(-1).Add(Interval);
                }
            }
            await DataContext.BulkMergeAsync(Dim_YearDAOs);

            return true;
        }
    }
}
