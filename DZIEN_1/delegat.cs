using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegat
{
    delegate void ChangeNumber(int n);
    internal class Program
    {
        static int number = 10;
        public static void AddNumber(int a) { 
            number+=a; 
            Console.WriteLine($"Metoda AddNumber zwraca: {number}");
        }

        public static void MultiNumber(int m)
        {
            number *= m;
            Console.WriteLine($"Metoda MultiNumber zwraca: {number}");
        }

        public static void ExpoNumber(int ex)
        {
            number = (int)(2*Math.Exp(number));
            Console.WriteLine($"Metoda ExpoNumber zwraca: {number}");
        }

        public static int GetNumber()
        {
            return number;
        }


        static void Main(string[] args)
        {
            ChangeNumber cn = delegate (int x)
            {
                Console.WriteLine($"Metoda anonimowa: {x}");
            };

            cn(99);

            cn = new ChangeNumber(AddNumber);
            cn(122);

            cn = new ChangeNumber(MultiNumber);
            cn(45);

            Console.WriteLine($"Wynik: {Program.GetNumber()}");

            ChangeNumber dz = delegate (int x)
            {
                Console.WriteLine($"Druga metoda anonimowa: {x / 100}");
            };
            dz(number);
            dz= new ChangeNumber(ExpoNumber);
            dz(number);
            Console.WriteLine($"Wynik: {Program.GetNumber()}");


            Console.ReadKey();
        }
    }
}
