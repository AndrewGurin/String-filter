void PrintArray(string?[] array, int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i < length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int length = 10;
string?[] inputArray = new string[length];
string?[] result = new string[length];
int threshold = 3;
int i, count = 0;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Добро пожаловать в приложение String filter. v1.0!");
Console.ResetColor();
Console.WriteLine($"Вводите строки и нажимайте Enter. Программа покажет строки длиной не больше {threshold} символов.");
for (i = 0; i < length; i++)
{
    Console.Write($"Осталось свободных ячеек: {length - i}\n> ");
    inputArray[i] = Console.ReadLine();
    if (inputArray[i] == string.Empty)
        break;
    if (inputArray[i]!.Length <= threshold)
    {
        result[count] = inputArray[i];
        count++;
    }
}

Console.WriteLine();
Console.WriteLine("Исходный массив строк:");
PrintArray(inputArray, i);
Console.WriteLine();
Console.WriteLine($"Массив строк после фильтрации по длине не больше {threshold} символов:");
PrintArray(result, count);
Console.WriteLine();

/*Console.WriteLine("Исходный массив строк:\n[" + string.Join(", ", inputArray) + "]");
Console.WriteLine($"Массив строк после фильтрации по длине не больше {threshold}:");
Console.WriteLine("[" + string.Join(", ", result) + "]");*/