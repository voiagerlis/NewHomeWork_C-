// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNature(int np, int iter, int sum)
{
    if (iter == 0)
        return sum;
    sum = sum + np++;
    iter--;
   return SumNature(np, iter, sum);
}
Console.Clear();
System.Console.WriteLine("Введите нижнюю границу диапазона");
int numBotton = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите верхнюю границу диапазона");
int numTop = Convert.ToInt32(Console.ReadLine());
int sum = numTop;
if (numBotton < numTop)
{
    int iter = (numTop - numBotton);
    int num = SumNature(numBotton, iter, sum);
    System.Console.WriteLine($"при M = {numBotton} и N = {numTop}  ->  {num}");
}
else
    System.Console.WriteLine("Введеный  диапазон не корректен");
