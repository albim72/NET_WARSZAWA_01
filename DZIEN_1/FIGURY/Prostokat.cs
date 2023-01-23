using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    internal class Prostokat : Figura, IFigura
    {
        public Prostokat(double a, double b) : base(a, b)
        {
        }

        public override string opis()
        {
            return "Figura to prostokąt";
        }

        public double policz_obw()
        {
            return 2*(a+b);
        }

        public double policz_pole()
        {
            return a*b;
        }
    }
}
