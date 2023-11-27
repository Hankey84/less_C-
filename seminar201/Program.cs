// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int first = number / 100;
int third = number % 10;
int result = first*10 + third;

Console.WriteLine($"{number} -> {result}");