void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void SortElement(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
                if (matrix[i, k] < matrix[i, k + 1])
                    {
                    temp = matrix[i, k]; matrix[i, k] = matrix[i, k + 1]; matrix[i, k + 1] = temp;
                    }
}

Console.Clear();
int m = 4, n = 3;
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
SortElement(matrix);
Console.WriteLine("Конечный массив:");
PrintMatrix(matrix);