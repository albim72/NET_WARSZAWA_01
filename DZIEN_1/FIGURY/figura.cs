using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    abstract class Figura
    {
        protected double a;
        protected double b;

        protected Figura(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        abstract public String opis();

        public String info()
        {
            return "to jest metoda niebastrakcyjna klasy abstrakcyjnej!";
        }
    }
}
