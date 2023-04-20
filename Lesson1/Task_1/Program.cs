// Сравнение двух чисел

Console.WriteLine("Пожалуйста, введите два числа");

int namber1 = Convert.ToInt32(Console.ReadLine());
int namber2 = Convert.ToInt32(Console.ReadLine());
int result = (namber1 + namber2 + Math.Abs(namber1 - namber2))/2;

Console.WriteLine("Максимальное число = "+result);