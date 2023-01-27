using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Collections;




int wynik = (int)Calculate("12*6432");
Console.WriteLine(wynik);

var list = (IEnumerable)Calculate("[1,2,7]+[5,8,9,11]");
foreach(int n in list)Console.Write(n);
int[] a = { 3, 5, 6 };
int[] b = { 22, 1, 8 };

//Console.WriteLine(a+b);
static object Calculate(string expression)
{
    ScriptEngine  engine = Python.CreateEngine();
    return engine.Execute(expression);
}
