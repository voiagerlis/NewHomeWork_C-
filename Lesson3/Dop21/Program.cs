//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите число размерности пространства не меньше двух ");
int num = Convert.ToInt32(Console.ReadLine());

int[] mas_kor = new int[num * 2]; // одномерный массив под координаты размерность определяет пользователь
double result = 0;


if (num < 2)
{
    Console.WriteLine("Введенное число меньше 2");
}
else
{
    for (int i = 0; i <= num; i++)
    {
        int ind = 0;
        Console.WriteLine($"Введите координаты первой точки - {num} коорд. ");
        while (ind < num)
        {
            mas_kor[i] = Convert.ToInt32(Console.ReadLine());
            ind++;
            i++;
        }
        ind = 0;
        Console.WriteLine($"Введите координаты второй точки - {num} коорд. ");
        while (ind < num)
        {
            mas_kor[i] = Convert.ToInt32(Console.ReadLine());
            ind++;
            i++;
        }
    }
    for (int i = 0; i < num; i++)
    {
        result = result + Math.Pow(mas_kor[i + num] - mas_kor[i], 2);
    }
    result = Math.Sqrt(result);
    Console.WriteLine($"Расстояние между заданными точками = {Math.Round(result, 2)}");
}