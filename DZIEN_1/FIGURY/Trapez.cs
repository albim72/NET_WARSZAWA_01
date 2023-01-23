using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Trapez : Figura, IFigura
    {
        public double h;
        public Trapez(double a, double b, double h) : base(a, b)
        {
            this.h = h;
        }

        public override string opis()
        {
            return "Figura to trapez";
        }

        public double policz_obw()
        {
            throw new NotImplementedException();
        }

        public double policz_pole()
        {
            return (a+b)*h/2;
        }
    }
}
