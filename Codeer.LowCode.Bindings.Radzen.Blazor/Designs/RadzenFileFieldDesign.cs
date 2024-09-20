using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Bindings.Radzen.Blazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    [DisableBulkDataUpdate]
    public class RadzenFileFieldDesign : FileFieldDesign
    {
        [Designer]
        public RadzenVariant Variant { get; set; }

        [Designer]
        public RadzenColor Color { get; set; }

        public RadzenFileFieldDesign() => TypeFullName = typeof(RadzenFileFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenFileFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(RadzenFileComponent).FullName!;
    }
}
