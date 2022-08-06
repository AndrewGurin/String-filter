void PrintArray(string?[] array, int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i < length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

void PrintFilteredArray(string?[] array, int length, int threshold)
{
    bool begin = false;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (array[i]!.Length <= threshold)
        {
            if (begin)
                Console.Write(", ");
            Console.Write(array[i]);
            begin = true;
        }
    }
    Console.WriteLine("]");
}

int length = 100;
string?[] inputArray = new string[length];
int count = 0;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Добро пожаловать в приложение String filter. v1.1!");
Console.ResetColor();
Console.WriteLine($"Вводите строки и нажимайте Enter. Для окончания ввода оставьте поле пустым.");
for (count = 0; count < length; count++)
{
    Console.Write($"Осталось свободных ячеек: {length - count}\n> ");
    inputArray[count] = Console.ReadLine();
    if (inputArray[count] == string.Empty)
        break;
}

Console.WriteLine();
Console.WriteLine("Исходный массив строк:");
PrintArray(inputArray, count);
Console.WriteLine();
Console.Write("Введите пороговое значение фильтрации:\n> ");
int threshold = Convert.ToInt32(Console.ReadLine());
while (threshold < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Х----------ОШИБКА!----------Х");
    Console.WriteLine("Пороговое значение не может быть отрицательным. Повторите ввод.");
    Console.Write("> ");
    Console.ResetColor();
    threshold = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив строк после фильтрации по длине не больше {threshold} символов:");
PrintFilteredArray(inputArray, count, threshold);
Console.WriteLine();