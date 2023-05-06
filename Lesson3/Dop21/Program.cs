//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите число размерности пространства не меньше двух ");
double num = Convert.ToDouble(Console.ReadLine());

double [] mas_kor = new ;
double mas_length = mas_kor.Length;
double count = 0;
if (num < 2 ) {Console.WriteLine("Введенное число меньше 2");}
else
{

for (int i = 0; i < num*3; i++)
{
Console.WriteLine($"Введите координаты {i} точки ( х, у, z) ");

mas_kor[i] = Convert.ToDouble(Console.ReadLine()); i++;
mas_kor[i] = Convert.ToDouble(Console.ReadLine()); i++;
mas_kor[i] = Convert.ToDouble(Console.ReadLine());
}
//    while (count < mas_length )
//    {
//     //double result = Math.Pow(mas[count+1] - Math.Pow(mas[count] , 2)) + Math.Pow(mas[count+3] - Math.Pow(mas[count+2] , 2)) + Math.Pow(mas[count+5] - Math.Pow(mas[count+4] , 2));
//       Console.WriteLine($"Элемент массива = {mas_kor[count]}");
//       count++;
//    }
   
// }




// double Distance( double mas)
// {
//    int count = 0;
//    double result = 0;
//    while (  count < mas_length )
//    {
//      result = Math.Pow(mas[count+1] - Math.Pow(mas[count] , 2)); 
//     // result= Math.Pow(mas[count+1] - mas[count], 2) + Math.Pow(mas[count+3] - mas[count+2], 2) + Math.Pow(mas[count+5] - mas[count+4]);
    
//     //+ Math.Pow(mas[count+3] - Math.Pow(mas[count+2] , 2)) + Math.Pow(mas[count+5] - Math.Pow(mas[count+4] , 2));
//    //int result = 1+count;
//     //Console.WriteLine($"Элемент массива = {mas[count+1]}");
//       count++;
//    }
//     //result = Math.Sqrt(result);
//    return result;
// }

// double dlinna = Distance(mas_kor);
// //Math.Round ( Distance(mas_kor),2 );

// Console.WriteLine($" Расстояние между точками равно: {dlinna}");
}