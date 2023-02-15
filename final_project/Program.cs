Console.Clear();
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
void GetSecondArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.WriteLine($"Массив строк, длина которых меньше либо равна трем:"); 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int size = GetUserData("Введите количество элементов массива: ");
string[] array = AddArray(size);
string[] array2 = new string[array.Length];
GetSecondArray(array, array2);
PrintArray(array2);




