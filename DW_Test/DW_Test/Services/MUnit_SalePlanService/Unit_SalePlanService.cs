using DW_Test.Models;
using Microsoft.Build.Utilities;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.MUnit_SalePlanService
{
    public interface IUnit_SalePlanService : IServiceScoped
    {
        public Task<bool> ImportRevenue();
    }
    public class Unit_SalePlanService : IServiceScoped
    {
        private DataContext DataContext;

        public Unit_SalePlanService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> ImportRevenue()
        {
            return true;
        }
    }
}
