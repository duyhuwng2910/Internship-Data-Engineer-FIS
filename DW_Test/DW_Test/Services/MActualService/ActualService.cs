using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Raw_B1_5_ActualExportReport_RepDAO = DW_Test.Models.Raw_B1_5_ActualExportReport_RepDAO;

namespace DW_Test.Services.MActualService
{
    public interface IActualService : IServiceScoped
    {
        Task<bool> ActualInit();
    }
    public class ActualService : IActualService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;

        public ActualService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        public async Task<bool> ActualInit()
        {
            var Raw_B1_5_RemoteDAOs = await DWEContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();
            var Raw_B1_5_LocalDAOs = await DataContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();
            await DataContext.BulkDeleteAsync(Raw_B1_5_LocalDAOs);
            var Raw_B1_5_NewDAOs = Raw_B1_5_RemoteDAOs.Select(x => new Raw_B1_5_ActualExportReport_RepDAO()
            {
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
