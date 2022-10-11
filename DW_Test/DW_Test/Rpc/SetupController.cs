using DW_Test.Models;
using DW_Test.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace DW_Test.Rpc
{
    public class SetupController : ControllerBase
    {
        private DataContext DataContext;
        private ITestService TestService;
        private string ConnectionString;

        public SetupController(
            DataContext DataContext,
            ITestService TestService,
            IConfiguration Configuration
            )
        {
            this.DataContext = DataContext;
            this.TestService = TestService;
            ConnectionString = Configuration.GetConnectionString("DataContext");
        }

        [HttpGet, Route("rpc/dw/setup/test")]
        public async Task<ActionResult> Init()
        {
            var a = await TestService.Test();
            return Ok(a);
        }
    }
}
