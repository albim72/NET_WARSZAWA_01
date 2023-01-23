using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa123
{
    public class KlasaTrzecia:KlasaDruga
    {
        public int d;

        public KlasaTrzecia(int a, int b, int c, int d) : base(a, b, c)
        {
            this.d = d;
        }

        public void print_abcd()
        {
            Console.WriteLine($"a={a}, b={b}, c={c}, d={d}");
        }

        //metodę przesłaniającą metodę wirtualną oznaczamy modyfikatorem override
        public override int policz_suma()
        {
            return base.policz_suma() + d;
        }
    }
}
