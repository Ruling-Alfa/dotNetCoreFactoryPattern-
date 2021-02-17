using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // create service collection
            var services = new ServiceCollection();
            ConfigureServices(services);

            // create service provider
            var serviceProvider = services.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<App>().Run();

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var environmentName = "Production"; //"";

            // build config
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .Build();

            services.AddSingleton<IConfiguration>(configuration);

            services.AddTransient<App>();
            services.AddSingleton(typeof(IFactory<>), typeof(Factory<>));
            services.AddFactory<ILEDFactory, LEDFactory>();
            services.AddFactory<ILCDFactory, LCDFactory>();
            services.AddFactory<ICRTFactory, CRTFactory>();
        }
    }

}