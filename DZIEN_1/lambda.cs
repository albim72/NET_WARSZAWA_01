using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcja_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> {1,2,3,4,5,7,9,11,14,56,78,99,101 };   
            List<int> nieparzyste = number.Where(n=>n%2==1).ToList();
            Console.WriteLine("liczby nieparzyste:");
            foreach(var item in nieparzyste)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
