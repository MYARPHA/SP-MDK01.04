class Program
{
    static void Main()
    {
        Thread threadFirst = new Thread(() => WriteString(1));
        Thread threadSecond = new Thread(() => WriteString(2));
        Thread threadThird = new Thread(() => WriteString(3));
        Thread threadFour = new Thread(() => WriteString(4));

        threadFirst.Priority = ThreadPriority.BelowNormal;
        threadSecond.Priority = ThreadPriority.Normal;
        threadThird.Priority = ThreadPriority.AboveNormal;
        threadFour.Priority = ThreadPriority.Highest;

        threadFirst.Start();
        threadSecond.Start();
        threadThird.Start();
        threadFour.Start();

        threadFirst.Join();
        threadSecond.Join();
        threadThird.Join();
        threadFour.Join();

        Console.WriteLine("Все потоки завершены!");
    }

    static void WriteString(int n)
    {
        Console.WriteLine($"Поток {n} запущен");

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Поток {n}: {i}");
            Thread.Sleep(300);
        }
        Console.WriteLine($"Поток {n} завершён");
    }
}