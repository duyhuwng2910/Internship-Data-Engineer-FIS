using DW_Test.DWEModels;
using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Consignment_report
{
    public interface ICurrentProductPriceListService : IServiceScoped
    {
        public Task<bool> Init();
    }
    public class CurrentProductPriceListService : ICurrentProductPriceListService
    {
        private DataContext DataContext;

        private DWEContext DWEContext;

        public CurrentProductPriceListService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        public async Task<bool> Init()
        {
            List<DWEModels.Raw_A012DAO> Raw_A012RemoteDAOs = await DWEContext.Raw_A012.ToListAsync();

            List<Models.Raw_A012DAO> Raw_A012LocalDAOs = await DataContext.Raw_A012.ToListAsync();

            List<Raw_A012> HashRemote = Raw_A012RemoteDAOs.Select(x => new Raw_A012(x)).ToList();

            List<Raw_A012> HashLocal = Raw_A012LocalDAOs.Select(x => new Raw_A012(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Models.Raw_A012DAO> InsertList = new List<Models.Raw_A012DAO>();

            List<Models.Raw_A012DAO> UpdateList = new List<Models.Raw_A012DAO>();

            List<Models.Raw_A012DAO> DeleteList = new List<Models.Raw_A012DAO>();

            int index = 0;

            if (Raw_A012LocalDAOs.Count == 0)
            {
                foreach (var remote in Raw_A012RemoteDAOs)
                {
                    Raw_A012LocalDAOs.Add(new Models.Raw_A012DAO()
                    {
                        U_IGroupName = remote.U_IGroupName,
                        ItemCode = remote.ItemCode,
                        ItemName = remote.ItemName,
                        P0000_GiaCoSo = remote.P0000_GiaCoSo,
                        P0001_GiaXuatChoChiNhanh = remote.P0001_GiaXuatChoChiNhanh,
                        P0002_Price_Level1 = remote.P0002_Price_Level1,
                        P0003_GiaC1MN = remote.P0003_GiaC1MN,
                        P0004_GiaC2MN = remote.P0004_GiaC2MN,
                        P0005_GiaXuatCPC = remote.P0005_GiaXuatCPC,
                        P0006_GiaXK = remote.P0006_GiaXK,
                        P0007_GiaKenhSTMB = remote.P0007_GiaKenhSTMB,
                        P0008_GiaKenhSTMN = remote.P0008_GiaKenhSTMN,
                        P0009_GiaMegaEB = remote.P0009_GiaMegaEB,
                        P0010_GiaTMDT = remote.P0010_GiaTMDT,
                        P0011_GiaBanLeTruCoChe = remote.P0011_GiaBanLeTruCoChe,
                        P0012_GiaNoiBo = remote.P0012_GiaNoiBo,
                        P0013_GiaCBCNV = remote.P0013_GiaCBCNV,
                        P0014_GiaBNGiaLe = remote.P0014_GiaBNGiaLe,
                        P0015_GiaBNTruCoChe = remote.P0015_GiaBNTruCoChe,
                        P0016_GiaTheoDonHang = remote.P0016_GiaTheoDonHang,
                        P0017_GiaCoSoGLP = remote.P0017_GiaCoSoGLP,
                        P0018_GiaLeNiemYet = remote.P0018_GiaLeNiemYet
                    });
                }
                await DataContext.BulkMergeAsync(Raw_A012LocalDAOs);
            }
            else
            {
                for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
                {
                    if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                    {
                        InsertList.Add(new Models.Raw_A012DAO()
                        {
                            U_IGroupName = HashRemote[j].U_IGroupName,
                            ItemCode = HashRemote[j].ItemCode,
                            ItemName = HashRemote[j].ItemName,
                            P0000_GiaCoSo = HashRemote[j].P0000_GiaCoSo,
                            P0001_GiaXuatChoChiNhanh = HashRemote[j].P0001_GiaXuatChoChiNhanh,
                            P0002_Price_Level1 = HashRemote[j].P0002_Price_Level1,
                            P0003_GiaC1MN = HashRemote[j].P0003_GiaC1MN,
                            P0004_GiaC2MN = HashRemote[j].P0004_GiaC2MN,
                            P0005_GiaXuatCPC = HashRemote[j].P0005_GiaXuatCPC,
                            P0006_GiaXK = HashRemote[j].P0006_GiaXK,
                            P0007_GiaKenhSTMB = HashRemote[j].P0007_GiaKenhSTMB,
                            P0008_GiaKenhSTMN = HashRemote[j].P0008_GiaKenhSTMN,
                            P0009_GiaMegaEB = HashRemote[j].P0009_GiaMegaEB,
                            P0010_GiaTMDT = HashRemote[j].P0010_GiaTMDT,
                            P0011_GiaBanLeTruCoChe = HashRemote[j].P0011_GiaBanLeTruCoChe,
                            P0012_GiaNoiBo = HashRemote[j].P0012_GiaNoiBo,
                            P0013_GiaCBCNV = HashRemote[j].P0013_GiaCBCNV,
                            P0014_GiaBNGiaLe = HashRemote[j].P0014_GiaBNGiaLe,
                            P0015_GiaBNTruCoChe = HashRemote[j].P0015_GiaBNTruCoChe,
                            P0016_GiaTheoDonHang = HashRemote[j].P0016_GiaTheoDonHang,
                            P0017_GiaCoSoGLP = HashRemote[j].P0017_GiaCoSoGLP,
                            P0018_GiaLeNiemYet = HashRemote[j].P0018_GiaLeNiemYet
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Models.Raw_A012DAO()
                            {
                                Id = HashLocal[index].Id,
                                U_IGroupName = HashLocal[index].U_IGroupName,
                                ItemCode = HashLocal[index].ItemCode,
                                ItemName = HashLocal[index].ItemName,
                                P0000_GiaCoSo = HashRemote[j].P0000_GiaCoSo,
                                P0001_GiaXuatChoChiNhanh = HashRemote[j].P0001_GiaXuatChoChiNhanh,
                                P0002_Price_Level1 = HashRemote[j].P0002_Price_Level1,
                                P0003_GiaC1MN = HashRemote[j].P0003_GiaC1MN,
                                P0004_GiaC2MN = HashRemote[j].P0004_GiaC2MN,
                                P0005_GiaXuatCPC = HashRemote[j].P0005_GiaXuatCPC,
                                P0006_GiaXK = HashRemote[j].P0006_GiaXK,
                                P0007_GiaKenhSTMB = HashRemote[j].P0007_GiaKenhSTMB,
                                P0008_GiaKenhSTMN = HashRemote[j].P0008_GiaKenhSTMN,
                                P0009_GiaMegaEB = HashRemote[j].P0009_GiaMegaEB,
                                P0010_GiaTMDT = HashRemote[j].P0010_GiaTMDT,
                                P0011_GiaBanLeTruCoChe = HashRemote[j].P0011_GiaBanLeTruCoChe,
                                P0012_GiaNoiBo = HashRemote[j].P0012_GiaNoiBo,
                                P0013_GiaCBCNV = HashRemote[j].P0013_GiaCBCNV,
                                P0014_GiaBNGiaLe = HashRemote[j].P0014_GiaBNGiaLe,
                                P0015_GiaBNTruCoChe = HashRemote[j].P0015_GiaBNTruCoChe,
                                P0016_GiaTheoDonHang = HashRemote[j].P0016_GiaTheoDonHang,
                                P0017_GiaCoSoGLP = HashRemote[j].P0017_GiaCoSoGLP,
                                P0018_GiaLeNiemYet = HashRemote[j].P0018_GiaLeNiemYet
                            });
                        }

                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Models.Raw_A012DAO()
                        {
                            Id = HashLocal[index].Id,
                            U_IGroupName = HashLocal[index].U_IGroupName,
                            ItemCode = HashLocal[index].ItemCode,
                            ItemName = HashLocal[index].ItemName,
                            P0000_GiaCoSo = HashLocal[index].P0000_GiaCoSo,
                            P0001_GiaXuatChoChiNhanh = HashLocal[index].P0001_GiaXuatChoChiNhanh,
                            P0002_Price_Level1 = HashLocal[index].P0002_Price_Level1,
                            P0003_GiaC1MN = HashLocal[index].P0003_GiaC1MN,
                            P0004_GiaC2MN = HashLocal[index].P0004_GiaC2MN,
                            P0005_GiaXuatCPC = HashLocal[index].P0005_GiaXuatCPC,
                            P0006_GiaXK = HashLocal[index].P0006_GiaXK,
                            P0007_GiaKenhSTMB = HashLocal[index].P0007_GiaKenhSTMB,
                            P0008_GiaKenhSTMN = HashLocal[index].P0008_GiaKenhSTMN,
                            P0009_GiaMegaEB = HashLocal[index].P0009_GiaMegaEB,
                            P0010_GiaTMDT = HashLocal[index].P0010_GiaTMDT,
                            P0011_GiaBanLeTruCoChe = HashLocal[index].P0011_GiaBanLeTruCoChe,
                            P0012_GiaNoiBo = HashLocal[index].P0012_GiaNoiBo,
                            P0013_GiaCBCNV = HashLocal[index].P0013_GiaCBCNV,
                            P0014_GiaBNGiaLe = HashLocal[index].P0014_GiaBNGiaLe,
                            P0015_GiaBNTruCoChe = HashLocal[index].P0015_GiaBNTruCoChe,
                            P0016_GiaTheoDonHang = HashLocal[index].P0016_GiaTheoDonHang,
                            P0017_GiaCoSoGLP = HashLocal[index].P0017_GiaCoSoGLP,
                            P0018_GiaLeNiemYet = HashLocal[index].P0018_GiaLeNiemYet
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Models.Raw_A012DAO()
                        {
                            U_IGroupName = HashRemote[index].U_IGroupName,
                            ItemCode = HashRemote[index].ItemCode,
                            ItemName = HashRemote[index].ItemName,
                            P0000_GiaCoSo = HashRemote[index].P0000_GiaCoSo,
                            P0001_GiaXuatChoChiNhanh = HashRemote[index].P0001_GiaXuatChoChiNhanh,
                            P0002_Price_Level1 = HashRemote[index].P0002_Price_Level1,
                            P0003_GiaC1MN = HashRemote[index].P0003_GiaC1MN,
                            P0004_GiaC2MN = HashRemote[index].P0004_GiaC2MN,
                            P0005_GiaXuatCPC = HashRemote[index].P0005_GiaXuatCPC,
                            P0006_GiaXK = HashRemote[index].P0006_GiaXK,
                            P0007_GiaKenhSTMB = HashRemote[index].P0007_GiaKenhSTMB,
                            P0008_GiaKenhSTMN = HashRemote[index].P0008_GiaKenhSTMN,
                            P0009_GiaMegaEB = HashRemote[index].P0009_GiaMegaEB,
                            P0010_GiaTMDT = HashRemote[index].P0010_GiaTMDT,
                            P0011_GiaBanLeTruCoChe = HashRemote[index].P0011_GiaBanLeTruCoChe,
                            P0012_GiaNoiBo = HashRemote[index].P0012_GiaNoiBo,
                            P0013_GiaCBCNV = HashRemote[index].P0013_GiaCBCNV,
                            P0014_GiaBNGiaLe = HashRemote[index].P0014_GiaBNGiaLe,
                            P0015_GiaBNTruCoChe = HashRemote[index].P0015_GiaBNTruCoChe,
                            P0016_GiaTheoDonHang = HashRemote[index].P0016_GiaTheoDonHang,
                            P0017_GiaCoSoGLP = HashRemote[index].P0017_GiaCoSoGLP,
                            P0018_GiaLeNiemYet = HashRemote[index].P0018_GiaLeNiemYet
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Models.Raw_A012DAO()
                        {
                            Id = HashLocal[index].Id,
                            U_IGroupName = HashLocal[index].U_IGroupName,
                            ItemCode = HashLocal[index].ItemCode,
                            ItemName = HashLocal[index].ItemName,
                            P0000_GiaCoSo = HashLocal[index].P0000_GiaCoSo,
                            P0001_GiaXuatChoChiNhanh = HashLocal[index].P0001_GiaXuatChoChiNhanh,
                            P0002_Price_Level1 = HashLocal[index].P0002_Price_Level1,
                            P0003_GiaC1MN = HashLocal[index].P0003_GiaC1MN,
                            P0004_GiaC2MN = HashLocal[index].P0004_GiaC2MN,
                            P0005_GiaXuatCPC = HashLocal[index].P0005_GiaXuatCPC,
                            P0006_GiaXK = HashLocal[index].P0006_GiaXK,
                            P0007_GiaKenhSTMB = HashLocal[index].P0007_GiaKenhSTMB,
                            P0008_GiaKenhSTMN = HashLocal[index].P0008_GiaKenhSTMN,
                            P0009_GiaMegaEB = HashLocal[index].P0009_GiaMegaEB,
                            P0010_GiaTMDT = HashLocal[index].P0010_GiaTMDT,
                            P0011_GiaBanLeTruCoChe = HashLocal[index].P0011_GiaBanLeTruCoChe,
                            P0012_GiaNoiBo = HashLocal[index].P0012_GiaNoiBo,
                            P0013_GiaCBCNV = HashLocal[index].P0013_GiaCBCNV,
                            P0014_GiaBNGiaLe = HashLocal[index].P0014_GiaBNGiaLe,
                            P0015_GiaBNTruCoChe = HashLocal[index].P0015_GiaBNTruCoChe,
                            P0016_GiaTheoDonHang = HashLocal[index].P0016_GiaTheoDonHang,
                            P0017_GiaCoSoGLP = HashLocal[index].P0017_GiaCoSoGLP,
                            P0018_GiaLeNiemYet = HashLocal[index].P0018_GiaLeNiemYet
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
