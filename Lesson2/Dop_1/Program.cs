//На входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
Console.WriteLine("Пожалуйста, введите число больше 10");

decimal num = decimal.Parse(Console.ReadLine());

if (num < 10) {Console.WriteLine("Введенное число менее 10, задача не имеет решения"); return; }

decimal memory_num = num;
decimal one_num = 0;
decimal two_num = 0;
decimal index = 10;


if (num >= 10 && num <= 99) // Если число в двузначное просто откидываю вторую цифру
{
    num = (num - num  % 10) / 10;
    Console.WriteLine($"{num}");
}
else if (num > 99) // если число трехзначное и более вычисляю вторую цифру при этом сохраняю первый разряд в одной переменной
                   // а в другой все что после
{
  while (num>99)  
  {
     num = num / 10;
     index = index * 10;    
  }
    one_num = (int)(num - (num % 10))/10;
    two_num = num * 10 % index;
    two_num = (two_num % 10)*index/100;
    two_num = Math.Round(two_num,0);

    Console.WriteLine($"Index ={index}");
    Console.WriteLine($" число ={num}");
    Console.WriteLine($"Второе число ={two_num}");
    Console.WriteLine($"Первое число ={one_num}");
    
    Console.WriteLine($"{one_num}{two_num}");


}

// decimal count = 1;
// if (num % 1 != 0) 
// {
//     while (num % 1 !=0 )
//     {
//         num = num * 10;
//         count ++ ;
//     }
// }
// Console.WriteLine($"Count = {count}");
// Console.WriteLine($"Num = {num}");

//  while (num > 99) 
// {
//     num = num / 10;
//     index = index * 10;    
// } 
// 
// Console.WriteLine($"Num = {num}");
// //one_num = num % 10;
// //two_num = (num % index/100);
// Console.WriteLine($"Второе число ={two_num}");
// one_num =num % 10;
// Console.WriteLine($"Первое число ={one_num}");
// Console.WriteLine($"{one_num}{two_num}");