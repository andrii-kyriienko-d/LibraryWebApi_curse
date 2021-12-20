using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LibraryWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureAppConfiguration(config =>
                {
                    config.AddEnvironmentVariables(prefix: "JwtOptions_");
                    config.AddEnvironmentVariables(prefix: "DatabaseOptions_");
                    config.AddEnvironmentVariables(prefix: "Logging_FileLoggerOptions_");
                    config.AddEnvironmentVariables(prefix: "Logging_");
                })
                .ConfigureLogging(logging =>
                {
                    logging.AddDebug();
                    logging.AddConsole();
                });


    }
}
