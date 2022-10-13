using DW_Test.Models;
using DW_Test.Services;
using DW_Test.Services.MActualService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace DW_Test.Rpc
{
    public class SetupController : ControllerBase
    {
        private DataContext DataContext;
        private ITestService TestService;
        private IActualService ActualService;
        private string ConnectionString;

        public SetupController(
            DataContext DataContext,
            ITestService TestService,
            IActualService ActualService,
            IConfiguration Configuration
            )
        {
            this.DataContext = DataContext;
            this.TestService = TestService;
            this.ActualService = ActualService;
            ConnectionString = Configuration.GetConnectionString("DataContext");
        }

        [HttpGet, Route("rpc/dw/setup/test")]
        public async Task<ActionResult> Init()
        {
            var a = await TestService.Test();
            //await ActualService.ActualInit();
            return Ok(a);
        }


    }
}
