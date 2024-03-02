// 3. Задайте двумерный массив из целых чисел. Сформируйте новый
//    одномерный массив, состоящий из средних арифметических
//    значений по строкам двумерного массива.

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

double[] AverageRows(int[,] DoubleArr)
{
    double[] Average = new double[DoubleArr.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < DoubleArr.GetLength(0); i++)
    {
        for (int j = 0; j < DoubleArr.GetLength(1); j++)
        {
           sum += DoubleArr[i, j];
        }
        Average[i] = sum / DoubleArr.GetLength(1);
        sum = 0;
    }
    return Average;
}
Console.Write("Enter count of rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter count of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] DoubleArr = CreateMatrix(rows, columns);
ShowMatrix(DoubleArr);
Console.WriteLine();
foreach (double e in AverageRows(DoubleArr))
{
    Console.Write($"{e} ");
}

