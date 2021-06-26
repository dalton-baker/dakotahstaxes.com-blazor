using MudBlazor;

namespace Dakotahstaxes.Com.Shared
{
    public partial class NavMenu
    {
        string _themeButoonToolTip = "Dark Mode";
        MudTheme _currentTheme = new();

        readonly MudTheme _defaultTheme = new()
        {
            Palette = new Palette()
            {
                Black = "#272c34",

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
                TextDisabled = "rgba(255,255,255, 0.2)",
                Primary = "#27272f"
            }
        };

        protected override void OnInitialized()
        {
            _currentTheme = _defaultTheme;
        }

        private void ChangeTheme()
        {
            if (_currentTheme == _defaultTheme)
            {
                _currentTheme = _darkTheme;
                _themeButoonToolTip = "Light Mode";
            }
            else
            {
                _currentTheme = _defaultTheme;
                _themeButoonToolTip = "Dark Mode";
            }
        }
    }
}
