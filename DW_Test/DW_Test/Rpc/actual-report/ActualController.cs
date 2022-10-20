using DW_Test.Models;
using DW_Test.Services;
using DW_Test.Services.MActualService;
using Microsoft.AspNetCore.Mvc;
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
            var a = await ActualService.ActualInit();
            //await ActualService.ActualInit();
            return Ok(a);
        }
    }
}
