// Назовем число "интересным", если сумма его цифр четная
// Создать двумерный массив, состоящий из целых чисел. 
// Вывести на экран "интересные" элементы массива

int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); //интерполяция строк
        }
        Console.WriteLine();
    }
}

int SumDig(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

bool IsInteresting(int value)
{
    int sum_dig = SumDig(value);
    if (sum_dig % 2 == 0)
    {
        return true;
    }
    return false;
}

int[,] demoMatrix = CreateMatrix(3, 4);
ShowMatrix(demoMatrix);

foreach (int e in demoMatrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

