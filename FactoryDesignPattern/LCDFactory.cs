using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class LCDFactory : ILCDFactory
    {
        public  IMonitor GetMonitor(IMonitor inputs)
        {
            return new LCDMonitor(inputs.Cost, inputs.Resolution);
        }

    }

    public interface ILCDFactory : IMonitorFactory { }
}
