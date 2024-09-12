using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenTimeFieldDesign : TimeFieldDesign
    {
        public RadzenTimeFieldDesign() => TypeFullName = typeof(RadzenTimeFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenTimeFieldComponent).FullName!;
    }
}
