// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine(
    "Программа, найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;"
);
Console.WriteLine("Введите числа для k1, k2, b1, b2");
decimal k1 = 0,
    k2 = 0,
    b1 = 0,
    b2 = 0;
Console.Write("Введите чисело k1  ");
k1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите чисело k2  ");
k2 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите чисело b1  ");
b1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите чисело b2  ");
b2 = Convert.ToDecimal(Console.ReadLine());

void PrintArray(decimal[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        System.Console.Write($" {numbers[i]}");
    Console.WriteLine();
}

decimal[] Couting(decimal k1, decimal k2, decimal b1, decimal b2)
{
    decimal[] ar = new decimal[2];
    decimal y = 0;
    decimal x = 1;
    x = (b1 - b2) / (k2 - k1);
    ar[0] = x;
    y = k2 * x + b2;
    ar[1] = y;
    return ar;
}
decimal[] array = new decimal[2];
array = Couting(k1, k2, b1, b2);
PrintArray(array);
