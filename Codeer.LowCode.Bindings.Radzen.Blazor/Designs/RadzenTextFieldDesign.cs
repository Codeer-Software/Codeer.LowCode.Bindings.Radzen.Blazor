using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenTextFieldDesign : TextFieldDesign
    {
        public RadzenTextFieldDesign() => TypeFullName = typeof(RadzenTextFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenTextFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(RadzenTextComponent).FullName!;
   }
}
