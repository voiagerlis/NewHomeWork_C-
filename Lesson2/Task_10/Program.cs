// Вывести вторую цифру трехзначного вводимого числа

Console.WriteLine("Пожалуйста, введите трехзначное число");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num >999) {Console.WriteLine("Введенное число не является трехзначным");}

else { 
       num = (num / 10) % 10; 
       Console.WriteLine($"Число во втором разряде = {num} ");
     } 
