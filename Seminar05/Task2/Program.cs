// 2. Задайте двумерный массив. Найдите сумму элементов,
//    находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

Console.Write("Enter count of rows: ");
int rowCount = int.Parse(Console.ReadLine()!);
Console.Write("Enter count of columns: ");
int columnsCount = int.Parse(Console.ReadLine()!);

int SumDiag(int[,] DoubleArr)
{
    int sum = 0;
    for (int i = 0; i < DoubleArr.GetLength(0); i++)
    {
        for (int j = 0; j < DoubleArr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + DoubleArr[i, j];
            }
        }
    }
    return sum;
}
int[,] Arr = CreateMatrix(rowCount, columnsCount);
ShowMatrix(Arr);
Console.Write(SumDiag(Arr));