/* Программа, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/

Console.WriteLine("Пожалуйста, введите число от 1 до 7");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num >7) {Console.WriteLine("Число не находится в требуемом диапазоне");}

else { 
        if (num == 6 || num == 7 ) { Console.WriteLine("Да, выходной"); }
        else { Console.WriteLine("Нет, не выходной"); }
     } 
