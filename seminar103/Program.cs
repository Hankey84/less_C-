// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.Write("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0){
    Console.WriteLine($"{number1}, {number2} => Да");
}
else{
    Console.WriteLine($"{number1}, {number2} => Нет, {number1 % number2}");
}
