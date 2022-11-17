using DW_Test.HashModels;
using DW_Test.Models;
using DW_Test.Rpc.student;
using DW_Test.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DW_Test.Rpc
{
    public class TestStudentController : ControllerBase
    {
        private DataContext DataContext;

        private ITestStudentService TestStudentService;

        public TestStudentController(DataContext DataContext, ITestStudentService TestStudentService)
        {
            this.DataContext = DataContext;
            this.TestStudentService = TestStudentService;
        }

        [HttpPost, Route(TestStudentRoute.Init)]
        public async Task<ActionResult> IncrementalInit(IFormFile file)
        {
            List<Student> StudentList = new List<Student>();

            using (var Stream = new MemoryStream())
            {
                await file.CopyToAsync(Stream);

                using (var package = new ExcelPackage(Stream))
                {
                    var workbook = package.Workbook;

                    var worksheet = workbook.Worksheets[1];

                    int StartColumn = 1;

                    int StartRow = 1;

                    List<string> columns = new List<string>();

                    for (int col = StartColumn; col <= worksheet.Dimension.End.Column; col++)
                    {
                        string columnName = worksheet.Cells[StartRow,col].Value?.ToString() ?? "";
                        columns.Add(columnName);
                    }

                    int StudentID = StartColumn + columns.IndexOf("StudentID");

                    int Name = StartColumn + columns.IndexOf("Name");

                    int Age = StartColumn + columns.IndexOf("Age");

                    int GPA = StartColumn + columns.IndexOf("GPA");

                    for (int row = StartRow + 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        Student students = new Student();

                        students.StudentID = worksheet.Cells[row, StudentID].Value?.ToString();

                        students.Name = worksheet.Cells[row, Name].Value?.ToString();

                        students.Age = Int32.TryParse(worksheet.Cells[row, Age].Value?.ToString(), out int age) ? age : 0;

                        students.GPA = Int32.TryParse(worksheet.Cells[row, GPA].Value?.ToString(), out int gpa) ? gpa : 0;

                        students.getKey();

                        students.getValue();
                        
                        StudentList.Add(students);
                    }
                }
                await TestStudentService.Import(StudentList);
                
                return Ok();
            }
        }
    }
}
