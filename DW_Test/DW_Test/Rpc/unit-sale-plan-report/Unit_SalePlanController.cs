using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using TrueSight.Common;
using DW_Test.Services.MUnit_SalePlanService;
using DW_Test.Rpc.unit_sale_plan_report;

namespace DW_Test.Rpc
{
    public class Unit_SalePlanController : ControllerBase
    {
        // hai thuộc tính private của class
        private DataContext DataContext;

        private Unit_SalePlanService Excel_SaleUnit_SalePlan_RevenueService;

        // hàm khởi tạo constructor
        public Unit_SalePlanController(DataContext DataContext, Unit_SalePlanService Excel_SaleUnit_SalePlan_RevenueService)
        {
            this.DataContext = DataContext;
            // this.Excel_SaleUnit_SalePlan_RevenueService = Excel_SaleUnit_SalePlan_RevenueService;
        }

        [RequestSizeLimit(100_000_000)]
        [HttpPost, Route(Unit_SalePlanRoute.Init)]
        public async Task SaleUnit_SalePlanRevenueUpExcel(IFormFile file)
        {
            if (!ModelState.IsValid)
                throw new BindException(ModelState);
            try
            {
                MemoryStream memoryStream = new MemoryStream();

                file.OpenReadStream().CopyTo(memoryStream);

                List<Raw_SaleUnit_SalePlan_RevenueDAO> Raw_SaleUnit_SalePlan_RevenueDAOs = await ReadRevenueExcel(memoryStream);

                //Hàm này gọi đến service để import dữ liệu vào db
                //await Excel_SaleUnit_SalePlan_RevenueService.Handle(Raw_SaleUnit_SalePlan_RevenueDAOs);
            }
            catch (Exception e)
            {
                throw new MessageException(e);
            }
        }

        /*
         * Hàm bool kiểm tra xem bảng doanh thu có đang bị bỏ trống không
         */
        public bool CheckNullObjectRevenue(Raw_SaleUnit_SalePlan_RevenueDAO Raw_SaleUnit_SalePlan_RevenueDAO)
        {
            return String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.Company)
                && String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.SaleMainBusiness)
                && String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.SaleRoom)
                && String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.SaleChannel)
                && String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.SaleBranch)
                && String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.SaleProvince)
                && String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.CustomerCode)
                && String.IsNullOrWhiteSpace(Raw_SaleUnit_SalePlan_RevenueDAO.Customer)
                && Raw_SaleUnit_SalePlan_RevenueDAO.Year == null && Raw_SaleUnit_SalePlan_RevenueDAO.Year == 0;
        }

        /*
         * Hàm bất đồng bộ đọc vào một file Excel, return về kiểu dữ liệu là một List kiểu Raw_SaleUnit_SalePlan_RevenueDAO
         */
        private async Task<List<Raw_SaleUnit_SalePlan_RevenueDAO>> ReadRevenueExcel(Stream Stream)
        {
            if (Stream != null)
            {
                using (var package = new ExcelPackage(Stream))
                {
                    List<Raw_SaleUnit_SalePlan_RevenueDAO> Raw_SaleUnit_SalePlan_RevenueDAOs = new List<Raw_SaleUnit_SalePlan_RevenueDAO>();
                    var workbook = package.Workbook;

                    //var worksheet = workbook.Worksheets.FirstOrDefault();
                    // Vòng lặp for cho từng worksheet
                    foreach (var worksheet in workbook.Worksheets)
                    {
                        // Lấy ra số năm của từng sheet
                        long Nam = long.TryParse(worksheet.Name, out long nam) ? nam : 0;

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
                            try
                            {
                                Raw_SaleUnit_SalePlan_RevenueDAO Raw_SaleUnit_SalePlan_RevenueDAO = new Raw_SaleUnit_SalePlan_RevenueDAO();
                                //rowXK.Stt = Stt;
                                //Raw_SaleUnit_SalePlan_RevenueDAO.Company = DateTime.TryParse(worksheet.Cells[row, Day].Value?.ToString(), out DateTime day) ? day : DateTime.Now;
                                //Raw_SaleUnit_SalePlan_RevenueDAO.Month = decimal.TryParse(worksheet.Cells[row, Month].Value?.ToString(), out decimal month) ? month : 0;
                                //Raw_SaleUnit_SalePlan_RevenueDAO.OrderCode = worksheet.Cells[row, OrderCo  de].Value?.ToString();

                                Raw_SaleUnit_SalePlan_RevenueDAO.Company = worksheet.Cells[row, Company].Value?.ToString();
                                Raw_SaleUnit_SalePlan_RevenueDAO.SaleRoom = worksheet.Cells[row, SaleRoom].Value?.ToString();
                                Raw_SaleUnit_SalePlan_RevenueDAO.SaleChannel = worksheet.Cells[row, SaleChannel].Value?.ToString();
                                Raw_SaleUnit_SalePlan_RevenueDAO.SaleBranch = worksheet.Cells[row, SaleBranch].Value?.ToString();
                                Raw_SaleUnit_SalePlan_RevenueDAO.SaleProvince = worksheet.Cells[row, SaleProvince].Value?.ToString();
                                Raw_SaleUnit_SalePlan_RevenueDAO.CustomerCode = worksheet.Cells[row, CustomerCode].Value?.ToString();
                                Raw_SaleUnit_SalePlan_RevenueDAO.Customer = worksheet.Cells[row, Customer].Value?.ToString();
                                Raw_SaleUnit_SalePlan_RevenueDAO.YearPlan = decimal.TryParse(worksheet.Cells[row, KHNam].Value?.ToString(), out decimal y) ? y : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.Q01Plan = decimal.TryParse(worksheet.Cells[row, KHQ1].Value?.ToString(), out decimal q01) ? q01 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.Q02Plan = decimal.TryParse(worksheet.Cells[row, KHQ2].Value?.ToString(), out decimal q02) ? q02 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.Q03Plan = decimal.TryParse(worksheet.Cells[row, KHQ3].Value?.ToString(), out decimal q03) ? q03 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.Q04Plan = decimal.TryParse(worksheet.Cells[row, KHQ4].Value?.ToString(), out decimal q04) ? q04 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M01Plan = decimal.TryParse(worksheet.Cells[row, T01].Value?.ToString(), out decimal t01) ? t01 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M02Plan = decimal.TryParse(worksheet.Cells[row, T02].Value?.ToString(), out decimal t02) ? t02 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M03Plan = decimal.TryParse(worksheet.Cells[row, T03].Value?.ToString(), out decimal t03) ? t03 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M04Plan = decimal.TryParse(worksheet.Cells[row, T04].Value?.ToString(), out decimal t04) ? t04 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M05Plan = decimal.TryParse(worksheet.Cells[row, T05].Value?.ToString(), out decimal t05) ? t05 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M06Plan = decimal.TryParse(worksheet.Cells[row, T06].Value?.ToString(), out decimal t06) ? t06 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M07Plan = decimal.TryParse(worksheet.Cells[row, T07].Value?.ToString(), out decimal t07) ? t07 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M08Plan = decimal.TryParse(worksheet.Cells[row, T08].Value?.ToString(), out decimal t08) ? t08 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M09Plan = decimal.TryParse(worksheet.Cells[row, T09].Value?.ToString(), out decimal t09) ? t09 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M10Plan = decimal.TryParse(worksheet.Cells[row, T10].Value?.ToString(), out decimal t10) ? t10 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M11Plan = decimal.TryParse(worksheet.Cells[row, T11].Value?.ToString(), out decimal t11) ? t11 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.M12Plan = decimal.TryParse(worksheet.Cells[row, T12].Value?.ToString(), out decimal t12) ? t12 : 0;
                                Raw_SaleUnit_SalePlan_RevenueDAO.Year = Nam;

                                if (!CheckNullObjectRevenue(Raw_SaleUnit_SalePlan_RevenueDAO))
                                {
                                    Raw_SaleUnit_SalePlan_RevenueDAOs.Add(Raw_SaleUnit_SalePlan_RevenueDAO);

                                }
                            }
                            catch (Exception ex)
                            {
                                throw new MessageException("File lỗi tại dòng " + row);
                            }
                        }

                    }


                    return Raw_SaleUnit_SalePlan_RevenueDAOs;
                }
            }
            else
            {
                throw new MessageException("Không có hành động nào được thực hiện, bạn vui lòng thử lại sau.");
            }
        }
    }

}
