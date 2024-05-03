using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Shatterpoint.Lib.Services;
using Shatterpoint.Maui.Services;

namespace Shatterpoint.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddSingleton<UnitDataBaseService>();
            builder.Services.AddSingleton<SelectedUnitsService>();
            builder.Services.AddScoped<NavigationService>();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
