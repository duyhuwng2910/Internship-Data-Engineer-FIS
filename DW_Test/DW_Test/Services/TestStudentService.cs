using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services
{
    public interface ITestStudentService : IServiceScoped
    {
        Task<bool> Import(List<Student> StudentList);
    }
    public class TestStudentService : ITestStudentService
    {
        private DataContext DataContext;

        public TestStudentService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Import(List<Student> StudentRemote)
        {
            List<Student> StudentLocal = await DataContext.Student.ToListAsync();

            for (int i = 0; i < StudentLocal.Count; i++)
            {
                StudentLocal[i].getKey();
                StudentLocal[i].getValue();
            }

            // await DataContext.BulkDeleteAsync(StudentLocal);

            StudentLocal.OrderBy(x => x.key);

            StudentRemote.OrderBy(x => x.key);

            List<Student> InsertList = new List<Student>();

            List<Student> UpdateList = new List<Student>();

            List<Student> DeleteList = new List<Student>();

            int index = 0;

            int count = StudentLocal.Count;

            for (int j = 0; j < StudentRemote.Count && index < count;)
            {
                if (StudentRemote[j].key.CompareTo(StudentLocal[index].key) < 0)
                {
                    InsertList.Add(StudentRemote[j]);
                    j++;
                }
                else if (StudentRemote[j].key.CompareTo(StudentLocal[index].key) == 0)
                {
                    if (StudentRemote[j].value != StudentLocal[index].value)
                    {
                        var student = StudentRemote[j];
                        student.StudentID = StudentLocal[index].StudentID;
                        UpdateList.Add(student);
                    }

                    j++;

                    index++;
                }
                else
                {
                    DeleteList.Add(StudentLocal[index]);
                    index++;
                }
            }

            if (index < StudentRemote.Count)
            {
                while (index < StudentRemote.Count)
                {
                    InsertList.Add(StudentRemote[index]);
                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }
    }
}
