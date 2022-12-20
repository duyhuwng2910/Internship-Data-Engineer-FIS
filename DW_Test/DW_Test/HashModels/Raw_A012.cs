using System;

namespace DW_Test.HashModels
{
    public partial class Raw_A012
    {
        public long Id { get; set; }
        public string U_IGroupName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string P0000_GiaCoSo { get; set; }
        public string P0001_GiaXuatChoChiNhanh { get; set; }
        public string P0002_Price_Level1 { get; set; }
        public string P0003_GiaC1MN { get; set; }
        public string P0004_GiaC2MN { get; set; }
        public string P0005_GiaXuatCPC { get; set; }
        public string P0006_GiaXK { get; set; }
        public string P0007_GiaKenhSTMB { get; set; }
        public string P0008_GiaKenhSTMN { get; set; }
        public string P0009_GiaMegaEB { get; set; }
        public string P0010_GiaTMDT { get; set; }
        public string P0011_GiaBanLeTruCoChe { get; set; }
        public string P0012_GiaNoiBo { get; set; }
        public string P0013_GiaCBCNV { get; set; }
        public string P0014_GiaBNGiaLe { get; set; }
        public string P0015_GiaBNTruCoChe { get; set; }
        public string P0016_GiaTheoDonHang { get; set; }
        public string P0017_GiaCoSoGLP { get; set; }
        public string P0018_GiaLeNiemYet { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = U_IGroupName + "_" + ItemCode + "_" + ItemName;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = P0000_GiaCoSo + "_" +
                    P0001_GiaXuatChoChiNhanh + "_" +
                    P0002_Price_Level1 + "_" +
                    P0003_GiaC1MN + "_" +
                    P0004_GiaC2MN + "_" +
                    P0005_GiaXuatCPC + "_" +
                    P0006_GiaXK + "_" +
                    P0007_GiaKenhSTMB + "_" +
                    P0008_GiaKenhSTMN + "_" +
                    P0009_GiaMegaEB + "_" +
                    P0010_GiaTMDT + "_" +
                    P0011_GiaBanLeTruCoChe + "_" +
                    P0012_GiaNoiBo + "_" +
                    P0013_GiaCBCNV + "_" +
                    P0014_GiaBNGiaLe + "_" +
                    P0015_GiaBNTruCoChe + "_" +
                    P0016_GiaTheoDonHang + "_" +
                    P0017_GiaCoSoGLP + "_" +
                    P0018_GiaLeNiemYet;

            return Value.GetHashCode().ToString();
        }

        public Raw_A012(DWEModels.Raw_A012DAO remote)
        {
            Id = remote.Id;
            U_IGroupName = remote.U_IGroupName;
            ItemCode = remote.ItemCode;
            ItemName = remote.ItemName;
            P0000_GiaCoSo = remote.P0000_GiaCoSo;
            P0001_GiaXuatChoChiNhanh = remote.P0001_GiaXuatChoChiNhanh;
            P0002_Price_Level1 = remote.P0002_Price_Level1;
            P0003_GiaC1MN = remote.P0003_GiaC1MN;
            P0004_GiaC2MN = remote.P0004_GiaC2MN;
            P0005_GiaXuatCPC = remote.P0005_GiaXuatCPC;
            P0006_GiaXK = remote.P0006_GiaXK;
            P0007_GiaKenhSTMB = remote.P0007_GiaKenhSTMB;
            P0008_GiaKenhSTMN = remote.P0008_GiaKenhSTMN;
            P0009_GiaMegaEB = remote.P0009_GiaMegaEB;
            P0010_GiaTMDT = remote.P0010_GiaTMDT;
            P0011_GiaBanLeTruCoChe = remote.P0011_GiaBanLeTruCoChe;
            P0012_GiaNoiBo = remote.P0012_GiaNoiBo;
            P0013_GiaCBCNV = remote.P0013_GiaCBCNV;
            P0014_GiaBNGiaLe = remote.P0014_GiaBNGiaLe;
            P0015_GiaBNTruCoChe = remote.P0015_GiaBNTruCoChe;
            P0016_GiaTheoDonHang = remote.P0016_GiaTheoDonHang;
            P0017_GiaCoSoGLP = remote.P0017_GiaCoSoGLP;
            P0018_GiaLeNiemYet = remote.P0018_GiaLeNiemYet;
            GetKey();
            GetValue();
        }

        public Raw_A012(Models.Raw_A012DAO remote)
        {
            Id = remote.Id;
            U_IGroupName = remote.U_IGroupName;
            ItemCode = remote.ItemCode;
            ItemName = remote.ItemName;
            P0000_GiaCoSo = remote.P0000_GiaCoSo;
            P0001_GiaXuatChoChiNhanh = remote.P0001_GiaXuatChoChiNhanh;
            P0002_Price_Level1 = remote.P0002_Price_Level1;
            P0003_GiaC1MN = remote.P0003_GiaC1MN;
            P0004_GiaC2MN = remote.P0004_GiaC2MN;
            P0005_GiaXuatCPC = remote.P0005_GiaXuatCPC;
            P0006_GiaXK = remote.P0006_GiaXK;
            P0007_GiaKenhSTMB = remote.P0007_GiaKenhSTMB;
            P0008_GiaKenhSTMN = remote.P0008_GiaKenhSTMN;
            P0009_GiaMegaEB = remote.P0009_GiaMegaEB;
            P0010_GiaTMDT = remote.P0010_GiaTMDT;
            P0011_GiaBanLeTruCoChe = remote.P0011_GiaBanLeTruCoChe;
            P0012_GiaNoiBo = remote.P0012_GiaNoiBo;
            P0013_GiaCBCNV = remote.P0013_GiaCBCNV;
            P0014_GiaBNGiaLe = remote.P0014_GiaBNGiaLe;
            P0015_GiaBNTruCoChe = remote.P0015_GiaBNTruCoChe;
            P0016_GiaTheoDonHang = remote.P0016_GiaTheoDonHang;
            P0017_GiaCoSoGLP = remote.P0017_GiaCoSoGLP;
            P0018_GiaLeNiemYet = remote.P0018_GiaLeNiemYet;
            GetKey();
            GetValue();
        }
    }
}
