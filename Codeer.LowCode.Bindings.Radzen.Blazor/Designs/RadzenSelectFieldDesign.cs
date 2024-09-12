using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenSelectFieldDesign : SelectFieldDesign
    {
        public RadzenSelectFieldDesign() => TypeFullName = typeof(RadzenSelectFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenSelectFieldComponent).FullName!;
    }
}
