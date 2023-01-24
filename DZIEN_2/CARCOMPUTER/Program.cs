using CarsComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComputer
{
    internal class Program
    {
        static void DisplayInformation(string Info)
        {
            Console.WriteLine(Info);
        }
        static void Main(string[] args)
        {
            DelegateOnBoardComputerEvent carCompEvent = new DelegateOnBoardComputerEvent();
            carCompEvent.CarsComputerEventLog +=
                new DelegateOnBoardComputerEvent.CarsComputerHandler(DisplayInformation);
            carCompEvent.LogProcess();
            Console.ReadKey();
        }
    }
}
