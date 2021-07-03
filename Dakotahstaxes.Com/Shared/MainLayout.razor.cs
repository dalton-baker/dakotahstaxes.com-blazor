using MudBlazor;

namespace Dakotahstaxes.Com.Shared
{
    public partial class MainLayout
    {
        bool open = true;

        MudTheme _currentTheme = new();

        readonly MudTheme _defaultTheme = new()
        {
            Palette = new Palette()
            {
                //Black = "#272c34",
                AppbarBackground = "#355438",
                AppbarText = "#FFFFFF",

                TextPrimary = "rgba(0, 60, 0, 0.70)",
                TextSecondary = "rgba(0, 60, 0, 0.50)",

                DrawerText = "rgba(0, 60, 0, 0.70)",
                DrawerIcon = "rgba(0, 60, 0, 0.70)",

                Background = "#F1F1E8",

                Primary = "#00AA00",

                Info = "#00AA00",
            }

        };

        readonly MudTheme _darkTheme = new()
        {
            Palette = new Palette()
            {
                Black = "#27272f",

                Background = "#32333d",
                BackgroundGrey = "#27272f",

                Surface = "#373740",

                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",

                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "rgba(255,255,255, 0.50)",

                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",

                Divider = "rgba(255,255,255, 0.12)",
                DividerLight = "rgba(255,255,255, 0.06)",

                TableLines = "rgba(255,255,255, 0.12)",

                LinesDefault = "rgba(255,255,255, 0.12)",
                LinesInputs = "rgba(255,255,255, 0.3)",

                TextDisabled = "rgba(255,255,255, 0.2)"
            }
        };

        protected override void OnInitialized()
        {
            _currentTheme = _defaultTheme;
        }
    }
}
