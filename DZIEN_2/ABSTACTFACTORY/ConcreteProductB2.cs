using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjna
{
    public class ConcreteProductB2:IAbstractProductB
    {
        public string AnotherUsfulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"wynik współpracy B2 z {result}";
        }

        public string UsefulFunctionB()
        {
            return "wynik tworzenia produktu B2";
        }
    }
}
