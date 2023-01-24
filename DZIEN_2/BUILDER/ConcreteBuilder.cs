using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budowniczy
{
    public class ConcreteBuilder : IBuilder
    {
        private Produkt _produkt = new Produkt();
        public void Reset()
        {
            this._produkt = new Produkt();
        }

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void BuiltPartA()
        {
            this._produkt.Add("część A1");
        }

        public void BuiltPartB()
        {
            this._produkt.Add("część B1");
        }

        public void BuiltPartC()
        {
            this._produkt.Add("część C1");
        }

        public Produkt GetProdukt()
        {
            Produkt result = this._produkt;
            this.Reset();
            return result;
        }
    }
}
