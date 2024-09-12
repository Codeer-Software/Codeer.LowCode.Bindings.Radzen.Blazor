using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenDateTimeFieldDesign : DateTimeFieldDesign
    {
        public RadzenDateTimeFieldDesign() => TypeFullName = typeof(RadzenDateTimeFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenDateTimeFieldComponent).FullName!;
    }
}
