using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public interface IMonitorFactory
    {
        public IMonitor GetMonitor(IMonitor monitor);
    }
}
