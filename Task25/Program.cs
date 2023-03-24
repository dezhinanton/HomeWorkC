Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine()),result = 1;
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine()); 
for (int i = 0; i < b; i++)
  result *= a;
Console.WriteLine(result);