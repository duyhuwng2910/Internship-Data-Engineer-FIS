using DW_Test.Models;
using DW_Test.Rpc.unit_sale_plan_report;
using DW_Test.Services.MPlan_RevenueService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DW_Test.Rpc
{
    public class Plan_RevenueController : ControllerBase
    {
        private IPlan_RevenueService Plan_RevenueService;

        private ICompany_PlanService Company_PlanService;

        private ICustomer_PlanService Customer_PlanService;

        private ICounty_PlanService County_PlanService;

        private ISaleRoom_PlanService SaleRoom_PlanService;

        private ISaleChannel_PlanService SaleChannel_PlanService;

        private ISaleBranch_PlanService SaleBranch_PlanService;

        // hàm khởi tạo constructor
        public Plan_RevenueController(IPlan_RevenueService Plan_RevenueService
            , ICompany_PlanService Company_PlanService, ICustomer_PlanService Customer_PlanService
            , ICounty_PlanService County_PlanService, ISaleRoom_PlanService SaleRoom_PlanService
            , ISaleChannel_PlanService SaleChannel_PlanService, ISaleBranch_PlanService SaleBranch_PlanService)
        {
            this.Plan_RevenueService = Plan_RevenueService;
            this.Company_PlanService = Company_PlanService;
            this.Customer_PlanService = Customer_PlanService;
            this.County_PlanService = County_PlanService;
            this.SaleRoom_PlanService = SaleRoom_PlanService;
            this.SaleChannel_PlanService = SaleChannel_PlanService;
            this.SaleBranch_PlanService = SaleBranch_PlanService;
        }

        [HttpPost, Route(Plan_RevenueRoute.Init)]
        public async Task<ActionResult> Plan_RevenueUpExcel(IFormFile file)
        {
            List<Raw_Plan_RevenueDAO> Raw_Plan_RevenueRemoteDAOs = new List<Raw_Plan_RevenueDAO>();

            using (var Stream = new MemoryStream())
            {
                await file.CopyToAsync(Stream);

                using (var package = new ExcelPackage(Stream))
                {
                    var workbook = package.Workbook;

                    // Vòng lặp for cho từng worksheet
                    foreach (var worksheet in workbook.Worksheets)
                    {
                        // Lấy ra số năm của từng sheet
                        long Nam = long.TryParse(worksheet.Name, out long nam) ? nam : 0;

                        if (Nam == 0)
                        {
                            throw new Exception("Error");
                        }

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

                        // Vòng lặp để nhập dữ liệu trên mỗi dòng
                        for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                        {
                            Raw_Plan_RevenueDAO Raw_Plan_RevenueDAO = new Raw_Plan_RevenueDAO();

                            Raw_Plan_RevenueDAO.TongCongTy = worksheet.Cells[row, Company].Value?.ToString();
                            Raw_Plan_RevenueDAO.PhongBanHang = worksheet.Cells[row, SaleRoom].Value?.ToString();
                            Raw_Plan_RevenueDAO.Kenh = worksheet.Cells[row, SaleChannel].Value?.ToString();
                            Raw_Plan_RevenueDAO.VungChiNhanh = worksheet.Cells[row, SaleBranch].Value?.ToString();
                            Raw_Plan_RevenueDAO.Tinh = worksheet.Cells[row, SaleProvince].Value?.ToString();
                            Raw_Plan_RevenueDAO.MaKhachHang = worksheet.Cells[row, CustomerCode].Value?.ToString();
                            Raw_Plan_RevenueDAO.KhachHang = worksheet.Cells[row, Customer].Value?.ToString();
                            Raw_Plan_RevenueDAO.KHNam = decimal.TryParse(worksheet.Cells[row, KHNam].Value?.ToString(), out decimal y) ? y : 0;
                            Raw_Plan_RevenueDAO.KHQuy1 = decimal.TryParse(worksheet.Cells[row, KHQ1].Value?.ToString(), out decimal q01) ? q01 : 0;
                            Raw_Plan_RevenueDAO.KHQuy2 = decimal.TryParse(worksheet.Cells[row, KHQ2].Value?.ToString(), out decimal q02) ? q02 : 0;
                            Raw_Plan_RevenueDAO.KHQuy3 = decimal.TryParse(worksheet.Cells[row, KHQ3].Value?.ToString(), out decimal q03) ? q03 : 0;
                            Raw_Plan_RevenueDAO.KHQuy4 = decimal.TryParse(worksheet.Cells[row, KHQ4].Value?.ToString(), out decimal q04) ? q04 : 0;
                            Raw_Plan_RevenueDAO.KHThang1 = decimal.TryParse(worksheet.Cells[row, T01].Value?.ToString(), out decimal t01) ? t01 : 0;
                            Raw_Plan_RevenueDAO.KHThang2 = decimal.TryParse(worksheet.Cells[row, T02].Value?.ToString(), out decimal t02) ? t02 : 0;
                            Raw_Plan_RevenueDAO.KHThang3 = decimal.TryParse(worksheet.Cells[row, T03].Value?.ToString(), out decimal t03) ? t03 : 0;
                            Raw_Plan_RevenueDAO.KHThang4 = decimal.TryParse(worksheet.Cells[row, T04].Value?.ToString(), out decimal t04) ? t04 : 0;
                            Raw_Plan_RevenueDAO.KHThang5 = decimal.TryParse(worksheet.Cells[row, T05].Value?.ToString(), out decimal t05) ? t05 : 0;
                            Raw_Plan_RevenueDAO.KHThang6 = decimal.TryParse(worksheet.Cells[row, T06].Value?.ToString(), out decimal t06) ? t06 : 0;
                            Raw_Plan_RevenueDAO.KHThang7 = decimal.TryParse(worksheet.Cells[row, T07].Value?.ToString(), out decimal t07) ? t07 : 0;
                            Raw_Plan_RevenueDAO.KHThang8 = decimal.TryParse(worksheet.Cells[row, T08].Value?.ToString(), out decimal t08) ? t08 : 0;
                            Raw_Plan_RevenueDAO.KHThang9 = decimal.TryParse(worksheet.Cells[row, T09].Value?.ToString(), out decimal t09) ? t09 : 0;
                            Raw_Plan_RevenueDAO.KHThang10 = decimal.TryParse(worksheet.Cells[row, T10].Value?.ToString(), out decimal t10) ? t10 : 0;
                            Raw_Plan_RevenueDAO.KHThang11 = decimal.TryParse(worksheet.Cells[row, T11].Value?.ToString(), out decimal t11) ? t11 : 0;
                            Raw_Plan_RevenueDAO.KHThang12 = decimal.TryParse(worksheet.Cells[row, T12].Value?.ToString(), out decimal t12) ? t12 : 0;
                            Raw_Plan_RevenueDAO.Year = Nam;

                            if (!CheckNullObjectRevenue(Raw_Plan_RevenueDAO))
                            {
                                Raw_Plan_RevenueRemoteDAOs.Add(Raw_Plan_RevenueDAO);
                            }
                        }
                    }
                    await Plan_RevenueService.Import(Raw_Plan_RevenueRemoteDAOs);

                    return Ok();
                }
            }
        }

        /*
         * Hàm bool kiểm tra xem bảng doanh thu có đang bị bỏ trống không
         */
        public bool CheckNullObjectRevenue(Raw_Plan_RevenueDAO Raw_Plan_RevenueDAO)
        {
            return String.IsNullOrWhiteSpace(Raw_Plan_RevenueDAO.TongCongTy)
                && String.IsNullOrWhiteSpace(Raw_Plan_RevenueDAO.PhongBanHang)
                && String.IsNullOrWhiteSpace(Raw_Plan_RevenueDAO.Kenh)
                && String.IsNullOrWhiteSpace(Raw_Plan_RevenueDAO.VungChiNhanh)
                && String.IsNullOrWhiteSpace(Raw_Plan_RevenueDAO.Tinh)
                && String.IsNullOrWhiteSpace(Raw_Plan_RevenueDAO.MaKhachHang)
                && String.IsNullOrWhiteSpace(Raw_Plan_RevenueDAO.KhachHang)
                && (Raw_Plan_RevenueDAO.Year == 0);
        }

        [HttpGet, Route(Plan_RevenueRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await Company_PlanService.Company_PlanTransform();

            await Customer_PlanService.Customer_PlanTransform();

            await County_PlanService.County_PlanTransform();

            await SaleRoom_PlanService.SaleRoom_PlanTransform();

            await SaleChannel_PlanService.SaleChannel_PlanTransform();

            await SaleBranch_PlanService.SaleBranch_PlanTransform();

            return Ok();
        }
    }
}
