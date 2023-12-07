namespace ArrayConfigurationInheritance;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                var appSettings = hostContext.Configuration.GetSection("AppSettings").Get<AppSettings>()!;
                services.AddSingleton(appSettings);
                services.AddHostedService<Worker>();
            });
}