namespace DW_Test.Rpc.item_report
{
    public class ItemRoute : Root
    {
        private const string Default = Rpc + Module + "/item-report";

        public const string Init = Default + "/init";

        public const string Transform = Default + "/transform";
    }
}
