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
        // ngữ cảnh data nằm trong local, tức là data của mình
        private DataContext DataContext;
        
        // ngữ cảnh data của khách hàng (remote)
        private DWEContext DWEContext;

        public ActualService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        /*
         * Hàm này dùng để init các data remote, trước hết là
         * delete các data trong local, sau đó kéo data từ remote 
         * về local rồi merge và đẩy lên data trong local
         */
        public async Task<bool> ActualInit()
        {
            // Biến var dạng List<Raw_B1_5_ActualExportReport_RepDAO> => local thì đi với DataContext
            var Raw_B1_5_ActualServiceLocalDAOs = await DataContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();

            // Biến var dạng List<DWEModels.Raw_B1_5_ActualExportReport_RepDAO> => remote đi với DWEContext
            var Raw_B1_5_ActualServiceRemoteDAOs = await DWEContext.Raw_B1_5_ActualExportReport_Rep.ToListAsync();
            
            // Hàm này dùng để xoá các data đang có ở trong local
            await DataContext.BulkDeleteAsync(Raw_B1_5_ActualServiceLocalDAOs);

            var Raw_B1_5_NewDAOs = Raw_B1_5_ActualServiceRemoteDAOs.Select(x => new Raw_B1_5_ActualExportReport_RepDAO()
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

            // Sau khi gắn/kéo data từ phía khách hàng (remote) thì sẽ tiến hành merge
            await DataContext.BulkMergeAsync(Raw_B1_5_NewDAOs);

            return true;
        }
    }
}
