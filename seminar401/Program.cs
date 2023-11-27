
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

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

bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

int CountPrimes(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (IsPrime(number))
            {
                //Console.Write(number + " ");
                count++;
            }
        }
        return count;
    }


int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 1, 10);
PrintArray(myArray);

int primeCount = CountPrimes(myArray);
Console.WriteLine($"Количество простых чисел в массиве: {primeCount}");