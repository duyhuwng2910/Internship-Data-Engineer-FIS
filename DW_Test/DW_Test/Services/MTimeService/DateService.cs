using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Date.Services.MTimeService
{
    public interface IDateService : IServiceScoped
    {
        Task<bool> BulkMerge();
    }
    public class DateService : IDateService
    {
        private DataContext DataContext;
        public DateService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> BulkMerge()
        {
            var Dim_DateDAOs = await DataContext.Dim_Date.ToListAsync();
            DateTime start = new DateTime(2018, 01, 01);
            DateTime end = new DateTime(2025, 12, 31);

            for (var date = start.Date; date <= end.Date; date = date.AddDays(1))
            {
                string _Date = date.ToString("mm/dd/yyyy");
                var day = long.Parse(_Date.Substring(3, 2));
                var month = long.Parse(_Date.Substring(0, 2));
                var year = long.Parse(_Date.Substring(6, 4));

                var Dim_DateDAO = Dim_DateDAOs.Where(x =>
                x.Day == day && x.Month == month && x.Year == year).FirstOrDefault();

                if (Dim_DateDAO == null)
                {
                    Dim_DateDAO = new Dim_DateDAO
                    {
                        DateKey = year * 10000 + month * 100 + day,
                        Date = date,
                        Day = day,
                        Month = month,
                        Year = year,
                    };

                    Dim_DateDAOs.Add(Dim_DateDAO);
                }
            }

            await DataContext.BulkMergeAsync(Dim_DateDAOs);

            return true;
        }
    }
}
