using DW_Test.Models;
using DW_Test.Rpc.actual_report;
using DW_Test.Services.MActualService;
using DW_Test.Services.MCustomerService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DW_Test.Rpc.customer_report
{
    public class CustomerController : ControllerBase
    {
        private DataContext DataContext;
        private ICustomerService CustomerService;

        public CustomerController(DataContext DataContext, ICustomerService CustomerService)
        {
            this.DataContext = DataContext;
            this.CustomerService = CustomerService;
        }

        [HttpGet, Route(CustomerRoute.Init)]
        public async Task<ActionResult> Init()
        {
            var a = await CustomerService.CustomerInit();
            //await CustomerService.CustomerInit();
            return Ok(a);
        }
    }
}
