using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjna
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: testowanie klienta kodu dla pierwszej fabryki: ");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: testowanie klienta kodu dla drugiej fabryki: ");
            ClientMethod(new ConcreteFactory2());
            Console.WriteLine();
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsfulFunctionB(productA));
        }
    }
}
