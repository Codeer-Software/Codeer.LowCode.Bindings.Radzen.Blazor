using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    [DisableBulkDataUpdate]
    public class RadzenFileFieldDesign : FileFieldDesign
    {
        public RadzenFileFieldDesign() => TypeFullName = typeof(RadzenFileFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenFileFieldComponent).FullName!;
    }
}
