namespace asyncanswer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Go();
            Console.ReadLine();
        }
        
        static async Task Go()
        {
            await PrintAswerToLife();
            Console.WriteLine("Zadanie wykonano!");
        }

        static async Task PrintAswerToLife()
        {
            int answer = await GetAswerToLife();
            Console.WriteLine(answer);
            Console.WriteLine("Zakończono!");
        }

        static async Task<int> GetAswerToLife()
            {
             await Task.Delay(5000);
            int answer = 21 * 4;
            return answer;
            }
    }
}
