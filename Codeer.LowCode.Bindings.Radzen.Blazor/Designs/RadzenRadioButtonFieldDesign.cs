using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenRadioButtonFieldDesign : RadioButtonFieldDesign
    {
        public RadzenRadioButtonFieldDesign() => TypeFullName = typeof(RadzenRadioButtonFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenRadioButtonFieldComponent).FullName!;
    }
}
