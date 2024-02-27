// 3. Заполните массив на N (вводится с консоли, не более 8)
//    случайных целых чисел от 0 до 9.
//    Сформируйте целое число, которое будет состоять из цифр из
//    массива. Старший разряд числа находится на 0-м индексе,
//    младший – на последнем.

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

int AssemblyNum(int[] array)
{
    string count = "";
    foreach (int num in array)
    {
        count = count + num;
    }
    return int.Parse(count);
}

int max = 9;
int min = 0;
Console.Write("Add array length: ");
int size = int.Parse(Console.ReadLine()!);
if (size > 8)
{
    Console.Write("Enter a number less than 8");
}
else
{
    int[] result = CreateArray( min, max, size);
    Console.WriteLine(string.Join(" ", result));
    Console.WriteLine(AssemblyNum(result));
}

