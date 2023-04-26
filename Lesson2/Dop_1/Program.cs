//На входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
Console.WriteLine("Пожалуйста, введите число");

double num = Convert.ToDouble(Console.ReadLine());
int index = 1;
double two_num = 0 ;
while ( num > 99 ) 
    {
        num = num /10;
        index = index * 10;
    }
two_num = num % index/10;

Console.WriteLine(num);
Console.WriteLine(two_num);
Console.WriteLine(index);
// 
// double memori_num = num;
// int index = 1; 
// double one_num = 0 ;
// double two_num = 0 ;
// double tmp =0;
// if (num < 10) {Console.WriteLine("Введенное число меньше десяти, задача не имеет решения");}
// else
// {
//    while ( num > 99 ) 
//     {
//         num = num /10;
//         index = index * 10;
//     }

//    if (num > 10 && num < 99) { one_num = (int) num / 10; }
//     Console.WriteLine(one_num);

//    if (num <= 10)
//    {   
//         one_num = (int)num;
//        // Console.WriteLine(one_num);      
//         two_num = memori_num / (index/10);
//         Console.WriteLine(two_num);
//         two_num = (((two_num - one_num * 10)*10 )% 10)*index;
//        // two_num = (int)(two_num * index); 
//         Console.WriteLine(two_num);
//        // Console.WriteLine(two_num);
      
        
//         //Console.WriteLine($"{one_num}{two_num}");
//        // Console.WriteLine(one_num);
        
//    }          
//} 
