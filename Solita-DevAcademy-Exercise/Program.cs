using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Solita_DevAcademy_Exercise;

namespace Solita_DevAcademy_Exrercise {
    public class Program {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}