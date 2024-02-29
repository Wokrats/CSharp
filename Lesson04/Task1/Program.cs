// Создать двумерный массив с размерами 3х5, состоящий из целых чисел
// Вывести его элементы на экран

int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
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

int[,] DemoMatrix = CreateMatrix(4, 5);
ShowMatrix(DemoMatrix);