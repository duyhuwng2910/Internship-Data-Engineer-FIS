using DW_Test.Models;
using DW_Test.Services.ActualService.ActualService;
using System;
using Task = System.Threading.Tasks.Task;

namespace DW_Test.Services.MHangfireService
{
    public interface IHangfireService
    {
        Task InitData();
    }
    public class HangfireService : IHangfireService
    {
        private DataContext DataContext;

        private IActualService ActualService;

        public HangfireService(DataContext DataContext, IActualService ActualService)
        {
            this.DataContext = DataContext;
            this.ActualService = ActualService;
        }

        public async Task InitData()
        {
            await ActualService.IncrementalActualInit(DateTime.Today.AddMonths(-3));
        }
    }
}
