using Processlibrary;
using System.Diagnostics;

// Task 1
Console.WriteLine("Вывести все запущенные процессы: ");
TaskList.ShowAllprocess();

// Task 2
Console.WriteLine("\nПроцесс с наибольшим ID: ");
var maxId = TaskList.GetProcessWithMaxId();
if (maxId != null)
{
    Console.WriteLine($"Id: {maxId.Id}, Name: {maxId.ProcessName}");
}

// Task 3
Console.Write("\nВведите имя процесса: ");
string processName = Console.ReadLine();
TaskList.ShowProcessByName(processName);

// Task 4
Console.WriteLine("\nВведите путь к программе: ");
string processPath = Console.ReadLine();
TaskList.StartNewProcess(processPath);

Console.ReadKey();