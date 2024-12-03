using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using The49.Maui.BottomSheet;

namespace Aleksa_Subasic_98_20_BookStore
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitCore()
                .UseBottomSheet()
                .ConfigureFonts(fonts =>
                {
                    //fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    //fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Inter_18pt-Thin.ttf", "Inter-Thin");
                    fonts.AddFont("Inter_18pt-ExtraLight.ttf", "Inter-ExtraLight");
                    fonts.AddFont("Inter_18pt-Light.ttf", "Inter-Light");
                    fonts.AddFont("Inter_18pt-Regular.ttf", "Inter-Regular");
                    fonts.AddFont("Inter_18pt-Medium.ttf", "Inter-Medium");
                    fonts.AddFont("Inter_18pt-SemiBold.ttf", "Inter-SemiBold");
                    fonts.AddFont("Inter_18pt-Bold.ttf", "Inter-Bold");
                    fonts.AddFont("Inter_18pt-Black.ttf", "Inter-Black");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
