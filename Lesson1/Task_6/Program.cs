// Проверка является ли введенное пользователем число четным

Console.WriteLine("Пожалуйста, введите число");
double num1 = Convert.ToDouble(Console.ReadLine());
double result = num1 % 2;
if (result == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
    Console.WriteLine("Введенное число не является четным");
