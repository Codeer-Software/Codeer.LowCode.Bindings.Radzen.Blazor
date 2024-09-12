using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenPasswordFieldDesign : PasswordFieldDesign
    {
        public RadzenPasswordFieldDesign() => TypeFullName = typeof(RadzenPasswordFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenPasswordFieldComponent).FullName!;
    }
}
