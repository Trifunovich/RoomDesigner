using Microsoft.Extensions.Logging;

namespace RoomDesigner.Maui;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Add any additional configuration or services here
        // For example, you can add dependency injection services:
        // builder.Services.AddSingleton<IMyService, MyService>();

        return builder.Build();
    }
}
