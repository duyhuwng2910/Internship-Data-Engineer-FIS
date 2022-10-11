using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Z.BulkOperations;
using Raw_B1_5_ActualExportReport_Rep = DW_Test.DWEModels.Raw_B1_5_ActualExportReport_Rep;

namespace DW_Test.Services.MActualService
{
    public interface IActualService : IServiceScoped
    {
        Task<bool> ActualInit();
    }
    public class ActualService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;

        public ActualService(DataContext dataContext, DWEContext dWEContext)
        {
            DataContext = dataContext;
            DWEContext = dWEContext;
        }

        public async Task<bool> ActualInit()
        {
            var Raw_B1_5_RemoteDAOs = await DWEContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();
            var Raw_B1_5_NewDAOs = Raw_B1_5_RemoteDAOs.Select(x => new Raw_B1_5_ActualExportReport_Rep()
            {
                Id = x.Id,
                Ma_HH = x.Ma_HH,
                Ten_HH = x.Ten_HH,
                Donvitinh = x.Donvitinh,
                XN = x.XN,
                Loai_NX = x.Loai_NX,
                SoHD = x.SoHD,
                Seri = x.Seri,
                KhoaHD = x.KhoaHD,
                Ngay_xuat = x.Ngay_xuat,
                thoidiem = x.thoidiem,
                Soluong = x.Soluong,
                DonGia = x.DonGia,
                ThanhTien = x.ThanhTien,
                coso = x.coso,
                Ma_KH = x.Ma_KH,
                Khach_hang = x.Khach_hang,
                Huy = x.Huy,
                DocEntry = x.DocEntry,
                TT = x.TT,
            }).ToList();

            await DataContext.BulkMergeAsync(Raw_B1_5_NewDAOs);

            return true;
        }
    }
}
