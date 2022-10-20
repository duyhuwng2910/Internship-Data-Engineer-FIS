using Microsoft.AspNetCore.Mvc;

namespace DW_Test.Rpc.product_group
{
    public class ProductGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
