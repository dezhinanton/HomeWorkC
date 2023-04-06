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

int[,] MatrixTemp(int[,] matrix1, int[,] matrix2)
{
    int[,] temp = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int k = 0; k < temp.GetLength(0); k++)
        for (int l = 0; l < temp.GetLength(1); l++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                temp[k, l] += matrix1[k, j] * matrix2[j, l];
    return temp;
}

Console.Clear();
int n = 2, m = 2, l = 2;
int[,] matrix1 = new int[m, l];
int[,] matrix2 = new int[l, n];
InputMatrix(matrix1);
InputMatrix(matrix2);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
Console.WriteLine($"Произведение матриц:");
PrintMatrix(MatrixTemp(matrix1, matrix2));