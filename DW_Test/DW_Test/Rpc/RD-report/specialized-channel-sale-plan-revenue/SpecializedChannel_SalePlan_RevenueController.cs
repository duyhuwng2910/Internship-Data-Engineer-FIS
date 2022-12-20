using DW_Test.HashModels;
using DW_Test.Models;
using DW_Test.Services.RDService.Specialized_channel_sale_plan_revenue;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore.Internal;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.specialized_channel_sale_plan_revenue
{
    public class SpecializedChannel_SalePlan_RevenueController : ControllerBase
    {
        private ISpecializedChannel_SalePlan_RevenueService SpecializedChannel_SalePlan_RevenueService;

        public SpecializedChannel_SalePlan_RevenueController(ISpecializedChannel_SalePlan_RevenueService SpecializedChannel_SalePlan_RevenueService)
        {
            this.SpecializedChannel_SalePlan_RevenueService = SpecializedChannel_SalePlan_RevenueService;
        }

        /*
         * Hàm bool kiểm tra xem bảng doanh thu có đang bị bỏ trống không
         */
        public bool CheckNullObjectRevenue(Raw_SpecializedChannel_SalePlan_RevenueDAO remote)
        {
            return String.IsNullOrWhiteSpace(remote.TenMien)
                && String.IsNullOrWhiteSpace(remote.TenKenh)
                && String.IsNullOrWhiteSpace(remote.MaKH)
                && String.IsNullOrWhiteSpace(remote.TenKH)
                && (remote.Nam == 0);
        }

        [HttpPost, Route(SpecializedChannel_SalePlan_RevenueRoute.Init)]
        public async Task<ActionResult> SalePlan_RevenueUpExcel(IFormFile file)
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO>
                    SpecializedChannel_SalePlan_RevenueRemoteDAOs 
                    = new List<Raw_SpecializedChannel_SalePlan_RevenueDAO>();

            // sử dụng biến stream cục bộ trong hàm
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var workbook = package.Workbook;

                    // Vòng lặp foreach cho từng worksheet của file Excel
                    // mỗi worksheet tương ứng với một năm
                    foreach(var worksheet in workbook.Worksheets)
                    {
                        // Lấy ra số năm của mỗi worksheet
                        long Year = long.TryParse(worksheet.Name, out long year) ? year : 0;

                        // Nếu mà số năm = 0 trong trường hợp trên thì
                        // trả về Exception lỗi load file Excel
                        if (Year == 0)
                        {
                            throw new Exception("Error to load Excel file");
                        }

                        int StartColumn = 1;
                        int StartRow = 1;

                        List<string> ColumnNameList = new List<string>();

                        for (int column = StartColumn; column <= worksheet.Dimension.End.Column; column++)
                        {
                            ColumnNameList.Add(worksheet.Cells[StartRow, column].Value?.ToString() ?? "");
                        }

                        int TenMien = StartColumn + ColumnNameList.IndexOf("Tên Miền");
                        int TenKenh = StartColumn + ColumnNameList.IndexOf("Kênh bán");
                        int MaKH = StartColumn + ColumnNameList.IndexOf("Mã KH");
                        int TenKH = StartColumn + ColumnNameList.IndexOf("Tên KH");
                        int KHNam = StartColumn + ColumnNameList.IndexOf("KH Năm");
                        int KHQ1 = StartColumn + ColumnNameList.IndexOf("KH Quý 1");
                        int KHQ2 = StartColumn + ColumnNameList.IndexOf("KH Quý 2");
                        int KHQ3 = StartColumn + ColumnNameList.IndexOf("KH Quý 3");
                        int KHQ4 = StartColumn + ColumnNameList.IndexOf("KH Quý 4");
                        int T01 = StartColumn + ColumnNameList.IndexOf("KH Tháng 1");
                        int T02 = StartColumn + ColumnNameList.IndexOf("KH Tháng 2");
                        int T03 = StartColumn + ColumnNameList.IndexOf("KH Tháng 3");
                        int T04 = StartColumn + ColumnNameList.IndexOf("KH Tháng 4");
                        int T05 = StartColumn + ColumnNameList.IndexOf("KH Tháng 5");
                        int T06 = StartColumn + ColumnNameList.IndexOf("KH Tháng 6");
                        int T07 = StartColumn + ColumnNameList.IndexOf("KH Tháng 7");
                        int T08 = StartColumn + ColumnNameList.IndexOf("KH Tháng 8");
                        int T09 = StartColumn + ColumnNameList.IndexOf("KH Tháng 9");
                        int T10 = StartColumn + ColumnNameList.IndexOf("KH Tháng 10");
                        int T11 = StartColumn + ColumnNameList.IndexOf("KH Tháng 11");
                        int T12 = StartColumn + ColumnNameList.IndexOf("KH Tháng 12");

                        // Vòng lặp để insert dữ liệu trên mỗi dòng
                        for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                        {
                            Raw_SpecializedChannel_SalePlan_RevenueDAO SalePlan_RevenueDAO = new Raw_SpecializedChannel_SalePlan_RevenueDAO()
                            {
                                Nam = Year,
                                TenMien = worksheet.Cells[row, TenMien].Value?.ToString(),
                                TenKenh = worksheet.Cells[row, TenKenh].Value?.ToString(),
                                MaKH = worksheet.Cells[row, MaKH].Value?.ToString(),
                                TenKH = worksheet.Cells[row, TenKH].Value?.ToString(),
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
                            };

                            if (!CheckNullObjectRevenue(SalePlan_RevenueDAO))
                            {
                                SpecializedChannel_SalePlan_RevenueRemoteDAOs.Add(SalePlan_RevenueDAO);
                            }
                        }
                    }

                    await SpecializedChannel_SalePlan_RevenueService.Init(SpecializedChannel_SalePlan_RevenueRemoteDAOs);

                    return Ok();
                }
            }
        }
    }
}
