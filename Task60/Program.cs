void InputMatrix(int[,,] matrix)
{
    int[] form = new int[100]; 
    form[0] = 1;  
    for (int x = 0; x < matrix.GetLength(0); x++)
        for (int y = 0; y < matrix.GetLength(1); y++)
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                while (form[matrix[x, y, z]] == 1)                          
                    matrix[x, y, z] = new Random().Next(10, form.Length);   
                form[matrix[x, y, z]] = 0;                                  
            }                                                                    
}

void PrintMatrix(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
                Console.Write($"{matrix[x, y, z]}({x},{y},{z})\t");
            Console.WriteLine();
        }
}

Console.Clear();
int x = 2, y = 2, z = 2;
int[,,] matrix = new int[x, y, z];
InputMatrix(matrix);
Console.WriteLine("Результат:");
PrintMatrix(matrix);