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

int SumofDiagonal(int[,] matrix, bool IfMainDiagonal)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (IfMainDiagonal) {
            sum += matrix[i, i];
        }
        else {
            sum += matrix[i, matrix.GetLength(0) - 1 - i];
        }
    }
    return sum;
}

// Основная программа

int row = ReadInt("Введите количество строк 2-х мерного массива: ");
int column = ReadInt("Введите количество столбцов 2-х мерного массива: ");
int[,] myMatrix = Generate2DArray(row, column, 1, 100);

Print2DArray(myMatrix);
int sum1 = SumofDiagonal(myMatrix, true);
Console.WriteLine($"Сумма элемнтов главной диагонали = {sum1}");
int sum2 = SumofDiagonal(myMatrix, false);
Console.WriteLine($"Сумма элемнтов второстепенной диагонали = {sum2}");

