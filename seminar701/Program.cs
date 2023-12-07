// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 123 => 6
// 63 => 9

int SummOfDigits(int number)
{
    if (number <= 10) { return number; }
    else { return number % 10 + SummOfDigits(number / 10); }

}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = SummOfDigits(number);
Console.WriteLine(result);


