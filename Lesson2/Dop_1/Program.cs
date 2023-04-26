//На входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
Console.WriteLine("Пожалуйста, введите число больше 10");

double num = Convert.ToDouble(Console.ReadLine());
double memory_num = num;
int one_num = 0;
double two_num = 0;
int index = 1;
int count = 1;
if (num % 1 != 0) 
{
    while (num % 1 !=0 )
    {
        num = num * 10;
        count ++ ;
    }
}
//Console.WriteLine($"Count = {count}");
num = memory_num;
if (num >=10 && num <= 99)
{



    
}
if (num < 10) {Console.WriteLine("Введенное число менее 10, задача не имеет решения"); return; }

while (memory_num > 99) 
{
    memory_num = memory_num / 10;
    index = index * 10;    
} 
Console.WriteLine($"Index ={index}");
two_num = num % index;
Console.WriteLine($"Второе число ={two_num}");
one_num = (int)(num / index /10);
Console.WriteLine($"Первое число ={one_num}");
Console.WriteLine($"{one_num+two_num}");