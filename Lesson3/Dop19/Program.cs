// Напишите программу, которая принимает на вход любое целое число и проверяет, является ли оно палиндромом

Console.WriteLine("Пожалуйста, введите любое целое число");

int num = Convert.ToInt32(Console.ReadLine());
int pallindrom = 0;
int SizeNum = 0;

int CountLong (int size_number) // метод подсчитывает разрядность введенного числа
{
    int count = 1;
    while (size_number > 10)
    {
        size_number = size_number / 10;
        count = count * 10;
    }

return count;
}

int Shifter( int number, int ligth_num) // метод переворачивает число в обратном порядке
{
int index = 1;
int one = 0;
int tmp_one = 0;

     while (index <= ligth_num)
    {
        tmp_one = (num / index) % 10; // получаю очередной разряд числа от меньшего к большему справо на лево
        one = one * 10 + tmp_one;
        index = index * 10;    
    }
return (one);
}     
     SizeNum = CountLong (num); 
     pallindrom = Shifter(num, SizeNum);
     if ( num == pallindrom ) { Console.WriteLine($"число {pallindrom}, палиндром числа {num} "); }
     else { Console.WriteLine($"число {pallindrom}, не является палиндром числа {num} "); }    
     
 
