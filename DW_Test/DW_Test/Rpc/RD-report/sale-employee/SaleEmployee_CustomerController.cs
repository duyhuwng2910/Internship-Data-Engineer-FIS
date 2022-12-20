using DW_Test.Models;
using DW_Test.Services.RDService.Employee;
using DW_Test.Services.RDService.Specialized_channel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Utilities;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.sale_employee
{
    public class SaleEmployee_CustomerController : ControllerBase
    {
        private ISaleEmployee_CustomerService SaleEmployee_CustomerService;

        public SaleEmployee_CustomerController(ISaleEmployee_CustomerService SaleEmployee_CustomerService)
        {
            this.SaleEmployee_CustomerService = SaleEmployee_CustomerService;
        }

        [HttpPost, Route(SaleEmployee_CustomerRoute.Init)]
        public async Task<ActionResult> SaleEmployee_CustomerUpExcel(IFormFile file)
        {
            List<Raw_SaleEmployee_CustomerDAO> Remote = new List<Raw_SaleEmployee_CustomerDAO>();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[1];

                    int StartColumn = 1;
                    int StartRow = 1;

                    List<string> ColumnNameList = new List<string>();

                    for (int column = StartColumn; column <= worksheet.Dimension.End.Column; column++)
                    {
                        ColumnNameList.Add(worksheet.Cells[StartRow, column].Value?.ToString() ?? "");
                    }

                    int MaKH = StartColumn + ColumnNameList.IndexOf("Mã KH");
                    int TenKH = StartColumn + ColumnNameList.IndexOf("Tên KH");
                    int MaNV = StartColumn + ColumnNameList.IndexOf("Mã NV");
                    int TenNV = StartColumn + ColumnNameList.IndexOf("Tên NV");

                    for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        Remote.Add(new Raw_SaleEmployee_CustomerDAO()
                        {
                            MaKH = worksheet.Cells[row, MaKH].Value?.ToString() ?? "",
                            TenKH = worksheet.Cells[row, TenKH].Value?.ToString() ?? "",
                            MaNV = worksheet.Cells[row, MaNV].Value?.ToString() ?? "",
                            TenNV = worksheet.Cells[row, TenNV].Value?.ToString() ?? ""
                        }); ;
                    }

                    await SaleEmployee_CustomerService.Init(Remote);

                    return Ok();
                }
            }
        }

        [HttpGet, Route(SaleEmployee_CustomerRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await SaleEmployee_CustomerService.Transform();

            return Ok();
        }
    }
}
