using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DW_Test.Rpc.customer_report
{
    public class CustomerRoute : Root
    {
        private const string Default = Rpc + Module + "/customer-report";

        public const string Init = Default + "/init";

        public const string IncrementalInit = Default + "/incremental-init";

        public const string Transform = Default + "/transform";
    }
}
