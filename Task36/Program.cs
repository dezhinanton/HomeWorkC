void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

int SumOdd_i(int[] array)
{
    int sum=0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum=sum+array[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine($" -> {SumOdd_i(array)}");