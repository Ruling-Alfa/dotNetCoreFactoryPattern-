using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class CRTFactory : ICRTFactory
    {
        public IMonitor GetMonitor(IMonitor inputs)
        {
            return new CRTMonitor(inputs.Cost, inputs.Resolution);
        }

    }

    public interface ICRTFactory : IMonitorFactory { }
}
