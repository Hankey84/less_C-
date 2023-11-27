// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81
Console.Write("Введите трёхзначное число:");
        
    if (int.TryParse(Console.ReadLine(), out int number) && number >= 100 && number <= 999)
    {
        // // 1-й способ решения задачи.
        // int first = number / 100;
        // int third = number % 10;          
        // int result = first * 10 + third;

        // 2-й способ решения задачи. 
        string numberStr = number.ToString();  
        string resultStr = numberStr.Remove(1, 1);
        int result = int.Parse(resultStr);

        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Введите корректное трёхзначное число.");
    }

