namespace DW_Test.Rpc.RD_report.sale_employee
{
    public class SaleEmployee_CustomerRoute : Root
    {
        public const string Default = Rpc + Module + "/sale-employee-customer";

        public const string Import = Default + "/sale-employee-init";

        public const string CustomerInit = Default + "/customer-init"; 

        public const string Transform = Default + "/transform";
    }
}
