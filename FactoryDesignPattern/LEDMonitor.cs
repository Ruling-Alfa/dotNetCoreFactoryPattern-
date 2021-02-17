using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class LEDMonitor : IMonitor
    {
        private readonly string _monitorType;
        private Decimal _cost;
        private string _resolution;

        public LEDMonitor(Decimal cost, string resolution)
        {
            _cost = cost;
            _resolution = resolution;
            _monitorType = "LED";
        }

        public override string MonitorType
        {
            get
            {
                return _monitorType;
            }
        }

        public override Decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public override string Resolution
        {
            get
            {
                return _resolution;
            }
            set
            {
                _resolution = value;
            }
        }

    }
}
