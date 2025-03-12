using System.IO;

Console.WriteLine("lab11");

// task 1
Console.WriteLine("Введите имя файла: ");
string fileName = Console.ReadLine();

if (File.Exists(fileName))
{
    try
    {
        string fileContent = File.ReadAllText(fileName);
        Console.WriteLine("Содержимое файла: ");
        Console.WriteLine(fileContent);
    }
    catch (Exception ex) 
    { 
        Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
    }
}
else
{
    Console.WriteLine("Файл с указанным именем не существует!");
}

Console.ReadKey();