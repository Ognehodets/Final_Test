

void PrintArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]}\t");
    }
    Console.WriteLine();
}

Console.Clear();
string[] initArr = { "a", "asdfdf", "brerjf", "df", "dgd", "h", "hyuk" };
Console.Write("Исходный массив: ");
PrintArray(initArr);
string[] finArr = new string[initArr.Length];
int j = 0;
for (int i = 0; i < initArr.Length; i++)
{
    if (initArr[i].Length < 4)
    {
        finArr[j] = initArr[i];
        j++;
    }
}
Array.Resize(ref finArr, j);
Console.Write("Измененный массив: ");
PrintArray(finArr);
