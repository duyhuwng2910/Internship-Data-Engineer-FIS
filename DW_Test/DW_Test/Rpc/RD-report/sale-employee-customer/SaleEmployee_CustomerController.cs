using DW_Test.Models;
using DW_Test.Services.RDService.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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

        public bool CheckNullCustomerRow(Raw_SaleEmployee_CustomerDAO row) 
        {
            return String.IsNullOrWhiteSpace(row.MaKH) &&
                   String.IsNullOrWhiteSpace(row.TenKH) &&
                   String.IsNullOrWhiteSpace(row.MaNV) &&
                   String.IsNullOrWhiteSpace(row.TenNV);
        }

        public bool CheckNullSaleEmployeeRow(Raw_SaleEmployeeDAO row)
        {
            return String.IsNullOrWhiteSpace(row.MaNV) &&
                   String.IsNullOrWhiteSpace(row.TenNV);
        }

        // API import dữ liệu vào bảng Raw_RD_Customer
        [HttpPost, Route(SaleEmployee_CustomerRoute.Import)]
        public async Task<ActionResult> SaleEmployee_CustomerUpExcel(IFormFile file)
        {
            await CustomerImport(file);

            await SaleEmployeeImport(file);

            return Ok();
        }

        public async Task<ActionResult> CustomerImport(IFormFile file)
        {
            #region Trích xuất template excel vào bảng Raw_RD_Customer
            List<Raw_SaleEmployee_CustomerDAO> Remote_Customer = new List<Raw_SaleEmployee_CustomerDAO>();

            List<Dim_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_Customer.ToListAsync();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets.Where(x => x.Name == "Customer").FirstOrDefault();

                    List<string> ErrorList = new List<string>();

                    // Nếu worksheet là null thì không có sheet mong muốn
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
                        var remote_customer = new Raw_SaleEmployee_CustomerDAO()
                        {
                            MaKH = worksheet.Cells[row, MaKH].Value?.ToString(),
                            TenKH = worksheet.Cells[row, TenKH].Value?.ToString(),
                            MaNV = worksheet.Cells[row, MaNV].Value?.ToString(),
                            TenNV = worksheet.Cells[row, TenNV].Value?.ToString()
                        };

                        var customer = Dim_CustomerDAOs
                            .Where(x => x.CustomerCode == remote_customer.MaKH).FirstOrDefault();

                        // Nếu mà có customer thì ta sẽ kiểm tra trùng lặp
                        if (customer != null)
                        {
                            var duplicate = Remote_Customer.Where(x => x.MaKH == customer.CustomerCode).FirstOrDefault();

                            // Nếu mà có trùng lặp thì ta sẽ trả về lỗi lặp tại dòng đó
                            if (duplicate != null)
                            {
                                return BadRequest($"Lỗi lặp mã khách hàng tại dòng {row}");
                            }
                        }
                        else
                        {
                            // Nếu toàn bộ dòng không có dữ liệu gì thì tức là đã hết bảng dữ liệu
                            // nên ta sẽ thoát khỏi vòng lặp
                            if (CheckNullCustomerRow(remote_customer))
                            {
                                break;
                            }

                            // Nếu không có customer thoả mãn thì sẽ trả về lỗi không tồn tại mã khách hàng
                            ErrorList.Add($"Mã khách hàng không tồn tại ở dòng {row}");
                        }

                        Remote_Customer.Add(remote_customer);
                    }

                    if (ErrorList.Count > 0)
                    {
                        return BadRequest(ErrorList);
                    }

                    await SaleEmployee_CustomerService.CustomerInit(Remote_Customer);
                }
            }
            #endregion

            return Ok();
        }

        public async Task<ActionResult> SaleEmployeeImport(IFormFile file)
        {
            #region Trích template excel vào bảng Raw_RD_SaleEmployee
            List<Raw_SaleEmployeeDAO> Remote_SaleEmployee = new List<Raw_SaleEmployeeDAO>();

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
                        Raw_SaleEmployeeDAO remote = new Raw_SaleEmployeeDAO()
                        {
                            MaNV = worksheet.Cells[row, MaNV].Value?.ToString(),
                            TenNV = worksheet.Cells[row, TenNV].Value?.ToString()
                        };

                        if (CheckNullSaleEmployeeRow(remote))
                        {
                            break;
                        }

                        Remote_SaleEmployee.Add(remote);
                    }

                    await SaleEmployee_CustomerService.SaleEmployeeInit(Remote_SaleEmployee);
                    #endregion

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
