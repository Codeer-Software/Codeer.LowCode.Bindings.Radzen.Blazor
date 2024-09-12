using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenIdFieldDesign : IdFieldDesign
    {
        public RadzenIdFieldDesign() => TypeFullName = typeof(RadzenIdFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenIdFieldComponent).FullName!;
    }
}
