using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("_______________KlasaPierwsza___________________");
            KlasaPierwsza ks = new KlasaPierwsza(6, 3);
            ks.print_ab();
            Console.WriteLine(ks.h);
            Console.WriteLine("_______________KlasaDruga___________________");

            KlasaDruga kd = new KlasaDruga(8, 12, 7);
            kd.print_ab();
            kd.print_abc();
            Console.WriteLine($"wynik = {kd.policz_suma()}");
            kd.h = 200;
            Console.WriteLine(kd.h);

            Console.WriteLine("_______________KlasaTrzecia___________________");
            KlasaTrzecia kt = new KlasaTrzecia(19, 3, 2, 16);
            kt.print_ab();
            kt.print_abc();
            kt.print_abcd();
            Console.WriteLine($"wynik = {kt.policz_suma()}");
            Console.WriteLine(kt.h);
            Console.ReadKey();

        }
    }
}
