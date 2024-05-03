using Shatterpoint.Maui.Services;

namespace Shatterpoint.Maui
{
    public partial class MainPage : ContentPage
    {
        public NavigationService NavigationService { get; set; }
        public MainPage(NavigationService navigationService)
        {
            NavigationService = navigationService;
            InitializeComponent();
        }
    }
}
