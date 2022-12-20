using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.Build.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Task = System.Threading.Tasks.Task;

namespace DW_Test.Services.RDService.Employee
{
    public interface ISaleEmployee_CustomerService : IServiceScoped
    {
        public Task<bool> Init(List<Raw_SaleEmployee_CustomerDAO> Remote);

        public Task Transform();
    }
    public class SaleEmployee_CustomerService : ISaleEmployee_CustomerService
    {
        private DataContext DataContext;

        public SaleEmployee_CustomerService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Init(List<Raw_SaleEmployee_CustomerDAO> Remote)
        {
            #region Quá trình kiểm định tính đúng của dữ liệu trên template Excel
            List<Raw_SaleEmployee_CustomerDAO> CorrectedRemote = new List<Raw_SaleEmployee_CustomerDAO>();

            List<Dim_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_Customer.ToListAsync();

            foreach (var customer in Dim_CustomerDAOs)
            {
                Raw_SaleEmployee_CustomerDAO SaleEmployee_Customer = Remote
                                .Where(x => x.MaKH == customer.CustomerCode).FirstOrDefault();

                if (SaleEmployee_Customer != null)
                {
                    CorrectedRemote.Add(SaleEmployee_Customer);
                }
            }
            #endregion

            List<Raw_SaleEmployee_CustomerDAO> Local = await DataContext.Raw_SaleEmployee_Customer.ToListAsync();

            List<Raw_SaleEmployee_Customer> HashRemote = Remote.Select(x => new Raw_SaleEmployee_Customer(x)).ToList();

            List<Raw_SaleEmployee_Customer> HashLocal = Local.Select(x => new Raw_SaleEmployee_Customer(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Raw_SaleEmployee_CustomerDAO> InsertList = new List<Raw_SaleEmployee_CustomerDAO>();

            List<Raw_SaleEmployee_CustomerDAO> UpdateList = new List<Raw_SaleEmployee_CustomerDAO>();

            List<Raw_SaleEmployee_CustomerDAO> DeleteList = new List<Raw_SaleEmployee_CustomerDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var remote in Remote)
                {
                    Local.Add(new Raw_SaleEmployee_CustomerDAO()
                    {
                        MaKH = remote.MaKH,
                        TenKH = remote.TenKH,
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
                    if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                    {
                        InsertList.Add(new Raw_SaleEmployee_CustomerDAO()
                        {
                            MaKH = HashRemote[j].MaKH,
                            TenKH = HashRemote[j].TenKH,
                            MaNV = HashRemote[j].MaNV,
                            TenNV = HashRemote[j].TenNV
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Raw_SaleEmployee_CustomerDAO()
                            {
                                Id = HashLocal[index].Id,
                                MaKH = HashLocal[index].MaKH,
                                TenKH = HashLocal[index].TenKH,
                                MaNV = HashRemote[j].MaNV,
                                TenNV = HashRemote[j].TenNV
                            });
                        }
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Raw_SaleEmployee_CustomerDAO()
                        {
                            Id = HashLocal[index].Id,
                            MaKH = HashLocal[index].MaKH,
                            TenKH = HashLocal[index].TenKH,
                            MaNV = HashLocal[index].MaNV,
                            TenNV = HashLocal[index].TenNV
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Raw_SaleEmployee_CustomerDAO()
                        {
                            MaKH = HashRemote[index].MaKH,
                            TenKH = HashRemote[index].TenKH,
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
                        DeleteList.Add(new Raw_SaleEmployee_CustomerDAO()
                        {
                            Id = HashLocal[index].Id,
                            MaKH = HashLocal[index].MaKH,
                            TenKH = HashLocal[index].TenKH,
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
            await Build_Dim_RD_Customer();

            await Build_Dim_RD_CustomerEmployeeMapping();
        }

        public async Task<bool> Build_Dim_RD_Customer()
        {
            List<Raw_SaleEmployee_CustomerDAO> Raw_SaleEmployee_CustomerDAOs = await DataContext
                .Raw_SaleEmployee_Customer.Where(x => !string.IsNullOrEmpty(x.MaKH)).ToListAsync();

            List<Dim_RD_CustomerDAO> Local = await DataContext.Dim_RD_Customer.ToListAsync();
            
            Raw_SaleEmployee_CustomerDAOs = Raw_SaleEmployee_CustomerDAOs.OrderBy(x => x.MaKH).ToList();

            Local = Local.OrderBy(x => x.CustomerCode).ToList();

            List<Dim_RD_CustomerDAO> InsertList = new List<Dim_RD_CustomerDAO>();

            List<Dim_RD_CustomerDAO> UpdateList = new List<Dim_RD_CustomerDAO>();

            List<Dim_RD_CustomerDAO> DeleteList = new List<Dim_RD_CustomerDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var customer in Raw_SaleEmployee_CustomerDAOs)
                {
                    Local.Add(new Dim_RD_CustomerDAO()
                    {
                        CustomerCode = customer.MaKH,
                        CustomerName = customer.TenKH
                    });
                }

                await DataContext.BulkMergeAsync(Local);
            }
            else
            {
                for (int j = 0; j < Raw_SaleEmployee_CustomerDAOs.Count && index < Local.Count;)
                {
                    if (CompareMethod.Compare(Raw_SaleEmployee_CustomerDAOs[j].MaKH, Local[index].CustomerCode) < 0)
                    {
                        InsertList.Add(new Dim_RD_CustomerDAO()
                        {
                            CustomerCode = Raw_SaleEmployee_CustomerDAOs[j].MaKH,
                            CustomerName = Raw_SaleEmployee_CustomerDAOs[j].TenKH
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(Raw_SaleEmployee_CustomerDAOs[j].MaKH, Local[index].CustomerCode) == 0)
                    {
                        if (Raw_SaleEmployee_CustomerDAOs[j].TenKH != Local[index].CustomerName)
                        {
                            UpdateList.Add(new Dim_RD_CustomerDAO()
                            {
                                CustomerCode = Local[index].CustomerCode,
                                CustomerName = Raw_SaleEmployee_CustomerDAOs[j].TenKH
                            });
                        }
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(Raw_SaleEmployee_CustomerDAOs[j].MaKH, Local[index].CustomerCode) > 0)
                    {
                        DeleteList.Add(new Dim_RD_CustomerDAO()
                        {
                            CustomerId = Local[index].CustomerId,
                            CustomerCode = Local[index].CustomerCode,
                            CustomerName = Local[index].CustomerName
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Raw_SaleEmployee_CustomerDAOs.Last().MaKH != Local.Last().CustomerCode)
                {
                    while (index < Raw_SaleEmployee_CustomerDAOs.Count)
                    {
                        InsertList.Add(new Dim_RD_CustomerDAO()
                        {
                            CustomerCode = Raw_SaleEmployee_CustomerDAOs[index].MaKH,
                            CustomerName = Raw_SaleEmployee_CustomerDAOs[index].TenKH
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_RD_CustomerDAO()
                        {
                            CustomerId = Local[index].CustomerId,
                            CustomerCode = Local[index].CustomerCode,
                            CustomerName = Local[index].CustomerName
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

        public async Task<bool> Build_Dim_RD_CustomerEmployeeMapping()
        {
            List<Dim_RD_CustomerDAO> Dim_RD_CustomerDAOs = await DataContext.Dim_RD_Customer.ToListAsync();

            List<Dim_SaleEmployeeDAO> Dim_SaleEmployeeDAOs = await DataContext.Dim_SaleEmployee.ToListAsync();

            List<Raw_SaleEmployee_CustomerDAO> Raw_SaleEmployee_CustomerDAOs =
                await DataContext.Raw_SaleEmployee_Customer.ToListAsync();

            List<Dim_CustomerEmployeeMappingDAO> Local = await DataContext.Dim_CustomerEmployeeMapping.ToListAsync();

            List<Dim_CustomerEmployeeMappingDAO> Remote = new List<Dim_CustomerEmployeeMappingDAO>();

            foreach (var raw in Raw_SaleEmployee_CustomerDAOs)
            {
                var customer = Dim_RD_CustomerDAOs.Where(x => x.CustomerCode == raw.MaKH).FirstOrDefault();

                var employee = Dim_SaleEmployeeDAOs.Where(x => x.EmployeeCode == raw.MaNV).FirstOrDefault();

                Remote.Add(new Dim_CustomerEmployeeMappingDAO()
                {
                    CustomerId = customer.CustomerId,
                    EmployeeId = employee?.EmployeeId ?? null
                });
            }

            Local = Local.OrderBy(x => x.CustomerId).ToList();

            Remote = Remote.OrderBy(x => x.CustomerId).ToList();

            List<Dim_CustomerEmployeeMappingDAO> InsertList = new List<Dim_CustomerEmployeeMappingDAO>();

            List<Dim_CustomerEmployeeMappingDAO> UpdateList = new List<Dim_CustomerEmployeeMappingDAO>();

            List<Dim_CustomerEmployeeMappingDAO> DeleteList = new List<Dim_CustomerEmployeeMappingDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach (var remote in Remote)
                {
                    Local.Add(new Dim_CustomerEmployeeMappingDAO()
                    {
                        CustomerId = remote.CustomerId,
                        EmployeeId = remote.EmployeeId
                    });
                }

                await DataContext.BulkMergeAsync(Local);
            }
            else
            {
                for (int j = 0; j < Remote.Count && index < Local.Count;)
                {
                    if (Remote[j].CustomerId < Local[index].CustomerId) 
                    {
                        InsertList.Add(new Dim_CustomerEmployeeMappingDAO()
                        {
                            CustomerId = Remote[j].CustomerId,
                            EmployeeId = Remote[j].EmployeeId
                        });

                        j++;
                    }
                    else if (Remote[j].CustomerId == Local[index].CustomerId)
                    {
                        if (Remote[j].EmployeeId != Local[index].EmployeeId)
                        {
                            UpdateList.Add(new Dim_CustomerEmployeeMappingDAO()
                            {
                                MappingId = Local[index].MappingId,
                                CustomerId = Local[index].MappingId,
                                EmployeeId = Remote[j].EmployeeId
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (Remote[j].CustomerId > Local[index].CustomerId)
                    {
                        DeleteList.Add(new Dim_CustomerEmployeeMappingDAO()
                        {
                            MappingId = Local[index].MappingId,
                            CustomerId = Local[index].CustomerId,
                            EmployeeId = Local[index].EmployeeId
                        });

                        index++;
                    }
                }

                if (index == Local.Count && Remote.Last().CustomerId != Local.Last().CustomerId)
                {
                    while (index < Remote.Count)
                    {
                        InsertList.Add(new Dim_CustomerEmployeeMappingDAO()
                        {
                            CustomerId = Remote[index].CustomerId,
                            EmployeeId = Remote[index].EmployeeId
                        });

                        index++;
                    }
                }
                else if (index < Local.Count)
                {
                    while (index < Local.Count)
                    {
                        DeleteList.Add(new Dim_CustomerEmployeeMappingDAO()
                        {
                            MappingId = Local[index].MappingId,
                            CustomerId = Local[index].CustomerId,
                            EmployeeId = Local[index].EmployeeId
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
