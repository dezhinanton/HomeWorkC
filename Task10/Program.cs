Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100)
{
    Console.Write("Вы ошиблись!\nВведите число(от 100 до 999): ");
    n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 10;
int n2 = n1 % 10;
Console.WriteLine(n2);