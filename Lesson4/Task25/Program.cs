// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//

Console.WriteLine("Введите основание степени отличное от нуля: ");
int footing = Convert.ToInt32(Console.ReadLine());
if (footing <= 0)
{
    Console.WriteLine("Основание степени не может быть меньше или равняться нулю");
    return;
}
Console.WriteLine("Введите степень возводимого числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
if (degree <= 0)
{
    Console.WriteLine("Степень возводимого числа должна быть более единицы ");
    return;
}
int DegreeFun(int numF, int numD)
{
    int result = 1;
    for (int i = 0; i < numD; i++)
    {
        result = result * numF;
    }
    return result;
}
Console.Clear();
int degreeNum = DegreeFun(footing, degree);
Console.WriteLine($"Число - {footing} в степени - {degree} = {degreeNum}");
