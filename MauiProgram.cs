using CommunityToolkit.Maui;
using MauiExpander.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiExpander
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<ExpanderViewModel>();

            builder.Services.AddTransient<ExpanderPage>();
            return builder.Build();
        }
    }
}
