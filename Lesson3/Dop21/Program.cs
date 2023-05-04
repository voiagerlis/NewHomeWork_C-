//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(double x1, double y1,double z1, double x2, double y2, double z2)
{
   double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
   return result;
}

Console.WriteLine("Введите координаты первой точки ( х, у, z) ");

double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (х, у, z) ");

double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double dlinna = Math.Round ( Distance(x1,y1,z1 ,x2,y2, z2),2 );

Console.WriteLine($" Расстояние между точками равно: {dlinna}");