﻿using DocumentFormat.OpenXml.Spreadsheet;
using DW_Test.Models;
using DW_Test.Services.RDService.Specialized_channel_sale_plan_revenue;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        private IRD_Region_PlanService RD_Region_PlanService;

        private IRD_SaleChannel_PlanService RD_SaleChannel_PlanService;

        private IRD_Customer_PlanService RD_Customer_PlanService;

        public SpecializedChannel_SalePlan_RevenueController
            (ISpecializedChannel_SalePlan_RevenueService SpecializedChannel_SalePlan_RevenueService,
                IRD_Region_PlanService RD_Region_PlanService, 
                IRD_SaleChannel_PlanService RD_SaleChannel_PlanService, 
                IRD_Customer_PlanService RD_Customer_PlanService)
        {
            this.SpecializedChannel_SalePlan_RevenueService = SpecializedChannel_SalePlan_RevenueService;
            this.RD_Region_PlanService = RD_Region_PlanService;
            this.RD_SaleChannel_PlanService = RD_SaleChannel_PlanService;
            this.RD_Customer_PlanService = RD_Customer_PlanService;
        }

        /*
         * Hàm bool kiểm tra xem bảng doanh thu có đang bị bỏ trống không
         */
        public bool CheckNullObjectRevenue(Raw_SpecializedChannel_SalePlan_RevenueDAO row)
        {
            return String.IsNullOrWhiteSpace(row.TenMien)
                && String.IsNullOrWhiteSpace(row.TenKenh)
                && String.IsNullOrWhiteSpace(row.MaKH)
                && String.IsNullOrWhiteSpace(row.TenKH);
        }

        [HttpPost, Route(SpecializedChannel_SalePlan_RevenueRoute.Import)]
        public async Task<ActionResult> SalePlan_RevenueUpExcel(IFormFile file)
        {
            List<Raw_SpecializedChannel_SalePlan_RevenueDAO> Remote = new List<Raw_SpecializedChannel_SalePlan_RevenueDAO>();

            // sử dụng biến stream cục bộ trong hàm
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var workbook = package.Workbook;

                    // Vòng lặp foreach cho từng worksheet của file Excel
                    // mỗi worksheet tương ứng với một năm
                    foreach (var worksheet in workbook.Worksheets)
                    {
                        // Lấy ra số năm của mỗi worksheet
                        long Year = long.TryParse(worksheet.Name, out long year) ? year : 0;

                        // Nếu mà số năm = 0 trong trường hợp trên thì
                        // trả về Exception lỗi load file Excel
                        if (Year == 0)
                        {
                            return BadRequest("Lỗi không có sheet các năm");
                        }

                        int StartColumn = 1;
                        int StartRow = 1;

                        List<string> ColumnNameList = new List<string>();

                        for (int column = StartColumn; column <= worksheet.Dimension.End.Column; column++)
                        {
                            ColumnNameList.Add(worksheet.Cells[StartRow, column].Value?.ToString() ?? "");
                        }

                        int TenMien = StartColumn + ColumnNameList.IndexOf("Tên Miền");
                        int TenKenh = StartColumn + ColumnNameList.IndexOf("Kênh Bán");
                        int MaKH = StartColumn + ColumnNameList.IndexOf("Mã KH");
                        int TenKH = StartColumn + ColumnNameList.IndexOf("TênKH");
                        int KHNam = StartColumn + ColumnNameList.IndexOf("KH Năm");
                        int KHQ1 = StartColumn + ColumnNameList.IndexOf("KH Quý 1");
                        int KHQ2 = StartColumn + ColumnNameList.IndexOf("KH Quý 2");
                        int KHQ3 = StartColumn + ColumnNameList.IndexOf("KH Quý 3");
                        int KHQ4 = StartColumn + ColumnNameList.IndexOf("KH Quý 4");
                        int T01 = StartColumn + ColumnNameList.IndexOf("KH Tháng 01");
                        int T02 = StartColumn + ColumnNameList.IndexOf("KH Tháng 02");
                        int T03 = StartColumn + ColumnNameList.IndexOf("KH Tháng 03");
                        int T04 = StartColumn + ColumnNameList.IndexOf("KH Tháng 04");
                        int T05 = StartColumn + ColumnNameList.IndexOf("KH Tháng 05");
                        int T06 = StartColumn + ColumnNameList.IndexOf("KH Tháng 06");
                        int T07 = StartColumn + ColumnNameList.IndexOf("KH Tháng 07");
                        int T08 = StartColumn + ColumnNameList.IndexOf("KH Tháng 08");
                        int T09 = StartColumn + ColumnNameList.IndexOf("KH Tháng 09");
                        int T10 = StartColumn + ColumnNameList.IndexOf("KH Tháng 10");
                        int T11 = StartColumn + ColumnNameList.IndexOf("KH Tháng 11");
                        int T12 = StartColumn + ColumnNameList.IndexOf("KH Tháng 12");

                        // Vòng lặp để insert dữ liệu trên mỗi dòng
                        for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                        {
                            Raw_SpecializedChannel_SalePlan_RevenueDAO remote = new Raw_SpecializedChannel_SalePlan_RevenueDAO()
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

                            if (CheckNullObjectRevenue(remote)) {
                                if (row == worksheet.Dimension.End.Row)
                                {
                                    break;
                                }
                            }

                            Remote.Add(remote);
                        }
                    }

                    await SpecializedChannel_SalePlan_RevenueService.Init(Remote);

                    return Ok();
                }
            }
        }

        // API transform sang các bảng Fact của luồng ETL kế hoạch doanh thu
        [HttpGet, Route(SpecializedChannel_SalePlan_RevenueRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await RD_Region_PlanService.Transform();

            await RD_SaleChannel_PlanService.Transform();

            await RD_Customer_PlanService.Transform();

            return Ok();
        }
    }
}
