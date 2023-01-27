namespace signal_reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var signal = new ManualResetEvent(false);

            new Thread(() =>
            {
                Console.Write("Oczekiwanie na sygnał...");
                signal.WaitOne();
                signal.Dispose();
                Console.WriteLine("Otrzymano sygnał!");
            }).Start();

            Thread.Sleep(2000);
            signal.Set();



            Thread t = new Thread(WriteY);
            t.Start();
            for (int i = 0;i < 100; i++) { Console.Write("x"); }

            Console.ReadKey();

        }

        static void WriteY()
        {
            for(int i=0;i<100;i++)
            {
                Console.Write("y");
            }
        }
    }
}
