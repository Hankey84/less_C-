// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int row, int column, int leftRange, int rightRange)
{   
    int[,] matrix = new int[row, column];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

int GetMaxLength(int[,] matrix) //Определение максимальной длины числа в массиве для последующего "красивого" вывода на экран
{
    int maxLength = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int currentLength = matrix[i, j].ToString().Length;
            if (currentLength > maxLength)  maxLength = currentLength;
        }
    }
        return maxLength;
}

void Print2DArray(int[,] matrix)
{
    int maxLength = GetMaxLength(matrix);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString().PadRight(maxLength + 1)); // "Красивый" вывод массива
        }
        Console.WriteLine();
    }
}

int[] ArrayofMeanRow(int[,] matrix)
{
    int[] mean = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j]; 
        }
        double average = (double)sum / matrix.GetLength(1);
        mean[i] = (int)Math.Round(average);
    }
    return mean;
}

// Основная программа

int row = ReadInt("Введите количество строк 2-х мерного массива: ");
int column = ReadInt("Введите количество столбцов 2-х мерного массива: ");
int[,] myMatrix = Generate2DArray(row, column, 1, 100);

Print2DArray(myMatrix);
int[] MeanArray = ArrayofMeanRow(myMatrix);

Console.WriteLine($"[{string.Join(", ", MeanArray)}]");

