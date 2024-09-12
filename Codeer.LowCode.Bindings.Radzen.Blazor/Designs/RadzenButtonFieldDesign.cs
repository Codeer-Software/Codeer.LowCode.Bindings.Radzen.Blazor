using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    [IgnoreBaseProperties(nameof(Variant))]
    public class RadzenButtonFieldDesign: ButtonFieldDesign
    {
        public RadzenButtonFieldDesign() => TypeFullName = typeof(RadzenButtonFieldDesign).FullName!;

        [Designer(DisplayName = "Variant")]
        public RadzenVariant RadzenVariant { get; set; }

        [Designer]
        public RadzenColor Color { get; set; }

        public override string GetWebComponentTypeFullName() => typeof(RadzenButtonFieldComponent).FullName!;
    }
}
