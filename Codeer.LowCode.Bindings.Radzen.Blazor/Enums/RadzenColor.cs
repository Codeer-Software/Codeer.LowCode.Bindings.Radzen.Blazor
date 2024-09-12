using System.ComponentModel;
using Radzen;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Enums
{
    public enum RadzenColor
    {
        Primary,
        Secondary,
        Light,
        Base,
        Dark,
        Success,
        Danger,
        Warning,
        Info,
    }

    internal static class RadzenColorExtension
    {
        public static ButtonStyle ToButtonStyle(this RadzenColor color) => color switch
        {
            RadzenColor.Primary => ButtonStyle.Primary,
            RadzenColor.Secondary => ButtonStyle.Secondary,
            RadzenColor.Light => ButtonStyle.Light,
            RadzenColor.Base => ButtonStyle.Base,
            RadzenColor.Dark => ButtonStyle.Dark,
            RadzenColor.Success => ButtonStyle.Success,
            RadzenColor.Danger => ButtonStyle.Danger,
            RadzenColor.Warning => ButtonStyle.Warning,
            RadzenColor.Info => ButtonStyle.Info,
            _ => throw new InvalidEnumArgumentException()
        };

        public static RadzenColor ToRadzenColor(this ButtonStyle color) => color switch
        {
            ButtonStyle.Primary => RadzenColor.Primary,
            ButtonStyle.Secondary => RadzenColor.Secondary,
            ButtonStyle.Light => RadzenColor.Light,
            ButtonStyle.Base => RadzenColor.Base,
            ButtonStyle.Dark => RadzenColor.Dark,
            ButtonStyle.Success => RadzenColor.Success,
            ButtonStyle.Danger => RadzenColor.Danger,
            ButtonStyle.Warning => RadzenColor.Warning,
            ButtonStyle.Info => RadzenColor.Info,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}
