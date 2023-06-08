// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Nature(int num)
{
    if (num == 1)
        return "1";
    return num + "," + Nature(num - 1);
}
Console.Clear();
System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
string st = "";
st = Nature(num);
System.Console.WriteLine($"при N = {num}  =>  {st}");
