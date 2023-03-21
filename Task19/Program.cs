Console.Clear();
Console.Write("Введите пятизначное число: ");
string s = Console.ReadLine()!;
while(s.Length != 5)
{
  Console.Write("ОШИБКА! Введите пятизначное число: ");
  s = Console.ReadLine()!;
}
if (s[0] == s[4] && s[1] == s[3])
  Console.WriteLine("Данное число - палиандром");
else
  Console.WriteLine("Данное число - не палиандром");