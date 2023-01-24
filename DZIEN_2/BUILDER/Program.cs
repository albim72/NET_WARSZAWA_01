namespace Budowniczy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standardowy (minimalny) produkt: ");
            director.BuiltMinimalProduct();
            Console.WriteLine(builder.GetProdukt().ListParts());

            Console.WriteLine("Pełny produkt: ");
            director.BuiltFullFeatureProduct();
            Console.WriteLine(builder.GetProdukt().ListParts());

            Console.WriteLine("Wersja niestandardowa produktu: ");
            builder.BuiltPartA();
            builder.BuiltPartC();
            Console.WriteLine(builder.GetProdukt().ListParts());

        }
    }
}
