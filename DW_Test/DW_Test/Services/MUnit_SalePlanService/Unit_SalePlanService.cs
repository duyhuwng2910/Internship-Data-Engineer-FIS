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

        public async Task<List<Raw_Plan_RevenueDAO>> Import(IFormFile file)
        {
            // Biến var dạng List<> chứa các dòng của bảng Raw_Plan_Revenue
            var Raw_Plan_RevenueDAOs = await DataContext.Raw_Plan_Revenue.ToListAsync();

            // Xoá các data đang có ở trong bảng Raw_Plan_Revenue
            DataContext.BulkDeleteAsync(Raw_Plan_RevenueDAOs);

            MemoryStream memoryStream = new MemoryStream();

            await file.CopyToAsync(memoryStream);

            using (var package = new ExcelPackage(memoryStream))
            {
                var workbook = package.Workbook;

                foreach(var worksheet in workbook.Worksheets)
                {
                    long Nam = long.TryParse(worksheet.Name, out long nam) ? nam : 0;

                    var row = worksheet.Dimension.Rows;

                    int StartColumn = 1;
                    int StartRow = 1;

                    List<string> columns = new List<string>();

                    // Vòng lặp cho từng cột để định nghĩa tên cột
                    for (int column = StartColumn; column <= worksheet.Dimension.End.Column; column++)
                    {
                        string columnName = worksheet.Cells[StartRow, column].Value?.ToString() ?? "";
                        columns.Add(columnName);
                    }

                    int Company = StartColumn + columns.IndexOf("Tổng công ty");
                    int SaleRoom = StartColumn + columns.IndexOf("Phòng bán hàng");
                    int SaleChannel = StartColumn + columns.IndexOf("Kênh");
                    int SaleBranch = StartColumn + columns.IndexOf("Vùng/ Chi nhánh");
                    int SaleProvince = StartColumn + columns.IndexOf("Tỉnh");
                    int CustomerCode = StartColumn + columns.IndexOf("Mã Khách hàng");
                    int Customer = StartColumn + columns.IndexOf("Khách hàng");
                    int KHNam = StartColumn + columns.IndexOf("KH Năm");
                    int KHQ1 = StartColumn + columns.IndexOf("KH Quý 1");
                    int KHQ2 = StartColumn + columns.IndexOf("KH Quý 2");
                    int KHQ3 = StartColumn + columns.IndexOf("KH Quý 3");
                    int KHQ4 = StartColumn + columns.IndexOf("KH Quý 4");
                    int T01 = StartColumn + columns.IndexOf("KH Tháng 1");
                    int T02 = StartColumn + columns.IndexOf("KH Tháng 2");
                    int T03 = StartColumn + columns.IndexOf("KH Tháng 3");
                    int T04 = StartColumn + columns.IndexOf("KH Tháng 4");
                    int T05 = StartColumn + columns.IndexOf("KH Tháng 5");
                    int T06 = StartColumn + columns.IndexOf("KH Tháng 6");
                    int T07 = StartColumn + columns.IndexOf("KH Tháng 7");
                    int T08 = StartColumn + columns.IndexOf("KH Tháng 8");
                    int T09 = StartColumn + columns.IndexOf("KH Tháng 9");
                    int T10 = StartColumn + columns.IndexOf("KH Tháng 10");
                    int T11 = StartColumn + columns.IndexOf("KH Tháng 11");
                    int T12 = StartColumn + columns.IndexOf("KH Tháng 12");

                    for (int i = 2; i <= row; i++)
                    {
                        Raw_Plan_RevenueDAOs.Add(new Raw_Plan_RevenueDAO
                        {
                            Year = Nam,
                            TongCongTy = worksheet.Cells[row, Company].Value?.ToString(),
                            PhongBanHang = worksheet.Cells[row, SaleRoom].Value?.ToString(),
                            Kenh = worksheet.Cells[row, SaleChannel].Value?.ToString(),
                            VungChiNhanh = worksheet.Cells[row, SaleBranch].Value?.ToString(),
                            Tinh = worksheet.Cells[row, SaleProvince].Value?.ToString(),
                            MaKhachHang = worksheet.Cells[row, CustomerCode].Value?.ToString(),
                            KhachHang = worksheet.Cells[row, Customer].Value?.ToString(),
                            KHNam = decimal.TryParse(worksheet.Cells[row, KHNam].Value?.ToString(), out decimal y) ? y : 0,
                            KHQuy1 = decimal.TryParse(worksheet.Cells[row, KHQ1].Value?.ToString(), out decimal q01) ? q01 : 0,
                            KHQuy2 = decimal.TryParse(worksheet.Cells[row, KHQ2].Value?.ToString(), out decimal q02) ? q02 : 0,
                            KHQuy3 = decimal.TryParse(worksheet.Cells[row, KHQ3].Value?.ToString(), out decimal q03) ? q03 : 0,
                            KHQuy4 = decimal.TryParse(worksheet.Cells[row, KHQ4].Value?.ToString(), out decimal q04) ? q04 : 0,
                            KHThang1 = decimal.TryParse(worksheet.Cells[row, T01].Value?.ToString(), out decimal t01) ? t01 : 0,
                            KHThang2 = decimal.TryParse(worksheet.Cells[row, T02].Value?.ToString(), out decimal t02) ? t02 : 0,
                            KHThang3 = decimal.TryParse(worksheet.Cells[row, T03].Value?.ToString(), out decimal t03) ? t03 : 0,
                            KHThang4 = decimal.TryParse(worksheet.Cells[row, T04].Value?.ToString(), out decimal t04) ? t04 : 0,
                            KHThang5 = decimal.TryParse(worksheet.Cells[row, T05].Value?.ToString(), out decimal t05) ? t05 : 0,
                            KHThang6 = decimal.TryParse(worksheet.Cells[row, T06].Value?.ToString(), out decimal t06) ? t06 : 0,
                            KHThang7 = decimal.TryParse(worksheet.Cells[row, T07].Value?.ToString(), out decimal t07) ? t07 : 0,
                            KHThang8 = decimal.TryParse(worksheet.Cells[row, T08].Value?.ToString(), out decimal t08) ? t08 : 0,
                            KHThang9 = decimal.TryParse(worksheet.Cells[row, T09].Value?.ToString(), out decimal t09) ? t09 : 0,
                            KHThang10 = decimal.TryParse(worksheet.Cells[row, T10].Value?.ToString(), out decimal t10) ? t10 : 0,
                            KHThang11 = decimal.TryParse(worksheet.Cells[row, T11].Value?.ToString(), out decimal t11) ? t11 : 0,
                            KHThang12 = decimal.TryParse(worksheet.Cells[row, T12].Value?.ToString(), out decimal t12) ? t12 : 0,
                        });
                    }
                }
            };
        
            await DataContext.BulkMergeAsync(Raw_Plan_RevenueDAOs);

            return Raw_Plan_RevenueDAOs;
        }
    }
}
