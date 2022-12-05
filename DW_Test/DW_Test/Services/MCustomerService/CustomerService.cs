using DW_Test.DWEModels;
using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Dim_CountryDAO = DW_Test.Models.Dim_CountryDAO;
using Dim_CountyDAO = DW_Test.Models.Dim_CountyDAO;
using Dim_CustomerDAO = DW_Test.Models.Dim_CustomerDAO;
using Dim_SaleBranchDAO = DW_Test.Models.Dim_SaleBranchDAO;
using Dim_SaleChannelDAO = DW_Test.Models.Dim_SaleChannelDAO;
using Dim_SaleRoomDAO = DW_Test.Models.Dim_SaleRoomDAO;
using Raw_Customer_RepDAO = DW_Test.Models.Raw_Customer_RepDAO;

namespace DW_Test.Services.MCustomerService
{
    public interface ICustomerService : IServiceScoped
    {
        Task<bool> CustomerInit();

        Task<bool> IncrementalCustomerInit();

        Task CustomerTransform();
    }

    public class CustomerService : ICustomerService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;

        public CustomerService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        // Phương thức init bảng Raw_Customer_Rep từ bảng nguồn trong DWE
        public async Task<bool> CustomerInit()
        {
            List<DWEModels.Raw_Customer_RepDAO> Raw_Customer_RepRemoteDAOs = await DWEContext.Raw_Customer_Rep.ToListAsync();

            List<Raw_Customer_RepDAO> Raw_Customer_RepLocalDAOs = await DataContext.Raw_Customer_Rep.ToListAsync();

            // Hàm dùng để xoá dữ liệu nếu có trên bảng
            await DataContext.BulkDeleteAsync(Raw_Customer_RepLocalDAOs);

            List<Raw_Customer_RepDAO> Raw_Customer_NewDAOs = Raw_Customer_RepRemoteDAOs.Select(x => new Raw_Customer_RepDAO()
            {
                CustomerCode = x.CustomerCode,
                CustomerName = x.CustomerName,
                CountryCode = x.CountryCode,
                CountryName = x.CountryName,
                SaleBranch = x.SaleBranch,
                SaleChannel = x.SaleChannel,
                SaleRoom = x.SaleRoom,
                CountyCode = x.CountyCode,
                CountyName = x.CountyName,
            }).ToList();

            await DataContext.BulkMergeAsync(Raw_Customer_NewDAOs);

            return true;
        }

        public async Task<bool> IncrementalCustomerInit()
        {
            // List data Local
            List<Raw_Customer_RepDAO> Raw_Customer_RepLocalDAOs = await DataContext.Raw_Customer_Rep.ToListAsync();

            // List data HashLocal
            List<Raw_Customer_Rep> HashLocal = Raw_Customer_RepLocalDAOs
                .Select(x => new Raw_Customer_Rep(x)).ToList();

            // List data Remote
            List<DWEModels.Raw_Customer_RepDAO> Raw_Customer_RepRemoteDAOs = await DWEContext.Raw_Customer_Rep.ToListAsync();

            // List data HashRemote
            List<Raw_Customer_Rep> HashRemote = Raw_Customer_RepRemoteDAOs
                .Select(x => new Raw_Customer_Rep(x)).ToList();

            // Sắp xếp List<> local theo Key
            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            // Sắp xếp List<> remote theo Key
            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            List<Raw_Customer_RepDAO> InsertList = new List<Raw_Customer_RepDAO>();

            List<Raw_Customer_RepDAO> UpdateList = new List<Raw_Customer_RepDAO>();

            List<Raw_Customer_RepDAO> DeleteList = new List<Raw_Customer_RepDAO>();

            int index = 0;

            // Vòng lặp chạy incremental load
            for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
            {
                // Nếu Key của remote nhỏ hơn tức là trong Local chưa có, ta thêm 
                // dòng vào trong InsertList và cộng 1 vào j
                if (CompareMethod.Compare(HashRemote[j].Key,
                                    HashLocal[index].Key) < 0)
                {
                    var remote = HashRemote[j];

                    var customer = new Raw_Customer_RepDAO()
                    {
                        CustomerCode = remote.CustomerCode,
                        CustomerName = remote.CustomerName,
                        CountyCode = remote.CountyCode,
                        CountyName = remote.CountyName,
                        SaleBranch = remote.SaleBranch,
                        SaleChannel = remote.SaleChannel,
                        SaleRoom = remote.SaleRoom,
                        CountryCode = remote.CountryCode,
                        CountryName = remote.CountryName
                    };

                    InsertList.Add(customer);

                    j++;
                }
                // Nếu hai Key đã bằng nhau thì kiểm tra Value
                // Nếu hai Value khác nhau thì thêm dòng vào UpdateList
                // còn bằng nhau thì continue sau đó cộng 1 vào j và index
                else if (CompareMethod.Compare(HashRemote[j].Key,
                                        HashLocal[index].Key) == 0)
                {
                    if (HashRemote[j].Value != HashLocal[index].Value)
                    {
                        var local = HashRemote[j];

                        var customer = new Raw_Customer_RepDAO()
                        {
                            Id = HashLocal[index].Id,
                            CustomerCode = HashLocal[index].CustomerCode,
                            CustomerName = local.CustomerName,
                            CountyCode = local.CountyCode,
                            CountyName = local.CountyName,
                            SaleBranch = local.SaleBranch,
                            SaleChannel = local.SaleChannel,
                            SaleRoom = local.SaleRoom,
                            CountryCode = local.CountryCode,
                            CountryName = local.CountryName
                        };

                        UpdateList.Add(customer);
                    }

                    j++;

                    index++;
                }
                // Nếu Key của remote lớn hơn tức là dòng này của Local trong Remote
                // không tồn tại, nên ta sẽ thêm dòng vào DeleteList
                // đồng thời cộng 1 vào index
                else
                {
                    var local = HashLocal[index];

                    var customer = new Raw_Customer_RepDAO()
                    {
                        Id = local.Id,
                        CustomerCode = local.CustomerCode,
                        CustomerName = local.CustomerName,
                        CountyCode = local.CountyCode,
                        CountyName = local.CountyName,
                        SaleBranch = local.SaleBranch,
                        SaleChannel = local.SaleChannel,
                        SaleRoom = local.SaleRoom,
                        CountryCode = local.CountryCode,
                        CountryName = local.CountryName
                    };

                    DeleteList.Add(customer);

                    index++;
                }
            }

            // Nếu local đã chạy hết, index vẫn nhỏ hơn count của HashRemote
            // đồng thời là hai key của phần tử thứ index của hai bảng là bằng nhau
            // thì ta tiến hành insert toàn bộ các dòng còn lại ở remote vào HashLocal
            if (index == HashLocal.Count && HashLocal.Last().Key != HashRemote.Last().Key)
            {
                while (index < HashRemote.Count)
                {
                    var remote = HashRemote[index];

                    var customer = new Raw_Customer_RepDAO()
                    {
                        CustomerCode = remote.CustomerCode,
                        CustomerName = remote.CustomerName,
                        CountyCode = remote.CountyCode,
                        CountyName = remote.CountyName,
                        SaleBranch = remote.SaleBranch,
                        SaleChannel = remote.SaleChannel,
                        SaleRoom = remote.SaleRoom,
                        CountryCode = remote.CountryCode,
                        CountryName = remote.CountryName
                    };

                    InsertList.Add(customer);

                    index++;
                }
            }
            // Nếu index < count của local tức là local còn thừa dữ liệu cũ
            // Nên ta sẽ delete toàn bộ các dòng còn lại ở HashLocal
            else if (index < HashLocal.Count)
            {
                while (index < HashLocal.Count)
                {
                    var local = HashLocal[index];

                    var customer = new Raw_Customer_RepDAO()
                    {
                        Id = local.Id,
                        CustomerCode = local.CustomerCode,
                        CustomerName = local.CustomerName,
                        CountyCode = local.CountyCode,
                        CountyName = local.CountyName,
                        SaleBranch = local.SaleBranch,
                        SaleChannel = local.SaleChannel,
                        SaleRoom = local.SaleRoom,
                        CountryCode = local.CountryCode,
                        CountryName = local.CountryName
                    };

                    DeleteList.Add(customer);

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }

        // Phương thức transform bảng raw thành bảng dim_customer
        public async Task CustomerTransform()
        {
            await Build_Dim_Customer();
            await Build_Dim_Country();
            await Build_Dim_County();
            await Build_Dim_SaleBranch();
            await Build_Dim_SaleChannel();
            await Build_Dim_SaleRoom();
            await Build_Dim_UnitMapping();
        }

        // Tạo bảng dim_customer
        private async Task<bool> Build_Dim_Customer()
        {
            // List kiểu Raw_Customer_RepDAO gán cho bảng ở trong DataContext local
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.CustomerCode)).ToListAsync();

            // List kiểu Dim_CustomerDAO gán cho bảng dim trong local
            List<Dim_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_Customer.ToListAsync();

            Raw_Customer_RepDAOs = Raw_Customer_RepDAOs.OrderBy(x => x.CustomerCode).ToList();

            Dim_CustomerDAOs = Dim_CustomerDAOs.OrderBy(x => x.CustomerCode).ToList();

            List<Dim_CustomerDAO> InsertList = new List<Dim_CustomerDAO>();

            List<Dim_CustomerDAO> UpdateList = new List<Dim_CustomerDAO>();

            List<Dim_CustomerDAO> DeleteList = new List<Dim_CustomerDAO>();

            int index = 0;

            for (int j = 0; j < Raw_Customer_RepDAOs.Count && index < Dim_CustomerDAOs.Count;)
            {
                if (CompareMethod.Compare(Raw_Customer_RepDAOs[j].CustomerCode,
                                          Dim_CustomerDAOs[index].CustomerCode) < 0)
                {
                    InsertList.Add(new Dim_CustomerDAO()
                    {
                        CustomerCode = Raw_Customer_RepDAOs[j].CustomerCode,
                        CustomerName = Raw_Customer_RepDAOs[j].CustomerName
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Raw_Customer_RepDAOs[j].CustomerCode,
                                               Dim_CustomerDAOs[index].CustomerCode) == 0)
                {
                    if (Raw_Customer_RepDAOs[j].CountyName != Dim_CustomerDAOs[index].CustomerName)
                    {
                        UpdateList.Add(new Dim_CustomerDAO()
                        {
                            CustomerId = Dim_CustomerDAOs[index].CustomerId,
                            CustomerCode = Dim_CustomerDAOs[index].CustomerCode,
                            CustomerName = Raw_Customer_RepDAOs[j].CustomerName
                        });
                    }

                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Raw_Customer_RepDAOs[j].CustomerCode,
                                               Dim_CustomerDAOs[index].CustomerCode) > 0)
                {
                    DeleteList.Add(new Dim_CustomerDAO()
                    {
                        CustomerId = Dim_CustomerDAOs[index].CustomerId,
                        CustomerCode = Dim_CustomerDAOs[index].CustomerCode,
                        CustomerName = Dim_CustomerDAOs[index].CustomerName
                    });

                    index++;
                }
            }

            if (index == Dim_CustomerDAOs.Count &&
                Raw_Customer_RepDAOs.Last().CustomerCode != Dim_CustomerDAOs.Last().CustomerCode)
            {
                while (index < Raw_Customer_RepDAOs.Count)
                {
                    InsertList.Add(new Dim_CustomerDAO()
                    {
                        CustomerCode = Raw_Customer_RepDAOs[index].CustomerCode,
                        CustomerName = Raw_Customer_RepDAOs[index].CustomerName
                    });

                    index++;
                }
            }
            else if (index < Dim_CustomerDAOs.Count)
            {
                while (index < Dim_CustomerDAOs.Count)
                {
                    DeleteList.Add(new Dim_CustomerDAO()
                    {
                        CustomerId = Dim_CustomerDAOs[index].CustomerId,
                        CustomerCode = Dim_CustomerDAOs[index].CustomerCode,
                        CustomerName = Dim_CustomerDAOs[index].CustomerName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }

        // Tạo bảng dim_country
        private async Task<bool> Build_Dim_Country()
        {
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.CountryCode)).ToListAsync();

            List<Dim_CountryDAO> Dim_CountryDAOs = await DataContext.Dim_Country.ToListAsync();

            var dim = from country in Raw_Customer_RepDAOs
                      group country by country.CountryCode into CountryCode
                      orderby CountryCode.Key
                      select CountryCode.Key;

            List<string> countryCode = new List<string>();

            foreach (var CountryCode in dim)
            {
                countryCode.Add(CountryCode);
            }

            Dim_CountryDAOs = Dim_CountryDAOs.OrderBy(x => x.CountryCode).ToList();

            List<Dim_CountryDAO> InsertList = new List<Dim_CountryDAO>();

            List<Dim_CountryDAO> UpdateList = new List<Dim_CountryDAO>();

            List<Dim_CountryDAO> DeleteList = new List<Dim_CountryDAO>();

            int index = 0;

            for (int j = 0; j < countryCode.Count && index < Dim_CountryDAOs.Count;)
            {
                if (CompareMethod.Compare(countryCode[j], Dim_CountryDAOs[index].CountryCode) < 0)
                {
                    InsertList.Add(new Dim_CountryDAO()
                    {
                        CountryCode = countryCode[j],
                        CountryName = Raw_Customer_RepDAOs.Where(x => x.CountryCode == countryCode[j])
                                                            .Select(x => x.CountryName).FirstOrDefault()
                    });

                    j++;
                }
                else if (CompareMethod.Compare(countryCode[j], Dim_CountryDAOs[index].CountryCode) == 0)
                {
                    var countryName = Raw_Customer_RepDAOs.Where(x => x.CountryCode == countryCode[j])
                                                            .Select(x => x.CountryName).FirstOrDefault();
                    if (countryName != Dim_CountryDAOs[index].CountryName)
                    {
                        UpdateList.Add(new Dim_CountryDAO()
                        {
                            CountryId = Dim_CountryDAOs[index].CountryId,
                            CountryCode = Dim_CountryDAOs[index].CountryCode,
                            CountryName = countryName
                        });
                    }

                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(countryCode[j], Dim_CountryDAOs[index].CountryCode) > 0)
                {
                    DeleteList.Add(new Dim_CountryDAO()
                    {
                        CountryId = Dim_CountryDAOs[index].CountryId,
                        CountryCode = Dim_CountryDAOs[index].CountryCode,
                        CountryName = Dim_CountryDAOs[index].CountryName
                    });

                    index++;
                }
            }

            if (index == Dim_CountryDAOs.Count && countryCode.Last() != Dim_CountryDAOs.Last().CountryCode)
            {
                while (index < countryCode.Count)
                {
                    InsertList.Add(new Dim_CountryDAO()
                    {
                        CountryCode = countryCode[index],
                        CountryName = Raw_Customer_RepDAOs.Where(x => x.CountryCode == countryCode[index])
                                        .Select(x => x.CountryName).FirstOrDefault()
                    });

                    index++;
                }
            }
            else if (index < Dim_CountryDAOs.Count)
            {
                while (index < Dim_CountryDAOs.Count)
                {
                    DeleteList.Add(new Dim_CountryDAO()
                    {
                        CountryId = Dim_CountryDAOs[index].CountryId,
                        CountryCode = Dim_CountryDAOs[index].CountryCode,
                        CountryName = Dim_CountryDAOs[index].CountryName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            //foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            //{
            //    Dim_CountryDAO Dim_Country = Dim_CountryDAOs.Where(x => x.CountryCode == Raw_Customer_RepDAO.CountryCode).FirstOrDefault();

            //    if (Dim_Country == null)
            //    {
            //        Dim_Country = new Dim_CountryDAO
            //        {
            //            CountryCode = Raw_Customer_RepDAO.CountryCode,
            //            CountryName = Raw_Customer_RepDAO.CountryName,
            //        };
            //        Dim_CountryDAOs.Add(Dim_Country);
            //    }
            //    else
            //    {
            //        Dim_Country.CountryName = Raw_Customer_RepDAO.CountryName;
            //    }
            //}


            //await DataContext.BulkMergeAsync(Dim_CountryDAOs);

            return true;
        }

        // Tạo bảng dim_county
        private async Task<bool> Build_Dim_County()
        {
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.CountyCode)).ToListAsync();

            List<Dim_CountyDAO> Dim_CountyDAOs = await DataContext.Dim_County.ToListAsync();

            var dim = from county in Raw_Customer_RepDAOs
                      group county by county.CountyCode into CountyCode
                      orderby CountyCode.Key
                      select CountyCode.Key;

            List<string> countyCode = new List<string>();

            foreach (var CountyCode in dim)
            {
                countyCode.Add(CountyCode);
            }

            Dim_CountyDAOs = Dim_CountyDAOs.OrderBy(x => x.CountyCode).ToList();

            List<Dim_CountyDAO> InsertList = new List<Dim_CountyDAO>();

            List<Dim_CountyDAO> UpdateList = new List<Dim_CountyDAO>();

            List<Dim_CountyDAO> DeleteList = new List<Dim_CountyDAO>();

            int index = 0;

            for (int j = 0; j < countyCode.Count && index < Dim_CountyDAOs.Count;)
            {
                if (CompareMethod.Compare(countyCode[j], Dim_CountyDAOs[index].CountyCode) < 0)
                {
                    InsertList.Add(new Dim_CountyDAO()
                    {
                        CountyCode = countyCode[j],
                        CountyName = Raw_Customer_RepDAOs.Where(x => x.CountyCode == countyCode[j])
                                                            .Select(x => x.CountyName).FirstOrDefault()
                    });

                    j++;
                }
                else if (CompareMethod.Compare(countyCode[j], Dim_CountyDAOs[index].CountyCode) == 0)
                {
                    var countyName = Raw_Customer_RepDAOs.Where(x => x.CountyCode == countyCode[j])
                                                            .Select(x => x.CountyName).FirstOrDefault();
                    if (countyName != Dim_CountyDAOs[index].CountyName)
                    {
                        UpdateList.Add(new Dim_CountyDAO()
                        {
                            CountyId = Dim_CountyDAOs[index].CountyId,
                            CountyCode = Dim_CountyDAOs[index].CountyCode,
                            CountyName = countyName,
                        });
                    }

                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(countyCode[j], Dim_CountyDAOs[index].CountyCode) > 0)
                {
                    DeleteList.Add(new Dim_CountyDAO()
                    {
                        CountyId = Dim_CountyDAOs[index].CountyId,
                        CountyCode = Dim_CountyDAOs[index].CountyCode,
                        CountyName = Dim_CountyDAOs[index].CountyName
                    });

                    index++;
                }
            }

            if (index == Dim_CountyDAOs.Count && countyCode.Last() != Dim_CountyDAOs.Last().CountyCode)
            {
                while (index < countyCode.Count)
                {
                    InsertList.Add(new Dim_CountyDAO()
                    {
                        CountyCode = countyCode[index],
                        CountyName = Raw_Customer_RepDAOs.Where(x => x.CountyCode == countyCode[index])
                                        .Select(x => x.CountyName).FirstOrDefault()
                    });

                    index++;
                }
            }
            else if (index < Dim_CountyDAOs.Count)
            {
                while (index < Dim_CountyDAOs.Count)
                {
                    DeleteList.Add(new Dim_CountyDAO()
                    {
                        CountyId = Dim_CountyDAOs[index].CountyId,
                        CountyCode = Dim_CountyDAOs[index].CountyCode,
                        CountyName = Dim_CountyDAOs[index].CountyName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);
            //foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            //{
            //    Dim_CountyDAO Dim_County = Dim_CountyDAOs.Where(x => x.CountyCode == Raw_Customer_RepDAO.CountyCode).FirstOrDefault();

            //    if (Dim_County == null)
            //    {
            //        Dim_County = new Dim_CountyDAO
            //        {
            //            CountyCode = Raw_Customer_RepDAO.CountyCode,
            //            CountyName = Raw_Customer_RepDAO.CountyName,
            //        };
            //        Dim_CountyDAOs.Add(Dim_County);
            //    }
            //    else
            //    {
            //        Dim_County.CountyName = Raw_Customer_RepDAO.CountyName;
            //    }
            //}
            //await DataContext.BulkMergeAsync(Dim_CountyDAOs);

            return true;
        }

        // Tạo bảng dim_sale_branch
        private async Task<bool> Build_Dim_SaleBranch()
        {
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.SaleBranch)).ToListAsync();

            List<Dim_SaleBranchDAO> Dim_Sale_BranchDAOs = await DataContext.Dim_SaleBranch.ToListAsync();

            foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            {
                Dim_SaleBranchDAO Dim_Sale_Branch = Dim_Sale_BranchDAOs.Where(x => x.SaleBranchName == Raw_Customer_RepDAO.SaleBranch).FirstOrDefault();

                if (Dim_Sale_Branch == null)
                {
                    Dim_Sale_Branch = new Dim_SaleBranchDAO
                    {
                        SaleBranchName = Raw_Customer_RepDAO.SaleBranch,
                    };
                    Dim_Sale_BranchDAOs.Add(Dim_Sale_Branch);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Sale_BranchDAOs);

            return true;
        }

        // Tạo bảng dim_sale_channel
        private async Task<bool> Build_Dim_SaleChannel()
        {
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.SaleChannel)).ToListAsync();

            List<Dim_SaleChannelDAO> Dim_Sale_ChannelDAOs = await DataContext.Dim_SaleChannel.ToListAsync();

            foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            {
                Dim_SaleChannelDAO Dim_Sale_Channel = Dim_Sale_ChannelDAOs.Where(x => x.SaleChannelName == Raw_Customer_RepDAO.SaleChannel).FirstOrDefault();

                if (Dim_Sale_Channel == null)
                {
                    Dim_Sale_Channel = new Dim_SaleChannelDAO
                    {
                        SaleChannelName = Raw_Customer_RepDAO.SaleChannel,
                    };
                    Dim_Sale_ChannelDAOs.Add(Dim_Sale_Channel);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Sale_ChannelDAOs);

            return true;
        }

        // Tạo bảng dim_sale_room
        public async Task<bool> Build_Dim_SaleRoom()
        {
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.SaleRoom)).ToListAsync();

            List<Dim_SaleRoomDAO> Dim_Sale_RoomDAOs = await DataContext.Dim_SaleRoom.ToListAsync();

            foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            {
                Dim_SaleRoomDAO Dim_Sale_Room = Dim_Sale_RoomDAOs.Where(x => x.SaleRoomName == Raw_Customer_RepDAO.SaleRoom).FirstOrDefault();

                if (Dim_Sale_Room == null)
                {
                    Dim_Sale_Room = new Dim_SaleRoomDAO
                    {
                        SaleRoomName = Raw_Customer_RepDAO.SaleRoom,
                    };
                    Dim_Sale_RoomDAOs.Add(Dim_Sale_Room);
                }
            }
            await DataContext.BulkMergeAsync(Dim_Sale_RoomDAOs);

            return true;
        }

        // Tạo bảng dim_unit_mapping
        private async Task<bool> Build_Dim_UnitMapping()
        {
            var Countries = await DataContext.Dim_Country.ToListAsync();
            var Counties = await DataContext.Dim_County.ToListAsync();
            var Customers = await DataContext.Dim_Customer.ToListAsync();
            var SaleBranchs = await DataContext.Dim_SaleBranch.ToListAsync();
            var SaleChannels = await DataContext.Dim_SaleChannel.ToListAsync();
            var SaleRooms = await DataContext.Dim_SaleRoom.ToListAsync();
            var Dim_Unit_MappingDAOs = await DataContext.Dim_UnitMapping.ToListAsync();

            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep.ToListAsync();

            foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            {
                /*
                 * 6 biến var ở dưới dùng để kiểm tra data trong các bảng dim tương ứng có ở trong bảng Raw_Customer_Rep không
                 */
                var Country = Countries.Where(x => x.CountryCode == Raw_Customer_RepDAO.CountryCode).FirstOrDefault();
                var County = Counties.Where(x => x.CountyCode == Raw_Customer_RepDAO.CountyCode).FirstOrDefault();
                var Customer = Customers.Where(x => x.CustomerCode == Raw_Customer_RepDAO.CustomerCode).FirstOrDefault();
                var SaleBranch = SaleBranchs.Where(x => x.SaleBranchName == Raw_Customer_RepDAO.SaleBranch).FirstOrDefault();
                var SaleChannel = SaleChannels.Where(x => x.SaleChannelName == Raw_Customer_RepDAO.SaleChannel).FirstOrDefault();
                var SaleRoom = SaleRooms.Where(x => x.SaleRoomName == Raw_Customer_RepDAO.SaleRoom).FirstOrDefault();

                // Kiểm tra xem trong bảng dim mapping đã có dữ liệu từ các bảng dim chưa
                Dim_UnitMappingDAO Dim_Unit_Mapping = Dim_Unit_MappingDAOs
                    .Where(x => x.CustomerId == Customer?.CustomerId).FirstOrDefault();

                // Nếu chưa thì tạo mới, trước đó tiến hành ánh xạ giữa 6 bảng dim và bảng raw để nối và tạo ra các dòng
                // trong bảng dim mapping
                if (Dim_Unit_Mapping == null)
                {
                    Dim_Unit_Mapping = new Dim_UnitMappingDAO
                    {
                        CountyId = County?.CountyId ?? null,
                        CountryId = Country?.CountryId ?? null,
                        CustomerId = Customer?.CustomerId ?? null,
                        SaleBranchId = SaleBranch?.SaleBranchId ?? null,
                        SaleChannelId = SaleChannel?.SaleChannelId ?? null,
                        SaleRoomId = SaleRoom?.SaleRoomId ?? null,
                    };
                    Dim_Unit_MappingDAOs.Add(Dim_Unit_Mapping);
                }
                else
                {
                    Dim_Unit_Mapping.CountyId = County?.CountyId ?? null;
                    Dim_Unit_Mapping.CountryId = Country?.CountryId ?? null;
                    Dim_Unit_Mapping.SaleBranchId = SaleBranch?.SaleBranchId ?? null;
                    Dim_Unit_Mapping.SaleChannelId = SaleChannel?.SaleChannelId ?? null;
                    Dim_Unit_Mapping.SaleRoomId = SaleRoom?.SaleRoomId ?? null;
                }
            }
            await DataContext.BulkMergeAsync(Dim_Unit_MappingDAOs);

            return true;
        }
    }
}
