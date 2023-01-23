using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = string.Empty;
            int totalWords = 0;
            int totalWW = 0;
            text = "Witaj nowy użytkowniku! Przeanalizuj koszty abonamentu. Czy coś Ci " +
                "podpowiedzieć? Zapisz się i zapłać.";
            totalWords = text.WordCounter();
            totalWW = text.TotalCharWSpace();

            Console.WriteLine($"liczba wyrazów: {totalWords}");
            Console.WriteLine($"liczba znaków: {totalWW}");

            Console.ReadKey();
        }
    }
}
