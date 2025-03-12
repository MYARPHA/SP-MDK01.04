using System.Diagnostics;

namespace Processlibrary
{
    /// <summary>
    /// Класс TaskList содержит набор методов для работы с процессами.
    /// </summary>
    public class TaskList
    {
        /// <summary>
        /// Выводит список всех запущенных процессов.
        /// </summary>
        public static void ShowAllprocess()
        {
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                Console.WriteLine($"Id: {process.Id}, Name: {process.ProcessName}");
            }
        }

        /// <summary>
        /// Находит процесс с наибольшим Id
        /// </summary>
        /// <returns>Объект с наибольшим ID или null, если процессы не найдены.</returns>
        public static Process GetProcessWithMaxId()
        {
            return Process.GetProcesses().OrderByDescending(p => p.Id).FirstOrDefault();
        }

        /// <summary>
        /// Выводит информацию о процессе по его имени.
        /// </summary>
        /// <param name="processName">Имя процесса.</param>
        public static void ShowProcessByName(string processName)
        {
            var processes = Process.GetProcessesByName(processName);
            if (processes.Length == 0)
            {
                Console.WriteLine($"Процесс с имением {processName} не найден");
                return;
            }
            foreach (var process in processes)
            {
                Console.WriteLine($"Id: {process.Id}, Name: {process.ProcessName}");
            }
        }

        /// <summary>
        /// Запускает новый процесс.
        /// </summary>
        /// <param name="processPath">Путь к файлу.</param>
        public static void StartNewProcess(string processPath)
        {
            try
            {
                Process.Start(processPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
