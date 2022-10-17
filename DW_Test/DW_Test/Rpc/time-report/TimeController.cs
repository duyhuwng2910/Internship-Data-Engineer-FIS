﻿using DW_Date.Services.MTimeService;
using DW_Test.Models;
using DW_Test.Services.MItemService;
using DW_Test.Services.MTimeService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DW_Test.Rpc.time_report
{
    public class TimeController : ControllerBase
    {
        private DataContext DataContext;
        private IDateService DateService;
        private IMonthService MonthService;
        private IQuarterService QuarterService;
        private IYearService YearService;

        public TimeController(DataContext DataContext, IDateService DateService, IMonthService MonthService, IQuarterService QuarterService, IYearService YearService)
        {
            this.DataContext = DataContext;
            this.DateService = DateService;
            this.MonthService = MonthService;
            this.QuarterService = QuarterService;
            this.YearService = YearService;
        }

        [HttpGet, Route(TimeRoute.Init)]
        public async Task<ActionResult> Init()
        {
            await DateService.BulkMerge();
            await MonthService.BulkMerge(); 
            await QuarterService.BulkMerge();
            await YearService.BulkMerge();
            return Ok();
        }
    }
}
