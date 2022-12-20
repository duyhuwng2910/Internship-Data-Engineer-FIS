using DW_Test.Models;
using DW_Test.Services.RDService.Specialized_channel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DW_Test.Rpc.RD_report.specialized_channel_report
{
    public class SpecializedChannelController : ControllerBase
    {
        private ISpecializedChannelService SpecializedChannelService;

        public SpecializedChannelController(ISpecializedChannelService SpecializedChannelService)
        {
            this.SpecializedChannelService = SpecializedChannelService;
        }

        [HttpPost, Route(SpecializedChannelRoute.Init)]
        public async Task<ActionResult> SpecializedChannelUpExcel(IFormFile file)
        {
            List<Raw_SpecializedChannelDAO> Remote = new List<Raw_SpecializedChannelDAO>();

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

                    int TenMien = StartColumn + ColumnNameList.IndexOf("Tên Miền");
                    int TenKenh = StartColumn + ColumnNameList.IndexOf("Tên Kênh bán");
                    int SPC1 = StartColumn + ColumnNameList.IndexOf("Tên nhóm SPC1");

                    for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        Remote.Add(new Raw_SpecializedChannelDAO()
                        {
                            TenMien = worksheet.Cells[row, TenMien].Value?.ToString() ?? "",
                            TenKenh = worksheet.Cells[row, TenKenh].Value?.ToString() ?? "",
                            SPC1 = worksheet.Cells[row, SPC1].Value?.ToString() ?? ""
                        });
                    }

                    await SpecializedChannelService.Init(Remote);

                    return Ok();
                }
            }
        }
    }
}
