using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComputer
{
    internal class CarsComputer
    {
        private int temperature;
        private int pressure;

        public CarsComputer(int temperature, int pressure)
        {
            this.temperature = temperature;
            this.pressure = pressure;
        }

        public int GetTemperature() { return temperature; }

        public int GetPressure() { return pressure;}
    }
}
