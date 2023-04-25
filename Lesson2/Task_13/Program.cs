// Вывести третью цифру  вводимого числа

Console.WriteLine("Пожалуйста, введите число");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 ) {Console.WriteLine("Третьей цифры нет");}

else { 
       while (num >1000) {num = num /10; }
        num = num % 10;
        Console.WriteLine($"Число во третьем разряде = {num} ");
      } 