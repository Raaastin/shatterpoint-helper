using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace Shatterpoint.Maui
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            // resize content when virtual keyboard is up
            Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
        }
    }
}
