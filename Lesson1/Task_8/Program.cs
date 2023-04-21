// Показываю четные числа диапазона пользователя

Console.WriteLine("Пожалуйста, введите число");
double num1 = Convert.ToDouble(Console.ReadLine());
double result = num1 % 2;
int index = 2;
if (result == 0)
{
   while (index <= num1)
   {
           Console.WriteLine(index);
           index = index + 2;
   }
}
if (result == 1)
{
    while (index <= num1-1)
    {
           Console.WriteLine(index);
           index = index + 2;
    }
}

