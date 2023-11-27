// int ReadInt(string text)

// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

 
// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         tempArray[i] = rand.Next(leftRange, rightRange + 1);
//     }
//      return tempArray;
// }

 

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }
 
// // Основной код 
// int size = ReadInt("Введите размер массива: ");
// int[] myArray = GenerateArray(size, -10, 10);
// PrintArray(myArray);

// int[] newArray = new int[size / 2];
// for (int i=0; i < myArray.Length / 2; i++) {
//      newArray[i] = myArray[i] * myArray[myArray.Length-1-i];
// }
    
// PrintArray(newArray);


double[] array = new double[5];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)

{
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
}
 
System.Console.WriteLine(string.Join(" ", array));