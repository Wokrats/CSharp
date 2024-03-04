// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

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
    Console.WriteLine();
}

int FindRowMinElement(int[,] matrix)
{
    int rowMinEl = 0;
    int minEl = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minEl > matrix[i, j])
            {
                minEl = matrix[i, j];
                rowMinEl = i;
            }
        }
    }
    return (rowMinEl);
}
int FindColMinElement(int[,] matrix)
{
    int colMinEl = 0;
    int minEl = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minEl > matrix[i, j])
            {
                minEl = matrix[i, j];
                colMinEl = j;
            }
        }
    }
    return (colMinEl);
}

int[,] ResultMatrix(int[,] matrix)
{
    int[,] resultMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == FindRowMinElement(matrix))
        {
            i += 1;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == FindColMinElement(matrix))
            {
                j = j + 1;
            }
            resultMatrix[i, j] = matrix[i, j+1];
        }
    }
    return resultMatrix;
}

//Console.Write("Enter count of rows: ");
//int rowCount = int.Parse(Console.ReadLine()!);
//Console.Write("Enter count of columns: ");
//int columnsCount = int.Parse(Console.ReadLine()!);

//int[,] FirstMatrix = CreateMatrix(rowCount, columnsCount);

int[,] FirstMatrix = {
    {9, 5, 6, 4},
    {8, 6, 4, 7},
    {2, 5, 1, 8},
    {3, 5, 8, 6}
};
ShowMatrix(FirstMatrix);
int[,] SecondMatrix = ResultMatrix(FirstMatrix);
ShowMatrix(SecondMatrix);