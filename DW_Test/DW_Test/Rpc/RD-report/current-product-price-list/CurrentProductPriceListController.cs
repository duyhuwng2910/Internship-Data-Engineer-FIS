using DW_Test.Services.RDService.Consignment_report;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Utilities;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.consignment_report
{
    public class CurrentProductPriceListController : ControllerBase
    {
        private ICurrentProductPriceListService CurrentProductPriceListService;

        public CurrentProductPriceListController(ICurrentProductPriceListService CurrentProductPriceListService)
        {
            this.CurrentProductPriceListService = CurrentProductPriceListService;
        }

        [HttpGet, Route(CurrentProductPriceListRoute.Init)]
        public async Task<ActionResult> Init()
        {
            await CurrentProductPriceListService.Init();

            return Ok();
        }
    }
}
