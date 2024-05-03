
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Shatterpoint.Maui.Services;

namespace Shatterpoint.Maui
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        public App(NavigationService navigationService)
        {
            InitializeComponent();

            MainPage = new MainPage(navigationService);

            // resize content when virtual keyboard is up
            Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
        }
    }
}
