using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa123
{
    public class KlasaPierwsza
    {
        public int a;
        public int b;

        public KlasaPierwsza(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void print_ab()
        {
            Console.WriteLine($"a={a}, b={b}");
        }
    }
}
