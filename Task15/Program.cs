Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int n = int.Parse(Console.ReadLine()!);
while(n < 1 || n > 7)
{
    Console.WriteLine("ОШИБКА!Введите число от 1 до 7: ");
    n = int.Parse(Console.ReadLine()!);
}
if(n == 6 || n == 7)
    Console.WriteLine("Да, это выходной день!");
else
    Console.WriteLine("Нет, это будний день!");      
        