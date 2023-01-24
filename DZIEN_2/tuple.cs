var moja_krotka = Tuple.Create("Jon Bon Jovi", "Metallica", 62354354, true, Tuple.Create(23, 11, 4.66));
Console.WriteLine($"element: {moja_krotka.Item1}");
Console.WriteLine($"element: {moja_krotka.Item2}");
Console.WriteLine($"element: {moja_krotka.Item3}");
Console.WriteLine($"element: {moja_krotka.Item4}");
Console.WriteLine($"element: {moja_krotka.Item5}");
Console.WriteLine($"drugi element wewnętrznej krotki: {moja_krotka.Item5.Item2}");

var mkrotka = Tuple.Create("Marcin", 67, 8.99);
PrintMyTuple(mkrotka);

var skrotka = PrintTuple();
Console.WriteLine(skrotka.Item1);
Console.WriteLine(skrotka.Item2);
Console.WriteLine(skrotka.Item3);


static void PrintMyTuple(Tuple<string,int,double> mytuple)
{
    Console.WriteLine($"Element pierwszy: {mytuple.Item1}");
    Console.WriteLine($"Element drugi: {mytuple.Item2}");
    Console.WriteLine($"Element trzeci: {mytuple.Item3}");
}

static Tuple<string,string,string> PrintTuple()
{
    return Tuple.Create("Wielki", "Maswyny", "Obelisk");
}

