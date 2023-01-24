using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsComputer
{
    internal class DelegateOnBoardComputerEvent
    {
        public delegate void CarsComputerHandler(string info);

        public event CarsComputerHandler CarsComputerEventLog;
        public void LogProcess()
        {
            string information = "OK";
            CarComputers oc = new CarComputers(23,1011);

            int t = oc.GetTemperature();
            int p = oc.GetPressure();

            if (t>120 || p > 2500)
            {
                information = "Dokonaj przeglądu, bo może grozić awarią!";
            }

            OnCarsComputerEventLog("zapisywanie informacji: \n");
            OnCarsComputerEventLog($"temperatura: {t}, ciśnienie: {p} \n");
            OnCarsComputerEventLog($"informacja: {information} \n");
            
        }

        public void OnCarsComputerEventLog(string information)
        {
            if (CarsComputerEventLog != null) { CarsComputerEventLog(information)};
        }
    }
}
