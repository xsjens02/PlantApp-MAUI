using Microsoft.Extensions.Logging;
using PlantAppMAUI.Pages;
using PlantAppMAUI.ViewModels;

namespace PlantAppMAUI;

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

        // Register ViewModels 
        builder.Services.AddTransient<LoginVM>();
        builder.Services.AddTransient<HomeVM>();
        builder.Services.AddTransient<HomeSettingsVM>();
        builder.Services.AddTransient<PlantDisplayVM>();
        builder.Services.AddTransient<PlantCreateVM>();
        builder.Services.AddTransient<PlantSettingsVM>();

        // Register Pages 
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<HomeSettingsPage>();
        builder.Services.AddTransient<PlantDisplayPage>();
        builder.Services.AddTransient<PlantCreatePage>();
        builder.Services.AddTransient<PlantSettingsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
