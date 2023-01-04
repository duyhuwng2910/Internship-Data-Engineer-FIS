namespace DW_Test.Rpc.product_group
{
    public class Product_GroupRoute : Root
    {
        private const string Default = Rpc + Module + "/product-group-report";

        public const string Init = Default + "/init";

        public const string Transform = Default + "/transform";
    }
}
