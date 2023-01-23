using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Kolo : Figura, IFigura
    {
        public Kolo(double a) : base(a)
        {
        }

        public override string opis()
        {
            return "Figura to koło";
        }

        public double policz_obw()
        {
            return Math.PI*Math.Pow(a,2);
        }

        public double policz_pole()
        {
            throw new NotImplementedException();
        }
    }
}
