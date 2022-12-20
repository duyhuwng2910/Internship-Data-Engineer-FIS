using DW_Test.Models;
using DW_Test.Services.RDService.ActualAndBookInventoryService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.actual_and_book_inventory
{
    public class ActualAndBookInventoryController : ControllerBase
    {
        private IActualAndBookInventoryService ActualAndBookInventoryService;

        public ActualAndBookInventoryController(DataContext DataContext, IActualAndBookInventoryService ActualAndBookInventoryService)
        {
            this.ActualAndBookInventoryService = ActualAndBookInventoryService;
        }

        [HttpGet, Route(ActualAndBookInventoryRoute.Init)]
        public async Task<ActionResult> Init()
        {
            await ActualAndBookInventoryService.Init();

            return Ok();
        }
    }
}
