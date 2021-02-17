using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class App
    {
        private readonly IServiceProvider _services;
        public App(IServiceProvider services)
        {
            _services = services;
        }
        public void Run()
        {

            Console.Write("what product information is required(LED, LCD, CRT) : ");
            string product = Console.ReadLine();

            IMonitorFactory factory = null;
            IMonitor inputs = null;
            if (product == "LED")
            {
                var fact = (IFactory<ILEDFactory>)_services.GetService(typeof(IFactory<ILEDFactory>));
                inputs = new LEDMonitor(10000, "1968X1360");
                factory = fact.Create();
            }

            else if (product == "LCD")
            {
                var fact = (IFactory<ILCDFactory>)_services.GetService(typeof(IFactory<ILCDFactory>));
                inputs = new LCDMonitor(9000, "1688X1180");
                factory = fact.Create();
            }
            else if (product == "CRT")
            {
                var fact = (IFactory< ICRTFactory>)_services.GetService(typeof(IFactory<ICRTFactory>));
                inputs = new CRTMonitor(9000, "1688X1180");
                factory = fact.Create();
            }
            else
            {
                Console.Write("Invalid Input !!!");
                Console.ReadKey();
                return;
            }

            IMonitor typeofMonitor = factory.GetMonitor(inputs);
            Console.WriteLine(typeofMonitor.ToString());

            Console.ReadKey();



        }

        public static T ConvertValue<T, U>(U value) where U : IConvertible
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }

}
