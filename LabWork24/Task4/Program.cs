class Program
{
    static string commonVar = ""; //для обмена данными
    static object objectLock = new object();

    static void Main()
    {
        Thread thread = new Thread(MyThread);
        thread.Start();

        while (true)
        {
            Console.WriteLine("Введите текст(для выхода введите 'x'): ");
            string input = Console.ReadLine();

            lock (objectLock) 
            {
                commonVar = input;
            }

            if (input == "x") break;
        }

        thread.Join();
        Console.WriteLine("Основной поток завершён");
    }

    static void MyThread()
    {
        while (true) 
        {
            string localCopy = commonVar;

            lock (objectLock) 
            {
                localCopy = commonVar;
            }

            if (localCopy == "x") break;

            if (!string.IsNullOrEmpty(localCopy))
            {
                Console.WriteLine($"MyThread получил сообщение: {localCopy}");
            }

            Thread.Sleep(300);
        }
        Console.WriteLine("Завершение программы");
    }
}
   