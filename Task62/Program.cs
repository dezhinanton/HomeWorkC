void InputMatrix(int[,] matrix)
{
    int x = 0, y = 0, count = 1;
        while (count <= matrix.Length)                                  
        {
            matrix[x, y] = count;                                       
            count++;                                                    
            if (x <= y + 1 && x + y < matrix.GetLength(1) - 1) y++;     
            else if (x < y && x + y >= matrix.GetLength(0) - 1) x++;    
            else if (x >= y && x + y > matrix.GetLength(1) - 1) y--;    
            else x--;                                                   
        }
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

int n = 4, m = 4;
int[,] matrix = new int[m, n];
InputMatrix(matrix);
Console.WriteLine("Конечный массив:");
PrintMatrix(matrix);