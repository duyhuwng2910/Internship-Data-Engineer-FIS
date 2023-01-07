using DW_Test.Models;
using DW_Test.Services.ActualSerivce.CustomerService;
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
            await CustomerService.CustomerInit();

            return Ok();
        }

        [HttpGet, Route(CustomerRoute.IncrementalInit)]
        public async Task<ActionResult> IncrementalInit()
        {
            await CustomerService.IncrementalCustomerInit();

            return Ok();
        }

        [HttpGet, Route(CustomerRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await CustomerService.CustomerTransform();

            return Ok();
        }
    }
}
