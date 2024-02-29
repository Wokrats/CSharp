//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

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
int CountNum(int [] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int down = 100;
int up = 1000;

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] result = CreateArray( down, up, size);
Console.WriteLine(string.Join(" ", result));

Console.WriteLine(CountNum(result));