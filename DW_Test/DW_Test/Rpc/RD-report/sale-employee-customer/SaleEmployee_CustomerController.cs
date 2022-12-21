using DW_Test.Models;
using DW_Test.Services.RDService.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.sale_employee
{
    public class SaleEmployee_CustomerController : ControllerBase
    {
        private DataContext DataContext;

        private ISaleEmployee_CustomerService SaleEmployee_CustomerService;

        public SaleEmployee_CustomerController
            (DataContext DataContext, ISaleEmployee_CustomerService SaleEmployee_CustomerService)
        {
            this.DataContext = DataContext;
            this.SaleEmployee_CustomerService = SaleEmployee_CustomerService;
        }

        // API import dữ liệu và bảng Raw_RD_Customer
        [HttpPost, Route(SaleEmployee_CustomerRoute.CustomerInit)]
        public async Task<ActionResult> SaleEmployee_CustomerUpExcel(IFormFile file)
        {
            List<Raw_SaleEmployee_CustomerDAO> Remote = new List<Raw_SaleEmployee_CustomerDAO>();

            List<Dim_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_Customer.ToListAsync();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {

                    var worksheet = package.Workbook.Worksheets.Where(x => x.Name == "Customer").FirstOrDefault();

                    if (worksheet == null)
                    {
                        return BadRequest("Thiếu sheet Customer");
                    }

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
                        var customer = Dim_CustomerDAOs
                            .Where(x => x.CustomerCode == worksheet.Cells[row, MaKH].Value?.ToString()).FirstOrDefault();

                        if (customer == null)
                        {
                            return BadRequest($"Mã khách hàng không tồn tại {worksheet.Cells[row, MaKH].Value?.ToString()}");
                        }

                        var remote = new Raw_SaleEmployee_CustomerDAO()
                        {
                            MaKH = worksheet.Cells[row, MaKH].Value?.ToString(),
                            TenKH = worksheet.Cells[row, TenKH].Value?.ToString(),
                            MaNV = worksheet.Cells[row, MaNV].Value?.ToString(),
                            TenNV = worksheet.Cells[row, TenNV].Value?.ToString()
                        };

                        Remote.Add(remote);
                    }
                    await SaleEmployee_CustomerService.CustomerInit(Remote);

                    return Ok();
                }
            }
        }

        // API import dữ liệu vào bảng Raw_SaleEmployee
        [HttpPost, Route(SaleEmployee_CustomerRoute.SaleEmployeeInit)]
        public async Task<ActionResult> SaleEmployeeUpExcel(IFormFile file)
        {
            List<Raw_SaleEmployeeDAO> Remote = new List<Raw_SaleEmployeeDAO>();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets.Where(x => x.Name == "Employee").FirstOrDefault();

                    if (worksheet == null)
                    {
                        return BadRequest("Thiết sheet Employee");
                    }

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
                            MaNV = worksheet.Cells[row, MaNV].Value?.ToString(),
                            TenNV = worksheet.Cells[row, TenNV].Value?.ToString()
                        });
                    }

                    await SaleEmployee_CustomerService.SaleEmployeeInit(Remote);

                    return Ok();
                }
            }
        }

        // API transform dữ liệu sang 3 bảng Dim trong luồng nhân viên - khách hàng
        [HttpGet, Route(SaleEmployee_CustomerRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await SaleEmployee_CustomerService.Transform();

            return Ok();
        }
    }
}
