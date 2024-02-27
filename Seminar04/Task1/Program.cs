// 1. Задайте одномерный массив, заполненный случайными
//    числами. Определите количество простых чисел в этом
//    массиве.

int[] CreateArray(int min, int max, int size) //int[] CreateArray(int up, int down, int size)
{
    Random rnd = new Random(); //Random rnd = new Random();
    int[] array = new int[size]; //int[] array = new int[size];
    for (int i = 0; i < size; i++) //for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max); //array[i] = rnd.Next(down, up);
    }
    return array; //return array;
}
bool SearchSimpleNum(int num)
{
    if (num < 2)
    {
        return false;
    }
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}
int CountSimpleNumbers(int [] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (SearchSimpleNum(num))
        {
            count++;
        }
    }
    return count;
}

Console.Write("Add final array value: ");
int max = int.Parse(Console.ReadLine()!);
Console.Write("Add initial array value: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Add array length: ");
int size = int.Parse(Console.ReadLine()!);

int[] result = CreateArray( min, max, size);
Console.WriteLine(string.Join(" ", result));
Console.WriteLine(CountSimpleNumbers(result));

