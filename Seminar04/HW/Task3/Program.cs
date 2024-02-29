//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int down, int up, int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(down, up);
    }
    return array;
}
int[] CoupArr(int[] array)
{
    //int[] firstArray = CreateArray(down, up, size);
    int[] secondArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        secondArray[i] = array[array.Length - i - 1];
    }
    return secondArray;
}

Console.Write("Add final array value: ");
int up = int.Parse(Console.ReadLine()!);
Console.Write("Add initial array value: ");
int down = int.Parse(Console.ReadLine()!);
Console.Write("Add array length: ");
int size = int.Parse(Console.ReadLine()!);

int[] result = CreateArray(down, up, size);
Console.WriteLine("Первоначальный массив: " + string.Join(" ", result));
Console.WriteLine("Перевернутый массив: " + string.Join(" ", CoupArr(result)));