// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akkerman (int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.Clear();
System.Console.WriteLine("Введите первое число");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("Введите второе число");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine($"при m = {m} и n = {n}  ->  {Akkerman(n,m)}");