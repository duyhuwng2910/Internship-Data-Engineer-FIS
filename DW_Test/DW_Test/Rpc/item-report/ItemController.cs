using DW_Test.Models;
using DW_Test.Services.MActualService;
using DW_Test.Services.MItemService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Utilities;
using System.Threading.Tasks;

namespace DW_Test.Rpc.item_report
{
    public class ItemController : ControllerBase
    {
        private DataContext DataContext;
        private IItemService ItemService;

        public ItemController(DataContext DataContext, IItemService ItemService)
        {
            this.DataContext = DataContext;
            this.ItemService = ItemService;
        }

        [HttpGet, Route(ItemRoute.Init)]
        public async Task<ActionResult> Init()
        {
            var a = await ItemService.ItemInit();

            return Ok(a);
        }

        [HttpGet, Route(ItemRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await ItemService.ItemTransform();

            return Ok();
        }
    }
}
