Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "рома")
{
    Console.WriteLine("Категорически тебя приветствую, дорогой!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}