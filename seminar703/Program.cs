// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

bool IsValidString(string str)
{
    foreach (char symbol in str)
    {
        if (!char.IsLetter(symbol) || !char.IsLetter(symbol)) { return false; }
    }
    return true;
}

void PrintConsonants(string str, int index)
{
    if (index < str.Length)
    {
        char currentChar = str[index];

        if (IsConsonant(currentChar)) { Console.Write(currentChar + " "); }
        
        PrintConsonants(str, index + 1);
    }
}

bool IsConsonant(char symbol)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    return char.IsLetter(symbol) && !Array.Exists(vowels, v => v == symbol);
}

Console.Write("Введите строку с латинскими буквами: ");
string inputString = Console.ReadLine()!;

if (IsValidString(inputString))
{
    Console.Write($"\"{inputString}\" => ");
    PrintConsonants(inputString.ToLower(), 0);
    Console.WriteLine();
}
else { Console.WriteLine("Некорректный ввод. Введите строку с латинскими буквами."); }