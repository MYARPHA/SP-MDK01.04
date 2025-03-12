class Program
{
    static int number = 0;
    static object objectLock = new object();

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
        for (int i = 0; i < 1000; i++)
        {
            lock (objectLock)
            {
                number++;
            }
        }
    }
}

  