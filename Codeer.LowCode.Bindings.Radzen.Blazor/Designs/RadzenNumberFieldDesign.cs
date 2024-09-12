using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenNumberFieldDesign : NumberFieldDesign
    {
        public RadzenNumberFieldDesign() => TypeFullName = typeof(RadzenNumberFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenNumberFieldComponent).FullName!;
    }
}
