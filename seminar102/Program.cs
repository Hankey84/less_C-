// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 645
// 617 => 1

Console.Write("Введите трёхзначное число: ");
        
if (int.TryParse(Console.ReadLine(), out int number) && number >= 100 && number <= 999)
{
    int second = (number / 10) % 10;
    int third = number % 10;
// 1-й способ через цикл.    
    // int result = 1;
    // for (int i = 0; i < third; i++){
    //     result *= second;
    // }
// 2-й способ. Через встроенную мат.функцию
    double doubl1 = Convert.ToDouble(second);
    double doubl2 = Convert.ToDouble(third);
    double result = Math.Pow(doubl1, doubl2);
   
   Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите корректное трёхзначное число.");
}
