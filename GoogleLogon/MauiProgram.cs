using GoogleLogon.Pages;
using GoogleLogon.ViewModels;
using Microsoft.Extensions.Logging;

namespace GoogleLogon
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<RegistrationViewModel>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<SignUp>();
            builder.Services.AddTransient<SignIn>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
