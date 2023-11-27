// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    int positive_num = Math.Abs(number);
    if (positive_num >= 100)
    {
        int thirdDigit = positive_num % 1000 / 100;
        Console.WriteLine($"Третья цифра с конца: {thirdDigit}");
    }
    else
    {
        Console.WriteLine("У введенного числа нет третьей цифры с конца.");
    }
}
else
{
    Console.WriteLine("Пожалуйста, введите корректное число.");
}

