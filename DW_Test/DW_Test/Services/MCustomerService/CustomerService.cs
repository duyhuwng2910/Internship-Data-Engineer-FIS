using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        // Phương thức transform bảng raw thành bảng dim_customer
        public async Task CustomerTransform()
        {
            await Build_Dim_Customer();
            await Build_Dim_Country();
            await Build_Dim_County();
            await Build_Dim_Sale_Branch();
            await Build_Dim_Sale_Channel();
            await Build_Dim_Sale_Room();
            await Build_Dim_Unit_Mapping();
        }

        // Tạo bảng dim_customer
        private async Task<bool> Build_Dim_Customer()
        {
            // List kiểu Raw_Customer_RepDAO gán cho bảng ở trong DataContext local
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep.Where(x => !string.IsNullOrEmpty(x.CustomerCode)).ToListAsync();

            // List kiểu Dim_CustomerDAO gán cho bảng dim trong local
            List<Dim_CustomerDAO> Dim_CustomerDAOs = await DataContext.Dim_Customer.ToListAsync();

            // Vòng lặp foreach đối với từng dòng trong bảng Raw_Customer_Rep
            foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            {
                // Kiểm tra xem có dòng nào của bảng dim trong local giống với trong Local không
                Dim_CustomerDAO Dim_Customer = Dim_CustomerDAOs.Where(x => x.CustomerCode == Raw_Customer_RepDAO.CustomerCode).FirstOrDefault();

                // Nếu không thì tạo mới và add vào bảng dim trong local
                if (Dim_Customer == null)
                {
                    Dim_Customer = new Dim_CustomerDAO
                    {
                        CustomerCode = Raw_Customer_RepDAO.CustomerCode,
                        CustomerName = Raw_Customer_RepDAO.CustomerName,
                    };
                    Dim_CustomerDAOs.Add(Dim_Customer);
                }
                else
                {
                    Dim_Customer.CustomerName = Raw_Customer_RepDAO.CustomerName;
                }
            }
            await DataContext.BulkMergeAsync(Dim_CustomerDAOs);

            return true;
        }

        // Tạo bảng dim_country
        private async Task<bool> Build_Dim_Country()
        {
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.CountryCode)).ToListAsync();

            List<Dim_CountryDAO> Dim_CountryDAOs = await DataContext.Dim_Country.ToListAsync();

            foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            {
                Dim_CountryDAO Dim_Country = Dim_CountryDAOs.Where(x => x.CountryCode == Raw_Customer_RepDAO.CountryCode).FirstOrDefault();

                if (Dim_Country == null)
                {
                    Dim_Country = new Dim_CountryDAO
                    {
                        CountryCode = Raw_Customer_RepDAO.CountryCode,
                        CountryName = Raw_Customer_RepDAO.CountryName,
                    };
                    Dim_CountryDAOs.Add(Dim_Country);
                }
                else
                {
                    Dim_Country.CountryName = Raw_Customer_RepDAO.CountryName;
                }
            }
            await DataContext.BulkMergeAsync(Dim_CountryDAOs);

            return true;
        }

        // Tạo bảng dim_county
        private async Task<bool> Build_Dim_County()
        {
            List<Raw_Customer_RepDAO> Raw_Customer_RepDAOs = await DataContext.Raw_Customer_Rep
                .Where(x => !string.IsNullOrEmpty(x.CountyCode)).ToListAsync();

            List<Dim_CountyDAO> Dim_CountyDAOs = await DataContext.Dim_County.ToListAsync();

            foreach (var Raw_Customer_RepDAO in Raw_Customer_RepDAOs)
            {
                Dim_CountyDAO Dim_County = Dim_CountyDAOs.Where(x => x.CountyCode == Raw_Customer_RepDAO.CountyCode).FirstOrDefault();

                if (Dim_County == null)
                {
                    Dim_County = new Dim_CountyDAO
                    {
                        CountyCode = Raw_Customer_RepDAO.CountyCode,
                        CountyName = Raw_Customer_RepDAO.CountyName,
                    };
                    Dim_CountyDAOs.Add(Dim_County);
                }
                else
                {
                    Dim_County.CountyName = Raw_Customer_RepDAO.CountyName;
                }
            }
            await DataContext.BulkMergeAsync(Dim_CountyDAOs);

            return true;
        }
        
        // Tạo bảng dim_sale_branch
        private async Task<bool> Build_Dim_Sale_Branch()
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
        private async Task<bool> Build_Dim_Sale_Channel()
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
        public async Task<bool> Build_Dim_Sale_Room()
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
        private async Task<bool> Build_Dim_Unit_Mapping()
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
