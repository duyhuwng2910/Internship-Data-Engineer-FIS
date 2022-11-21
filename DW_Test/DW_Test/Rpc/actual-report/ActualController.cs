using DW_Test.Models;
using DW_Test.Services.MActualService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DW_Test.Rpc.actual_report
{
    public class ActualController : ControllerBase
    {
        private DataContext DataContext;

        private IActualService ActualService;

        public ActualController(DataContext DataContext, IActualService ActualService)
        {
            this.DataContext = DataContext;
            this.ActualService = ActualService;
        }

        [HttpGet, Route(ActualRoute.Init)]
        public async Task<ActionResult> Init()
        {
            await ActualService.ActualInit();
            
            return Ok();
        }

        [HttpGet, Route(ActualRoute.IncrementalInit)]
        public async Task<ActionResult> IncrementalInit()
        {
            await ActualService.IncrementalActualInit(DateTime.Today.AddMonths(-3));

            return Ok();
        }

        [HttpGet, Route(ActualRoute.InitByDate)]
        public async Task<ActionResult> InitByDate()
        {
            await ActualService.ActualInit(DateTime.Today.AddMonths(-1));

            return Ok();
        }

        [HttpGet, Route(ActualRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await ActualService.Transform();

            return Ok();
        }

        [HttpGet, Route(ActualRoute.TransformByDate)]
        public async Task<ActionResult> TransformByDate()
        {
            await ActualService.TransformByDate();

            return Ok();
        }
    }
}
