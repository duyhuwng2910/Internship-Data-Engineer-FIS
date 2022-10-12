using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services
{
    public interface ITestService : IServiceScoped
    {
        Task<List<DWEModels.Dim_YearDAO>> Test();
    }
    public class TestService : ITestService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;
        public TestService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }
        public async Task<List<DWEModels.Dim_YearDAO>> Test()
        {
            var Dim_YearDAOs = await DWEContext.Dim_Year.ToListAsync();
            return Dim_YearDAOs;
        }
    }
}
