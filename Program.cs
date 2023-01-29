string[] ReadArray(string Msg)
{
    Console.WriteLine(Msg);

    string Input = Console.ReadLine() ?? "";
    string[] SubStrings = Input.Split(" ");

    return SubStrings;
}

string[] FilterArray(string[] Arr)
{
    string[] FilteredArr = {};

    for (int i = 0; i < Arr.Length; i++) 
    {
        if (Arr[i].Length <= 3)
        {
            Array.Resize(ref FilteredArr, FilteredArr.Length + 1);
            FilteredArr[FilteredArr.Length - 1] = Arr[i];
        }
    }

    return FilteredArr;
}

void PrintArray(string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
}

string[] EnteredArr = ReadArray("Введите набор строк через пробел: ");

Console.WriteLine("Список строк длиной меньше или равной 3 символа: ");
PrintArray(FilterArray(EnteredArr));
