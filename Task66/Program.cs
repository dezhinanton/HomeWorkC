int f(int m, int n)
{
  if (n == m)
    return m;
  return f(m + 1, n) + m;
}

Console.Write("Введите начальное значение: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));