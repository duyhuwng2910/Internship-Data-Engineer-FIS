﻿using DW_Test.Models;
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
            DateTime start = new DateTime(2018, 01, 01, 00, 00, 00);
            DateTime end = new DateTime(2025, 12, 31, 23, 59, 59);

            for (var date = start.Date; date <= end.Date; date = date.AddDays(1))
            {
                var day = date.Day;
                var month = date.Month;
                var year = date.Year;

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
                else
                {
                    Dim_DateDAO.Date = date;
                    Dim_DateDAO.Day = day;
                    Dim_DateDAO.Month = month;
                    Dim_DateDAO.Year = year;
                }
            }

            await DataContext.BulkMergeAsync(Dim_DateDAOs);

            return true;
        }
    }
}
