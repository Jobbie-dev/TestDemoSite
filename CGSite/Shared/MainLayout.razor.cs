using MudBlazor;

namespace CGSite.Shared
{
    public partial class MainLayout
    {
        MudTheme theme = new MudTheme
        {
            Palette = new Palette {
                AppbarBackground = "#000000",
                Background = "#000000",
                TextPrimary = "#FFD600",
                TextSecondary = "FFFFFF",
                DrawerBackground = "000000",
                TableHover = "FFFFFF",
                Info = "FFFFFF",
                Surface = "000000",
                ActionDefault = "f0f0f0",
                Primary = "FFD600"
            }
        };
    }
}