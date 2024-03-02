using Microsoft.Extensions.Logging;

namespace FakerApiTest;

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

        // ViewModels
        builder.Services.AddSingleton<CompanyViewModel>();
        builder.Services.AddTransient<CompanyDetailsViewModel>();
        
        // Views
        builder.Services.AddSingleton<CompanyView>();
        builder.Services.AddTransient<CompanyDetails>();
        
        return builder.Build();
    }
}