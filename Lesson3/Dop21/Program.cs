//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите число размерности пространства не меньше двух ");
int num = Convert.ToInt32(Console.ReadLine());

int [] mas_kor = new int [num*3];
int mas_length = mas_kor.Length;
double result = 0;
int count = 0;
if (num < 2 ) {Console.WriteLine("Введенное число меньше 2");}
else
{

for (int i = 0; i < num*3; i++)
{
Console.WriteLine($"Введите координаты {i} точки ( х, у, z) ");

mas_kor[i] = Convert.ToInt32(Console.ReadLine()); i++;
mas_kor[i] = Convert.ToInt32(Console.ReadLine()); i++;
mas_kor[i] = Convert.ToInt32(Console.ReadLine());
}
   while (count < mas_length)
   {
      result = Math.Pow(mas_kor[count+1] - mas_kor[count],2)+ Math.Pow(mas_kor[count+3] - mas_kor[count+2],2) + Math.Pow(mas_kor[count+5] - mas_kor[count+4],2);
      Console.WriteLine($"result = {result}");
}      //Console.WriteLine($"Элемент массива = {mas_kor[count]}");
      count++;
   }
   //Console.WriteLine($"result = {result}");
//}




// double Distance( int [] mas)
// {
   
//    int count = 0;
//    while (  count < mas_length-1 )
//    {
//     //double result = Math.Pow(mas[count+1] - Math.Pow(mas[count] , 2)) + Math.Pow(mas[count+3] - Math.Pow(mas[count+2] , 2)) + Math.Pow(mas[count+5] - Math.Pow(mas[count+4] , 2));
//    int result = 1+count;
//     Console.WriteLine($"Элемент массива = {mas[count]}");
//       count++;
//    }
//    double result = Math.Sqrt(result);
//    return result;
// }

// double dlinna = Math.Round ( Distance(mas_kor),2 );

// Console.WriteLine($" Расстояние между точками равно: {dlinna}");
//}