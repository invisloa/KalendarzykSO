using AsyncAwaitBestPractices;
using Microsoft.Extensions.Logging;
using TheKalendarzyk.Services;

namespace KalendarzykSO
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            Factory.InitializeEventRepository().SafeFireAndForget();
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

            return builder.Build();
        }
    }
}
