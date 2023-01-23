using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa123
{
    public class KlasaDruga : KlasaPierwsza
    {
        public int c;
        public KlasaDruga(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }

        public void print_abc()
        {
            Console.WriteLine($"a={a}, b={b}, c={c}");
        }
        //metoda wirtulana definiuje możliwość przesłaniania w klasie potomnej
        public virtual int policz_suma()
        {
            return a+b+c;
        }
    }
}
