using DW_Test.Models;
using DW_Test.Services.MProduct_GroupService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace DW_Test.Rpc.product_group
{
    public class Product_GroupController : ControllerBase
    {
        private DataContext DataContext;

        private IProduct_GroupService Product_GroupService;

        public Product_GroupController(DataContext DataContext, IProduct_GroupService Product_GroupService)
        {
            this.DataContext = DataContext;
            this.Product_GroupService = Product_GroupService;
        }

        [HttpPost, Route(Product_GroupRoute.Init)]
        public async Task<ActionResult> Product_GroupUpExcel(IFormFile file)
        {
            List<Raw_Product_GroupDAO> Raw_Product_GroupRemoteDAOs = new List<Raw_Product_GroupDAO>();

            using (var Stream = new MemoryStream())
            {
                await file.CopyToAsync(Stream);

                using (var package = new ExcelPackage(Stream))
                {
                    var workbook = package.Workbook;

                    var worksheet = workbook.Worksheets[0];

                    int StartColumn = 1;

                    int StartRow = 1;

                    List<string> columns = new List<string>();

                    // Vòng lặp để lấy tên cột
                    for (int column = StartColumn; column <= worksheet.Dimension.End.Column; column++)
                    {
                        string columnName = worksheet.Cells[StartRow, column].Value?.ToString() ?? "";
                        columns.Add(columnName);
                    }

                    int ItemCode = StartColumn + columns.IndexOf("ItemCode");
                    int ItemName = StartColumn + columns.IndexOf("ItemName");
                    int Loai_MHang_KH = StartColumn + columns.IndexOf("LOAI_MHANG");
                    int Nhomchinh_KH = StartColumn + columns.IndexOf("NHOMCHINH");
                    int NhomC1 = StartColumn + columns.IndexOf("NHOMC1");
                    int NhomC2 = StartColumn + columns.IndexOf("NHOMC2");
                    int NhomC3 = StartColumn + columns.IndexOf("NHOMC3");
                    int Nhom_LEDSMRT1 = StartColumn + columns.IndexOf("NHOM_LEDSMRT1");
                    int Nhom_SMARTDONLE = StartColumn + columns.IndexOf("NHOM_SMRTDONLE");
                    int M_StartDate = StartColumn + columns.IndexOf("M_StartDate");
                    int M_EndDate = StartColumn + columns.IndexOf("M_EndDate");
                    int GTGT_StartDate = StartColumn + columns.IndexOf("GTGT_StartDate");
                    int GTGT_EndDate = StartColumn + columns.IndexOf("GTGT_EndDate");

                    // Vòng lặp để đọc dữ liệu trên mỗi dòng
                    for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        Raw_Product_GroupDAO Raw_Product_GroupDAO = new Raw_Product_GroupDAO();

                        Raw_Product_GroupDAO.ItemCode = worksheet.Cells[row, ItemCode].Value?.ToString();
                        Raw_Product_GroupDAO.ItemName = worksheet.Cells[row, ItemName].Value?.ToString();
                        Raw_Product_GroupDAO.Loai_MHang_KH = worksheet.Cells[row, Loai_MHang_KH].Value?.ToString();
                        Raw_Product_GroupDAO.Nhomchinh_KH = worksheet.Cells[row, Nhomchinh_KH].Value?.ToString();
                        Raw_Product_GroupDAO.NhomC1 = worksheet.Cells[row, NhomC1].Value?.ToString();
                        Raw_Product_GroupDAO.NhomC2 = worksheet.Cells[row, NhomC2].Value?.ToString();
                        Raw_Product_GroupDAO.NhomC3 = worksheet.Cells[row, NhomC3].Value?.ToString();
                        Raw_Product_GroupDAO.Nhom_LEDSMRT1 = worksheet.Cells[row, Nhom_LEDSMRT1].Value?.ToString();
                        Raw_Product_GroupDAO.Nhom_SMARTDONLE = worksheet.Cells[row, Nhom_SMARTDONLE].Value?.ToString();
                        
                        Raw_Product_GroupDAO.M_StartDate = DateTime.TryParseExact(worksheet.Cells[row, M_StartDate].Text.ToString(), "dd-MM-yyyy", 
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date1) ? (DateTime?)date1 : null;
                        
                        Raw_Product_GroupDAO.M_EndDate = DateTime.TryParseExact(worksheet.Cells[row, M_EndDate].Text.ToString(), "dd-MM-yyyy",
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date2) ? (DateTime?)date2 : null;
                        
                        Raw_Product_GroupDAO.GTGT_StartDate = DateTime.TryParseExact(worksheet.Cells[row, GTGT_StartDate].Text.ToString(), "dd-MM-yyyy",
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date3) ? (DateTime?)date3 : null;

                        Raw_Product_GroupDAO.GTGT_EndDate = DateTime.TryParseExact(worksheet.Cells[row, GTGT_EndDate].Text.ToString(), "dd-MM-yyyy",
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date4) ? (DateTime?)date4 : null;

                        Raw_Product_GroupRemoteDAOs.Add(Raw_Product_GroupDAO);
                    }
                }

                await Product_GroupService.Import(Raw_Product_GroupRemoteDAOs);

                return Ok();
            }
        }

        [HttpGet, Route(Product_GroupRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await Product_GroupService.Product_GroupTransform();

            return Ok();
        }
    }
}
