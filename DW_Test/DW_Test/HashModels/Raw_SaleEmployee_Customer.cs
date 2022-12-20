using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Raw_SaleEmployee_Customer
    {
        public long Id { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = MaKH + "_" + TenKH;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = MaNV + "_" + TenNV;

            return Value.GetHashCode().ToString();
        }

        public Raw_SaleEmployee_Customer(Raw_SaleEmployee_CustomerDAO remote)
        {
            MaKH = remote.MaKH;
            TenKH = remote.TenKH;
            MaNV = remote.MaNV;
            TenKH = remote.TenKH;
            GetKey();
            GetValue();
        }
    }
}
