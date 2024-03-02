// 1. Задайте двумерный массив. Найдите элементы, у которых оба
//    индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(2, 10);
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

int[,] SquareElemEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
    return matrix;
}



Console.Write("Enter count of rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter count of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] DoubleArr = CreateMatrix(rows, columns);
ShowMatrix(DoubleArr);
Console.WriteLine();
int[,] NewDoubleArr = SquareElemEvenIndex(DoubleArr);
ShowMatrix(NewDoubleArr);





