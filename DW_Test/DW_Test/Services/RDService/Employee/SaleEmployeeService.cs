using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Employee
{
    public interface ISaleEmployeeService : IServiceScoped
    {
        public Task<bool> Init(List<Raw_SaleEmployeeDAO> Remote);

        public Task Transform();
    }
    public class SaleEmployeeService : ISaleEmployeeService
    {
        private DataContext DataContext;

        public SaleEmployeeService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Init(List<Raw_SaleEmployeeDAO> Remote)
        {
            List<Raw_SaleEmployeeDAO> Local = await DataContext.Raw_SaleEmployee.ToListAsync();

            List<Raw_SaleEmployeeDAO> HashRemote = Remote.OrderBy(x => x.MaNV).ToList();

            List<Raw_SaleEmployeeDAO> HashLocal = Local.OrderBy(x => x.MaNV).ToList();

            List<Raw_SaleEmployeeDAO> InsertList = new List<Raw_SaleEmployeeDAO>();

            List<Raw_SaleEmployeeDAO> UpdateList = new List<Raw_SaleEmployeeDAO>();

            List<Raw_SaleEmployeeDAO> DeleteList = new List<Raw_SaleEmployeeDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var remote in Remote)
                {
                    Local.Add(new Raw_SaleEmployeeDAO()
                    {
                        MaNV = remote.MaNV,
                        TenNV = remote.TenNV
                    });
                }

                await DataContext.BulkMergeAsync(Local);
            }
            else
            {
                for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
                {
                    if (CompareMethod.Compare(HashRemote[j].MaNV, HashLocal[index].MaNV) < 0)
                    {
                        InsertList.Add(new Raw_SaleEmployeeDAO()
                        {
                            MaNV = HashRemote[j].MaNV,
                            TenNV = HashRemote[j].TenNV
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].MaNV, HashLocal[index].MaNV) == 0)
                    {
                        if (HashRemote[j].TenNV != HashLocal[index].TenNV)
                        {
                            UpdateList.Add(new Raw_SaleEmployeeDAO()
                            {
                                Id = HashLocal[index].Id,
                                MaNV = HashLocal[index].MaNV,
                                TenNV = HashRemote[j].TenNV
                            });
                        }
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].MaNV, HashLocal[index].MaNV) > 0)
                    {
                        DeleteList.Add(new Raw_SaleEmployeeDAO()
                        {
                            Id = HashLocal[index].Id,
                            MaNV = HashLocal[index].MaNV,
                            TenNV = HashLocal[index].TenNV
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().MaNV != HashLocal.Last().MaNV)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Raw_SaleEmployeeDAO()
                        {
                            MaNV = HashRemote[index].MaNV,
                            TenNV = HashRemote[index].TenNV
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Raw_SaleEmployeeDAO()
                        {
                            Id = HashLocal[index].Id,
                            MaNV = HashLocal[index].MaNV,
                            TenNV = HashLocal[index].TenNV
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
                await DataContext.BulkMergeAsync(UpdateList);
            }

            return true;
        }

        public async Task Transform()
        {
            await Build_Dim_SaleEmployee();
        }

        public async Task<bool> Build_Dim_SaleEmployee()
        {
            List<Raw_SaleEmployee_CustomerDAO> Raw_SaleEmployee_CustomerDAOs = await DataContext
                .Raw_SaleEmployee_Customer.Where(x => !string.IsNullOrEmpty(x.MaNV)).ToListAsync();

            List<Dim_SaleEmployeeDAO> Local = await DataContext.Dim_SaleEmployee.ToListAsync();

            Raw_SaleEmployee_CustomerDAOs = Raw_SaleEmployee_CustomerDAOs.OrderBy(x => x.MaNV).ToList();

            Local = Local.OrderBy(x => x.EmployeeCode).ToList();

            List<Dim_SaleEmployeeDAO> InsertList = new List<Dim_SaleEmployeeDAO>();

            List<Dim_SaleEmployeeDAO> UpdateList = new List<Dim_SaleEmployeeDAO>();

            List<Dim_SaleEmployeeDAO> DeleteList = new List<Dim_SaleEmployeeDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var employee in Raw_SaleEmployee_CustomerDAOs)
                {
                    Local.Add(new Dim_SaleEmployeeDAO()
                    {
                        EmployeeCode = employee.MaNV,
                        EmployeeName = employee.TenNV
                    });
                }

                await DataContext.BulkMergeAsync(Local);
            }
            else
            {
                for (int j = 0; j < Raw_SaleEmployee_CustomerDAOs.Count && index < Local.Count;)
                {
                    if (CompareMethod.Compare(Raw_SaleEmployee_CustomerDAOs[j].MaNV, Local[index].EmployeeCode) < 0)
                    {
                        InsertList.Add(new Dim_SaleEmployeeDAO()
                        {
                            EmployeeCode = Raw_SaleEmployee_CustomerDAOs[j].MaNV,
                            EmployeeName = Raw_SaleEmployee_CustomerDAOs[j].TenNV
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(Raw_SaleEmployee_CustomerDAOs[j].MaNV, Local[index].EmployeeCode) == 0)
                    {
                        if (Raw_SaleEmployee_CustomerDAOs[j].TenNV != Local[index].EmployeeName)
                        {
                            UpdateList.Add(new Dim_SaleEmployeeDAO()
                            {
                                EmployeeCode = Local[index].EmployeeCode,
                                EmployeeName = Raw_SaleEmployee_CustomerDAOs[j].TenNV
                            });
                        }
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(Raw_SaleEmployee_CustomerDAOs[j].MaNV, Local[index].EmployeeCode) > 0)
                    {
                        DeleteList.Add(new Dim_SaleEmployeeDAO()
                        {
                            EmployeeId = Local[index].EmployeeId,
                            EmployeeCode = Local[index].EmployeeCode,
                            EmployeeName = Local[index].EmployeeName
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Raw_SaleEmployee_CustomerDAOs.Last().MaNV != Local.Last().EmployeeCode)
                {
                    while (index < Raw_SaleEmployee_CustomerDAOs.Count)
                    {
                        InsertList.Add(new Dim_SaleEmployeeDAO()
                        {
                            EmployeeCode = Raw_SaleEmployee_CustomerDAOs[index].MaNV,
                            EmployeeName = Raw_SaleEmployee_CustomerDAOs[index].TenNV
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_SaleEmployeeDAO()
                        {
                            EmployeeId = Local[index].EmployeeId,
                            EmployeeCode = Local[index].EmployeeCode,
                            EmployeeName = Local[index].EmployeeName
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
                await DataContext.BulkMergeAsync(UpdateList);
            }

            return true;
        }
    }
}
