namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> mojslownik = new Dictionary<int,string>();
            mojslownik.Add(223, "Jan Kot");
            mojslownik.Add(224, "Anna Kot");
            mojslownik.Add(225, "Henio Kot");
            mojslownik.Add(226, "Maria Kot");
            mojslownik.Add(227, "Benek Kot");
            mojslownik.Add(1001, "Nadia Kot");

            foreach (KeyValuePair<int,string>kvp in mojslownik)
            {
                Console.WriteLine($"Element -> klucz: {kvp.Key}, wartość: {kvp.Value}");
            }

            if (mojslownik.ContainsKey(1001) == true)
                Console.WriteLine("element istnieje!");
        }
    }
}
