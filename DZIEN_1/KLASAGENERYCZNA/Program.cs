using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaGeneryczna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MojaTablicaGeneryczna<int> intArray = new MojaTablicaGeneryczna<int>(5);
            for(int i=0;i<5;i++)
            {
                intArray.setGenericValue(i, i * 3);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Liczba: {intArray.getGenericArray(i)}");
            }


            MojaTablicaGeneryczna<int> zwArray = new MojaTablicaGeneryczna<int>(4);
            for (int i = 0; i < 4; i++)
            {
                zwArray.setValue(i, i + 3);
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Liczba: {zwArray.getItem(i)}");
            }

            Console.WriteLine("__________tablica znakowa__________");
            MojaTablicaGeneryczna<char> charArray = new MojaTablicaGeneryczna<char>(5);
            for (int i = 0; i < 5; i++)
            {
                charArray.setGenericValue(i, (char)(i+97));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Litera: {charArray.getGenericArray(i)}");
            }

            Console.ReadKey();
        }
    }
}
