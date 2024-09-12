using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenBooleanFieldDesign : BooleanFieldDesign
    {
        [Designer]
        public RadzenVariant Variant { get; set; }
        
        [Designer]
        public RadzenColor Color { get; set; }

        public RadzenBooleanFieldDesign() => TypeFullName = typeof(RadzenBooleanFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenBooleanFieldComponent).FullName!;
    }
}
