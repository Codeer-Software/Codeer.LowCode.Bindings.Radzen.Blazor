using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Bindings.Radzen.Blazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenRadioGroupFieldDesign : RadioGroupFieldDesign
    {
        [Designer]
        public RadzenVariant Variant { get; set; }

        [Designer]
        public RadzenColor Color { get; set; } = RadzenColor.Primary;

        public RadzenRadioGroupFieldDesign() => TypeFullName = typeof(RadzenRadioGroupFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenRadioGroupFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(RadzenRadioGroupComponent).FullName!;
    }
}
