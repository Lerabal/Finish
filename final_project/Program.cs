int GetUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
string[] AddArray(int size)
{
    string[] arr1 = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        string result = Console.ReadLine()!;
        arr1[i] = result;
    }
    return arr1;
}

int size = GetUserData("Введите количество элементов массива: ");
string[] array = AddArray(size);





