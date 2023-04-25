// Вывести цифру второго разряда вводимого числа

Console.WriteLine("Пожалуйста, введите как минимум двузначное число");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 10) {Console.WriteLine("Введенное число меньше десяти, задача не имеет решения");}
else
{
   while (num > 99)  {num = num /10; }

   if (num <= 99)
   {       num = num % 10;
        Console.WriteLine($"Число во втором разряде = {num} ");
   }          
} 