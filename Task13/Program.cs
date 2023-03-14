Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while(n < 100)
{    Console.WriteLine("Ошибка! Введите трех- и более значное число : ");
    n = int.Parse(Console.ReadLine()!);
}              
while(n > 1000)    
    n = n/10;
    Console.WriteLine(n%10); 