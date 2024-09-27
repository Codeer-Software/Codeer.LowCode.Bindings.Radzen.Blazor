using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Bindings.Radzen.Blazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenLinkFieldDesign : LinkFieldDesign
    {
        [Designer]
        public RadzenVariant ButtonVariant { get; set; }

        [Designer]
        public RadzenColor ButtonColor { get; set; }

        public RadzenLinkFieldDesign() => TypeFullName = typeof(RadzenLinkFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(RadzenLinkFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(RadzenLinkComponent).FullName!;
    }
}
