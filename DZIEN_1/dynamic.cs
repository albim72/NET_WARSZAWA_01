using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic val1 = "mojedane";
            dynamic val2 = false;
            dynamic val3 = 333;
            dynamic val4 = 12.08765;

            Console.WriteLine($"Wartość: {val1}, Typ: {val1.GetType()}");
            Console.WriteLine($"Wartość: {val2}, Typ: {val2.GetType()}");
            Console.WriteLine($"Wartość: {val3}, Typ: {val3.GetType()}");
            Console.WriteLine($"Wartość: {val4}, Typ: {val4.GetType()}");

            var val12 = "mojedane";
            var val22 = false;
            var val32 = 333;
            var val42 = 12.08765;

            Console.WriteLine($"Wartość: {val12}, Typ: {val12.GetType()}");
            Console.WriteLine($"Wartość: {val22}, Typ: {val22.GetType()}");
            Console.WriteLine($"Wartość: {val32}, Typ: {val32.GetType()}");
            Console.WriteLine($"Wartość: {val42}, Typ: {val42.GetType()}");
            Console.ReadKey();
        }
    }
}
