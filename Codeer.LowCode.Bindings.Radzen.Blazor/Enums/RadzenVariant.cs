using System.ComponentModel;
using Radzen;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Enums
{
    public enum RadzenVariant
    {
        Filled,
        Flat,
        Outlined,
        Text,
    }

internal static class RadzenVariantExtension
    {
        public static Variant ToVariant(this RadzenVariant variant) => variant switch
        {
            RadzenVariant.Outlined => Variant.Outlined,
            RadzenVariant.Flat => Variant.Flat,
            RadzenVariant.Filled => Variant.Filled,
            RadzenVariant.Text => Variant.Text,
            _ => throw new InvalidEnumArgumentException()
        };

        public static RadzenVariant ToRadzenVariant(this Variant variant) => variant switch
        {
            Variant.Outlined => RadzenVariant.Outlined,
            Variant.Flat => RadzenVariant.Flat,
            Variant.Filled => RadzenVariant.Filled,
            Variant.Text => RadzenVariant.Text,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}
