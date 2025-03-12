Console.WriteLine("Введите имя файла: ");
string fileName = Console.ReadLine();

if (File.Exists(fileName))
{
    Console.WriteLine("Файл открыт на дозапись");
}
else
{
    Console.WriteLine("Файл с указанным имененм не существует!");
}

try
{
    //открытие файла на дозапись
    using (StreamWriter writer = new StreamWriter(fileName, append: true)) // создание объекта для записи в файл, append: true - данные дозаписаны в конец файла,
                                                                           // а не перезапись всего файла
    {
        Console.WriteLine("Введите строки. Введите 'end' для завершения: ");

        //выход из цикла если введено end 
        string input; 
        while ((input = Console.ReadLine()) != "end") // сохраняет строку в переменную input
        {
            writer.WriteLine(input);
        }
    }
    Console.WriteLine("Дозапись завершена!");
}
catch (Exception ex) 
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.ReadKey();