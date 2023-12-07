// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// N=5 => 1 2 3 4 5

void ShowRealNumbers(int currentNumber, int number)
{   
    if (currentNumber <= number)
    {
        Console.Write(currentNumber + " ");
        ShowRealNumbers(currentNumber + 1, number);
    }
}

Console.Write("Введите число N: ");
if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
{
    Console.Write($"N={number} => ");
    ShowRealNumbers(1, number);
    Console.WriteLine();
}
else { Console.WriteLine("Некорректный ввод. Введите положительное целое число."); }
