//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

int[] CreateArr(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write($"{num} ");
    }
}
void PrintInvertedArray(int[] array, int i = 0)
{
    int size = array.Length;
    if (i < size)
    {
        Console.Write($"{array[size -1 - i]} ");
        PrintInvertedArray(array, i + 1);
    } 
}


int size = 10;
int[] arbitraryArray = CreateArr(size);
PrintArray(arbitraryArray);
Console.WriteLine();
PrintInvertedArray(arbitraryArray);
