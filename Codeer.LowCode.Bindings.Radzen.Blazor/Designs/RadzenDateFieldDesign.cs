using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenDateFieldDesign : DateFieldDesign
    {
        public RadzenDateFieldDesign() => TypeFullName = typeof(RadzenDateFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenDateFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(RadzenDateComponent).FullName!;
    }
}
