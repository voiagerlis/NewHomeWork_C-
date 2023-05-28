// На вход программы подаются три целых положительных числа.
//  Определить , является ли это сторонами треугольника. 
//  Если да, то вывести всю информацию по нему - площадь, периметр, значения углов 
//  треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
Console.Clear();
Console.WriteLine("Введите число  a  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число  b  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число  c  ");
int c = Convert.ToInt32(Console.ReadLine());

bool TryFolse(int a, int b, int c)
{
    bool i = false;
    if ((a + b > c) && (a + c > b) && (c + b > a))
    {
        i = true;
    }
    else i = false;
    return i;
}
bool i = TryFolse(a, b, c);
Console.WriteLine(i);
