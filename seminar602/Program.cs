// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

string? str = Console.ReadLine();
char[] chars = new char[str!.Length];

for(int i =0; i< str.Length; i++)
{
    chars[i] = str[i];
}

System.Console.WriteLine(string.Join(", ", chars))

