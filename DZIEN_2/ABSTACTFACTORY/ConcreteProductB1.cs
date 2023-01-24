using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjna
{
    internal class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsfulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"wynik współpracy B1 z {result}";
        }

        public string UsefulFunctionB()
        {
            return "wynik tworzenia produktu B1";
        }
    }
}
