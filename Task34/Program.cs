﻿void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1000);
}

int SearchQuantityEven(int[] array)
{
    int result=0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2==0) result++;
    return result;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine($" -> {SearchQuantityEven(array)}");