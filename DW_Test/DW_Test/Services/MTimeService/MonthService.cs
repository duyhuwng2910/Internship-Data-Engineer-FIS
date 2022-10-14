﻿using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MTimeService
{
    public interface IMonthService : IServiceScoped
    {
        Task<bool> BulkMerge();
    }
    public class MonthService : IMonthService
    {
        private DataContext DataContext;
        
        public MonthService(DataContext DataContext) 
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> BulkMerge()
        {
            var Dim_MonthDAOs = await DataContext.Dim_Month.ToListAsync();

            DateTime start = new DateTime(2018, 01, 01);
            DateTime end = new DateTime(2025, 12, 31);
            TimeSpan Interval = new TimeSpan(0, 23, 59, 59, 000);

            for (var date = start.Date; date <= end.Date; date = date.AddMonths(1))
            {
                string _Date = date.ToString("mm/dd/yyyy");
                var month = long.Parse(_Date.Substring(0, 2));
                var year = long.Parse(_Date.Substring(6, 4));

                var Dim_MonthDAO = Dim_MonthDAOs.Where(x =>
                x.Month == month && x.Year == year).FirstOrDefault();

                if (Dim_MonthDAO == null)
                {
                    Dim_MonthDAO = new Dim_MonthDAO
                    {
                        MonthKey = year * 100 + month,
                        Month = month,
                        Year = year,
                        MonthName = "Tháng " + month,
                        StartAt = date,
                        EndAt = date.AddMonths(1).AddDays(-1).Add(Interval),
                    };

                    Dim_MonthDAOs.Add(Dim_MonthDAO);
                }
            }

            await DataContext.BulkMergeAsync(Dim_MonthDAOs);

            return true;
        }
    }
}
