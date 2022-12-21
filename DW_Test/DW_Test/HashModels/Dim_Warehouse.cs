using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Dim_Warehouse
    {
        public long WarehouseId { get; set; }
        public string WhsCode { get; set; }
        public string Location { get; set; }
        public string WhsBranchName { get; set; }
        public string WarehouseLevel1Name { get; set; }
        public string WarehouseLevel2Name { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = WhsCode;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = Location + "_" + WhsBranchName + "_" +
                    WarehouseLevel1Name + "_" +
                    WarehouseLevel2Name;

            return Value.GetHashCode().ToString();
        }

        public Dim_Warehouse(DWEModels.Dim_WarehouseDAO remote)
        {
            WarehouseId = remote.WarehouseId;
            WhsCode = remote.WhsCode;
            Location = remote.Location;
            WhsBranchName = remote.WhsBranchName;
            WarehouseLevel1Name = remote.WarehouseLevel1Name;
            WarehouseLevel2Name = remote.WarehouseLevel2Name;
            GetKey();
            GetValue();
        }

        public Dim_Warehouse(Models.Dim_WarehouseDAO remote)
        {
            WarehouseId = remote.WarehouseId;
            WhsCode = remote.WhsCode;
            Location = remote.Location;
            WhsBranchName = remote.WhsBranchName;
            WarehouseLevel1Name = remote.WarehouseLevel1Name;
            WarehouseLevel2Name = remote.WarehouseLevel2Name;
            GetKey();
            GetValue();
        }
    }
}
