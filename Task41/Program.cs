Console.Clear();
int m = 5, count=0;
Console.WriteLine($"Введите {m} чисел");
for (int i = 0; i < m; i++)
    if (int.Parse(Console.ReadLine()!)>0) count++;
Console.WriteLine($"Пользователь ввёл {count} положительных чисел");