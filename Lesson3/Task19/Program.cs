// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Пожалуйста, введите пятизначное число");

int num = Convert.ToInt32(Console.ReadLine());

int index = 1;
int one = 0;
int tmp_one = 0;

if (num < 9999 || num >99999) {Console.WriteLine("Введенное число не является пятизначным");}

else 
{ 
       
     while (index <= 10000)
    {
        tmp_one = (num / index) % 10; // получаю очередной разряд числа от меньшего к большему справо на лево
        one = one * 10 + tmp_one;
        index = index * 10;    
    }
     
     if ( num == one ) { Console.WriteLine($"ДА, число  = {one}, палиндром числа {num} "); }
     else { Console.WriteLine($"НЕТ, число  = {one}, не является палиндром числа {num} "); }    
     
} 
