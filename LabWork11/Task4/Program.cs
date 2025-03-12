string fileName = "logins.txt"; //хранение данных

// сущетсвует ли файл
if (!File.Exists(fileName))
{
    File.Create(fileName).Close();
}

string login;

do
{
    //запрос логина
    Console.Write("Введите логин: ");
    login = Console.ReadLine();

    // есть ли логин в файле
    if (File.ReadAllLines(fileName).Any(line => line.StartsWith(login + ","))) // начинаетья ли какая либо строка с введённого логина
        Console.WriteLine("Логин уже используется!");
    else 
        break;
} while (true);

Console.Write("Введите пароль: ");
string password = Console.ReadLine();

string record = $"{login}, {password}; {DateTime.Now:yyyy-MM-dd HH:mm}"; 
File.AppendAllText(fileName, record + Environment.NewLine); // добавление строки в конец файла, Environment.NewLine - перенос строки

Console.WriteLine("Вы зарегистрированы!");