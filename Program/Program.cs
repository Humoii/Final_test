string[] DynamicArray(string[] array, int n)
{
    // Динамически создает массив 
    int i = 0;
    foreach (string a in array)
    {
        if (a.Length <= n) i++;
    }
    return new string[i];
}

string[] ArrayFill(string[] array, string[] array1, int n)
{
    //  Заполнение массива
    int h = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            array1[h] = array[i];
            h++;
        }
    }
    return array1;
}

string[] array = { "hello", "2", "world", ":-)" };
string[] array1 = DynamicArray(array, 3);
ArrayFill(array, array1, 3);
foreach (string a in array1) System.Console.WriteLine(a);
