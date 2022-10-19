using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Spreadsheet;
using DW_Test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Task = System.Threading.Tasks.Task;

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

        public async Task<List<Raw_Plan_RevenueDAO>> Import(List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueRemoteDAOs)
        {
            // Biến var dạng List<> chứa các dòng của bảng Raw_Plan_Revenue
            var Raw_Plan_RevenueLocalDAOs = await DataContext.Raw_Plan_Revenue.ToListAsync();

            // Xoá các data đang có ở trong bảng Raw_Plan_Revenue
            DataContext.BulkDeleteAsync(Raw_Plan_RevenueLocalDAOs);

            var Raw_Plan_RevenueNewDAOs = Raw_Plan_RevenueRemoteDAOs.Select(x => new Raw_Plan_RevenueDAO
            {
                Year = x.Year,
                TongCongTy = x.TongCongTy,
                PhongBanHang = x.PhongBanHang,
                Kenh = x.Kenh,
                VungChiNhanh = x.VungChiNhanh,
                Tinh = x.Tinh,
                MaKhachHang = x.MaKhachHang,
                KhachHang = x.KhachHang,
                KHNam = x.KHNam,
                KHQuy1 = x.KHQuy1,
                KHQuy2 = x.KHQuy2,
                KHQuy3 = x.KHQuy3,
                KHQuy4 = x.KHQuy4,
                KHThang1 = x.KHThang1,
                KHThang2 = x.KHThang2,
                KHThang3 = x.KHThang3,
                KHThang4 = x.KHThang4,
                KHThang5 = x.KHThang5,
                KHThang6 = x.KHThang6,
                KHThang7 = x.KHThang7,
                KHThang8 = x.KHThang8,
                KHThang9 = x.KHThang9,
                KHThang10 = x.KHThang10,
                KHThang11 = x.KHThang11,
                KHThang12 = x.KHThang12,
            }).ToList();

            DataContext.BulkMerge(Raw_Plan_RevenueLocalDAOs);

            return Raw_Plan_RevenueLocalDAOs;
        }
    }
}
