using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class LEDFactory : ILEDFactory
    {

        public IMonitor GetMonitor(IMonitor monitor)
        {
            return new LEDMonitor(monitor.Cost, monitor.Resolution);
        }

    }
    public interface ILEDFactory : IMonitorFactory { }
}
