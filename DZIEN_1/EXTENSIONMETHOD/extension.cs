using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static internal class Extension
    {
        public static int WordCounter(this string str) {
            string[] userText= str.Split(new char[] { ' ', '.', '?' }, 
                StringSplitOptions.RemoveEmptyEntries);
            int counter= userText.Length;
            return counter;
        }

        public static int TotalCharWSpace(this string str)
        {
            int counter= 0;
            string[] userText = str.Split(' ');
            foreach (var item in userText) {
                counter += item.Length;
             }
            return counter;
        }
    }
}
