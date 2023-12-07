// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

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
            Console.Write(matrix[i, j].ToString().PadLeft(maxLength + 1)); // "Красивый" вывод массива
        }
        Console.WriteLine();
    }
}

void ReplaceEvenIndextoSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
        }
    }
}

// Основная программа

int row = ReadInt("Введите количество строк 2-х мерного массива: ");
int column = ReadInt("Введите количество столбцов 2-х мерного массива: ");

int[,] myMatrix = Generate2DArray(row, column, -9, 10);

Print2DArray(myMatrix);
ReplaceEvenIndextoSquare(myMatrix);
Console.WriteLine("---------------------------------");
Print2DArray(myMatrix);

