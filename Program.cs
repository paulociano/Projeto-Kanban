using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProjetoKanban.Dados;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjetoKanban
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            CreatDbIfNotExists(host);

            var demoMode = host.Services.GetRequiredService<IConfiguration>().GetValue<bool>("DemoMode");
            if (demoMode)
            {
                Task.Run(async () =>
                {
                    await Task.Delay(1500);
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "http://localhost:5050",
                            UseShellExecute = true
                        });
                    }
                    catch { }
                });
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://localhost:5050");
                });

        public static void CreatDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<Context>();
                    DbInitialize.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Um erro ocorreu ao tentar criar o banco de dados");
                }
            }
        }
    }
}
