using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat pr = new Prostokat(5.6, 7);
            Console.WriteLine(pr.opis());
            Console.WriteLine(pr.policz_pole());
            Console.WriteLine(pr.policz_obw());

            Trapez trp = new Trapez(4.4,5,6.7);
            Console.WriteLine(trp.opis());
            Console.WriteLine(trp.policz_pole()); 
            //Console.WriteLine(trp.policz_obw());


            Kolo kl = new Kolo(5.5);
            Console.WriteLine(kl.opis());
            Console.WriteLine(kl.policz_pole());
            //Console.WriteLine(kl.policz_obw());

            Console.ReadLine();
        }
    }
}
