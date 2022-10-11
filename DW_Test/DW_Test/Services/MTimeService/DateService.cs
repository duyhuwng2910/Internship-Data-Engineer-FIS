using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Dim_Date = DW_Test.Models.Dim_Date;

namespace DW_Date.Services.MTimeService
{
    public interface IDateService : IServiceScoped
    {
        Task<bool> DateInit();
    }
    public class DateService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;
        public DateService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }
        public async Task<bool> DateInit()
        {
            var Dim_DateRemoteDAOs = await DWEContext.Dim_Date.ToListAsync();
            var Dim_DateNewDAOs = Dim_DateRemoteDAOs
                .Select(x => new Dim_Date()
                {
                    DateKey = x.DateKey,
                    Date = x.Date,
                    Day = x.Day,
                    Month = x.Month,
                    Year = x.Year,
                }).ToList();
            await DataContext.BulkMergeAsync(Dim_DateNewDAOs);
            return true;
        }
    }
}
