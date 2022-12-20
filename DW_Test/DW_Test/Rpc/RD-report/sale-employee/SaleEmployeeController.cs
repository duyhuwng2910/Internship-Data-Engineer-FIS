using DW_Test.Models;
using DW_Test.Services.RDService.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.sale_employee
{
    public class SaleEmployeeController : ControllerBase
    {
        private ISaleEmployeeService SaleEmployeeService;

        public SaleEmployeeController(ISaleEmployeeService SaleEmployeeService)
        {
            this.SaleEmployeeService = SaleEmployeeService;
        }

        [HttpPost, Route(SaleEmployeeRoute.Init)]
        public async Task<ActionResult> SaleEmployeeUpExcel(IFormFile file)
        {
            List<Raw_SaleEmployeeDAO> Remote = new List<Raw_SaleEmployeeDAO>();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    int StartColumn = 1;
                    int StartRow = 1;

                    List<string> ColumnNameList = new List<string>();

                    for (int column = StartColumn; column <= worksheet.Dimension.End.Column; column++)
                    {
                        ColumnNameList.Add(worksheet.Cells[StartRow, column].Value?.ToString() ?? "");
                    }

                    int MaNV = StartColumn + ColumnNameList.IndexOf("Mã nhân viên");
                    int TenNV = StartColumn + ColumnNameList.IndexOf("Tên nhân viên");

                    for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        Remote.Add(new Raw_SaleEmployeeDAO()
                        {
                            MaNV = worksheet.Cells[row, MaNV].Value?.ToString() ?? "",
                            TenNV = worksheet.Cells[row, TenNV].Value?.ToString() ?? ""
                        });
                    }

                    await SaleEmployeeService.Init(Remote);

                    return Ok();
                }
            }
        }

        [HttpGet, Route(SaleEmployeeRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await SaleEmployeeService.Transform();

            return Ok();
        }
    }
}
