// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int ReadInt(string text)
    {
        System.Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

int[] GenerateArray(int size, int leftRange, int rightRange)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
    }

void PrintArray(int[] array)
    {
        System.Console.WriteLine($"[{string.Join(", ", array)}]");
    }

int CountDivBy7(int[] array){
    int count = 0;
// foreach (int number in array) 
//     if (number % 7 == 0 && number % 10 ==1) {
//         count++;
//     }
    for (int number =0; number < array.Length; number++){
        if (array[number] % 7 == 0 && array[number] % 10 ==1){
            count++;
    }
    }
            return count;
}
// Основная программа


int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 0, 100);
myArray[1] = 21;
PrintArray(myArray);



int count = CountDivBy7(myArray);

Console.WriteLine($"Количество чисел, которые оканчиваются на 1 и делятся нацело на 7 = {count}");
