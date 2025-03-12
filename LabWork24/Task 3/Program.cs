class Program
{
    static int number = 0;
    static Mutex objectMutex = new();

    static void Main()
    {
        Thread threadFirst = new Thread(IncrementCounter);
        Thread threadSecond = new Thread(IncrementCounter);

        threadFirst.Start();
        threadSecond.Start();

        threadFirst.Join();
        threadSecond.Join();

        Console.WriteLine($"Финальное значение: {number}");
    }

    static void IncrementCounter()
    {
        objectMutex.WaitOne();
        number = 1;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {number}");
            number++;
            Thread.Sleep(100);
        }
        objectMutex.ReleaseMutex();
    }
}