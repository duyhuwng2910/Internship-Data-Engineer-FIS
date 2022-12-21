using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DW_Test.Models;
using DW_Test.Services.RDService.Product_group;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.product_group
{
    public class ProductGroupController : ControllerBase
    {
        private DataContext DataContext;

        private IProductGroupService ProductGroupService;

        public ProductGroupController(DataContext DataContext, IProductGroupService ProductGroupService)
        {
            this.DataContext = DataContext;
            this.ProductGroupService = ProductGroupService;
        }

        [HttpPost, Route(ProductGroupRoute.Init)]
        public async Task<ActionResult> ProductGroupUpExcel(IFormFile file)
        {
            List<Raw_Product_ProductGroupDAO> Remote = new List<Raw_Product_ProductGroupDAO>();

            List<Dim_ItemDAO> Dim_ItemDAOs = await DataContext.Dim_Item.ToListAsync();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets.Where(x => x.Name == "Product").FirstOrDefault();

                    if (worksheet == null)
                    {
                        return BadRequest($"Thiếu sheet Product");
                    }

                    List<string> ColumnNameList = new List<string>();

                    int StartColumn = 1;
                    int StartRow = 1;

                    for (int column = StartColumn; column < worksheet.Dimension.End.Column; column++)
                    {
                        ColumnNameList.Add(worksheet.Cells[StartRow, column].Value?.ToString() ?? "");
                    }

                    int MaSP = StartColumn + ColumnNameList.IndexOf("Mã sản phẩm");
                    int TenSP = StartColumn + ColumnNameList.IndexOf("Tên SP");
                    int SPC1 = StartColumn + ColumnNameList.IndexOf("Nhóm SPC1");
                    int SPC2 = StartColumn + ColumnNameList.IndexOf("Nhóm SPC2");
                    int ChatLuong = StartColumn + ColumnNameList.IndexOf("Cấp chất lượng");
                    int CongSuat = StartColumn + ColumnNameList.IndexOf("Công suất");
                    int NhietDoMau = StartColumn + ColumnNameList.IndexOf("Nhiệt độ màu");

                    for (int row = StartRow + 1; row < worksheet.Dimension.End.Row; row++)
                    {
                        var item = Dim_ItemDAOs
                            .Where(x => x.ItemCode == worksheet.Cells[row, MaSP].Value?.ToString()).FirstOrDefault();
                        
                        if (item == null)
                        {
                            return BadRequest($"Mã sản phẩm không tồn tại {worksheet.Cells[row, MaSP].Value?.ToString()}");
                        }

                        Remote.Add(new Raw_Product_ProductGroupDAO()
                        {
                            MaSP = worksheet.Cells[row, MaSP].Value?.ToString(),
                            TenSP = worksheet.Cells[row, TenSP].Value?.ToString(),
                            SPC1 = worksheet.Cells[row, SPC1].Value?.ToString(),
                            SPC2 = worksheet.Cells[row, SPC2].Value?.ToString(),
                            ChatLuong = worksheet.Cells[row, ChatLuong].Value?.ToString(),
                            CongSuat = worksheet.Cells[row, CongSuat].Value?.ToString(),
                            NhietDoMau = worksheet.Cells[row, NhietDoMau].Value?.ToString()
                        });
                    }

                    await ProductGroupService.Init(Remote);

                    return Ok();
                }
            }
        }

        [HttpGet, Route(ProductGroupRoute.Transform)]
        public async Task<ActionResult> Transform()
        {
            await ProductGroupService.Transform();

            return Ok();
        }
    }
}
