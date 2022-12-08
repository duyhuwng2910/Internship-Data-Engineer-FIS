using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Dim_UnitMapping
    {
        public long Unit_MappingId { get; set; }
        public long? CountryId { get; set; }
        public long? CountyId { get; set; }
        public long? CustomerId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? SaleChannelId { get; set; }
        public long? SaleRoomId { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = CustomerId.ToString();

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = CountryId.ToString() + "_" +
                    CountyId.ToString() + "_" +
                    SaleBranchId.ToString() + "_" +
                    SaleChannelId.ToString() + "_" +
                    SaleRoomId;

            return Value.GetHashCode().ToString();
        }

        public Dim_UnitMapping(Dim_UnitMappingDAO Local)
        {
            Unit_MappingId = Local.Unit_MappingId;
            CountryId = Local.CountryId;
            CountyId = Local.CountyId;
            CustomerId = Local.CustomerId;
            SaleBranchId = Local.SaleBranchId;
            SaleChannelId = Local.SaleChannelId;
            SaleRoomId = Local.SaleRoomId;
            GetKey();
            GetValue();
        }
    }
}
