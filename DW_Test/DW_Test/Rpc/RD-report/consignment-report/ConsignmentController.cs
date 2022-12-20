using DW_Test.Services.RDService.Consignment_report;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.consignment_report
{
    public class ConsignmentController : ControllerBase
    {
        private IConsignmentService ConsignmentService;

        public ConsignmentController(IConsignmentService ConsignmentService)
        {
            this.ConsignmentService = ConsignmentService;
        }

        [HttpGet, Route(ConsignmentRoute.Init)]
        public async Task<ActionResult> Init()
        {
            await ConsignmentService.Init();

            return Ok();
        }
    }
}
