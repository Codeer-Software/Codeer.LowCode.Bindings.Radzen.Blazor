using Codeer.LowCode.Bindings.Radzen.Blazor.Designs;
using Radzen;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Installer
{
    public static class RadzenLoader
    {
        public static void LoadAssemblies()
        {
            typeof(Variant).ToString();
            typeof(RadzenTextFieldDesign).ToString();
        }
    }
}
