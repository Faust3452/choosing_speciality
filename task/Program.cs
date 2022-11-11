// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void ArrPrint(string[] arr)
{
    if (arr.Length == 0) Console.Write("[]");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]}, ");
        if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        if ((i > 0) && (i < arr.Length - 1)) Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

string[] ArrFill(int arrSize)
{
    string[] result = new string[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        result[i] = Console.ReadLine();
        Console.WriteLine();
    }
    return result;
}

string[] FindStrings(string[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) cnt++;
    }
    string[] res = new string[cnt];
    cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            res[cnt] = arr[i];
            cnt++;
        }
    }
    return res;
}

Console.Write("Введите количество элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
string[] checkArr = ArrFill(arrSize);
Console.Write("Полученный массив: ");
ArrPrint(checkArr);
string[] resArr = FindStrings(checkArr);
Console.Write("Полученный массив: ");
ArrPrint(resArr);