System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        System.Console.WriteLine("Пн");
        break;
    case 2:
        System.Console.WriteLine("Вт");
        break;
    case 3:
        System.Console.WriteLine("Ср");
        break;
    case 4:
        System.Console.WriteLine("Чт");
        break;
    case 5:
        System.Console.WriteLine("Пт");
        break;
    case 6:
        System.Console.WriteLine("Сб");
        break;
    case 7:
        System.Console.WriteLine("Вс");
        break;
    default:
        System.Console.WriteLine("Такого дня недели нет");
        break;
}
