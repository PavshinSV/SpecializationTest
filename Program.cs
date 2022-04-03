void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) { Console.Write("; "); }
    }
    Console.WriteLine("]");
}

string[] mappingArray(string[] inpArr, int stringLength)
{
    string[] swap = new string[inpArr.Length];
    int arraySize = 0;
    for (int i = 0; i < inpArr.Length; i++)
    {
        if (inpArr[i].Length < stringLength + 1)
        {
            swap[arraySize] = inpArr[i];
            arraySize++;
        }
    }
    Array.Resize(ref swap, arraySize);
    return swap;
}

Console.Clear();

string[] inputArray = { "Russia", "Denmark", "Kazan" };
int stringSize = 3;

Console.WriteLine();
Console.WriteLine("На входе имеем массив со следующими данными:");
PrintArray(inputArray);

Console.WriteLine();
string[] resultArray = mappingArray(inputArray, stringSize);
Console.WriteLine($"На выходе получаем массив с элеменнтами длина которых меньше или равна {stringSize} :");
PrintArray(resultArray);
Console.WriteLine();
Console.WriteLine("Для выхода из программы нажмите ENTER");
Console.Read();