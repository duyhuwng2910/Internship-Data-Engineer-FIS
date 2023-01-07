namespace DW_Test.Rpc.actual_report
{
    public class ActualRoute : Root
    {
        private const string Default = Rpc + Module + "/actual-report";

        public const string Init = Default + "/init";

        public const string IncrementalInit = Default + "/incremental-init";

        public const string Transform = Default + "/transform";

        public const string TransformByDate = Default + "/transform-by-date";
    }
}
