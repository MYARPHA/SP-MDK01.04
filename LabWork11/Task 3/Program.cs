if (args.Length < 4) //проверка что аргумента 4
{
    Console.WriteLine("Использование: -f <имя файла> -t <искомый текст>");
    return;
}

string fileName = null;
string searchText = null;

for (int i = 0; i < args.Length; i++)
{
    if (args[i] == "-f" && i + 1 < args.Length)
    {
        fileName = args[++i];
    }
    else if (args[i] == "-t" && i + 1 < args.Length)
    {
        searchText = args[++i];
    }
}
if (fileName == null || searchText == null)
{
    Console.WriteLine("ОШИБКА! Не указаны все обязательные параметры");
    return;
}

if (!File.Exists(fileName))
{
    Console.WriteLine($"Файл не существует!");
    return;
}

//поиск строк

bool foundLines = false;
int lineNumber  = 1;

foreach (string line in File.ReadLines(fileName))
{
    if (line.Contains(searchText))
    {
        Console.WriteLine($"Строка: {lineNumber}: {line}");
        foundLines = true;
    }
    lineNumber++;
}

if (!foundLines)
{
    Console.WriteLine("ТЕКСТ НЕ НАЙДЕН!!!!");
}