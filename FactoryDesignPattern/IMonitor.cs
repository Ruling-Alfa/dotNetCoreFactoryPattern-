using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public abstract class IMonitor
    {
        public abstract string MonitorType { get; }
        public abstract Decimal Cost { get; set; }
        public abstract string Resolution { get; set; }

        public override string ToString()
        {
            return $"Product: {this.MonitorType}  \r\nCost : {this.Cost} \r\nResolution : {this.Resolution} ";
        }
    }
}
