namespace OOTBMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
			.UseMauiCommunityToolkitMediaElement()
			.UseMauiCommunityToolkit()
			.UseSkiaSharp()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<LottieViewModel>();

		builder.Services.AddSingleton<LottiePage>();

		builder.Services.AddSingleton<LocalizationViewModel>();

		builder.Services.AddSingleton<LocalizationPage>();

		builder.Services.AddSingleton<SampleViewModel>();

		builder.Services.AddSingleton<SamplePage>();

		builder.Services.AddSingleton<WebViewViewModel>();

		builder.Services.AddSingleton<WebViewPage>();

		builder.Services.AddSingleton<MediaElementViewModel>();

		builder.Services.AddSingleton<MediaElementPage>();

		builder.Services.AddSingleton<MapViewModel>();

		builder.Services.AddSingleton<MapPage>();

		builder.Services.AddSingleton<DrawingViewModel>();

		builder.Services.AddSingleton<DrawingPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDetailViewModel>();
		builder.Services.AddTransient<ListDetailDetailPage>();

		builder.Services.AddSingleton<ListDetailViewModel>();

		builder.Services.AddSingleton<ListDetailPage>();

		builder.Services.AddSingleton<BlankViewModel>();

		builder.Services.AddSingleton<BlankPage>();

		return builder.Build();
	}
}
