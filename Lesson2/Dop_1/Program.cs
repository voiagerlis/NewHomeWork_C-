//На входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
Console.WriteLine("Пожалуйста, введите число");

double num = Convert.ToDouble(Console.ReadLine());
double memori_num = num;
int index = 1; 
int one_num = 0 ;
double two_num = 0 ;

if (num < 10) {Console.WriteLine("Введенное число меньше десяти, задача не имеет решения");}
else
{
   while ( num > 10 ) 
    {
        num = num /10;
        index = index * 10;
    }

   if (num <= 10)
   {   
        one_num = (int)num;
              
        two_num = memori_num / (index/10);
      Console.WriteLine(two_num);
        two_num = two_num % 100;
      //  two_num = two_num - one_num;
        //two_num = two_num * index;
        
        //Console.WriteLine($"{one_num}{two_num}");
       // Console.WriteLine(one_num);
        
   }          
} 
