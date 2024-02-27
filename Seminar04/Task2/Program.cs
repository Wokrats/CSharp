// 2. Задайте массив из N случайных целых
//    чисел (N вводится с клавиатуры).
//    Найдите количество чисел, которые
//    оканчиваются на 1 и делятся нацело на 7.

int[] CreateArray(int min, int max, int size) 
{
    Random rnd = new Random(); 
    int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    {
        array[i] = rnd.Next(min, max); 
    }
    return array; 
}
int CountNum(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 10 == 1 && num % 7 == 0)
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
Console.WriteLine(CountNum(result));