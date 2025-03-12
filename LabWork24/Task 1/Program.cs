class Program
{
    static void Main()
    {
        // создание потоков
        Thread threadNumbers = new Thread(PrintNumbers);
        Thread threadLetters = new Thread(printLetters);

        // запуск потоков
        threadNumbers.Start();
        threadLetters.Start();

        // ожидание завершения потоков
        threadNumbers.Join();
        threadLetters.Join();

        Console.WriteLine("Работа программы завершена");
    }

    static void PrintNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(200); // задержка 200 милисекунд
        }
    }

    static void printLetters()
    {
        for (char c = 'A'; c <= 'J'; c++)
        {
            Console.WriteLine(c);
            Thread.Sleep(200);
        }
    }
}
