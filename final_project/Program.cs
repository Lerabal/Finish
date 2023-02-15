int GetUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int size = GetUserData("Введите количество элементов массива: ");





