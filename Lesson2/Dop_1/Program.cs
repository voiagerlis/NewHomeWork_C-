//На входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

Console.WriteLine("Пожалуйста, введите число");

double num = Convert.ToDouble(Console.ReadLine());

int count = 1;
int index = 0;

if (num < 10 ) {Console.WriteLine("Решения нет");}
else
{
        while (num > 99) 
        {
        num = num / 10;
        count = count * 10;

        Console.WriteLine(count);
        }      
}
    Console.WriteLine(num);
    







