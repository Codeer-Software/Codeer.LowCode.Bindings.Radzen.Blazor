using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenSubmitButtonFieldDesign : SubmitButtonFieldDesign
    {
        [Designer]
        public RadzenVariant Variant { get; set; }

        [Designer]
        public RadzenColor Color { get; set; }

        public RadzenSubmitButtonFieldDesign() => TypeFullName = typeof(RadzenSubmitButtonFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenSubmitButtonFieldComponent).FullName!;
    }
}
