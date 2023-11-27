// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

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

int ArraytoNumber(int[] array) {
    int result = 0;
    int mult = (int)Math.Pow(10, array.Length-1);
    foreach (int number in array) {
        result += number * mult;
        mult /= 10;
    }
    return result;
}

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 0, 9);

PrintArray(myArray);

Console.WriteLine(ArraytoNumber(myArray));

// Console.WriteLine(string.Join("",myArray));
