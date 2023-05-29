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
    else
        i = false;
    return i;
}

double[] ParamTriangle(int a, int b, int c)
{
    double[] arVal = new double[6];
    double perimetr = a + b + c;
    double pper = perimetr / 2;
    double square = Math.Round(Math.Sqrt(pper * ((pper - a) * (pper - b) * (pper - c))), 2);
    double corner1 = (Math.Cos((a * a + c * c - b * b) / (2 * a * c))) * 60;
    double corner2 = (Math.Cos((a * a + b * b - c * c) / (2 * a * b))) * 60;
    double corner3 = (Math.Cos((b * b + c * c - a * a) / (2 * c * b))) * 60;
    double type = 0;
   
    if (a==b || a==c || b==c) type = 1;
    else if (a==b && a==c && b==c ) type = 0;
    else if ( a!=b && a !=c && b !=c) type =2;
    arVal[0] = perimetr;
    arVal[1] = square;
    arVal[2] = corner1;
    arVal[3] = corner2;
    arVal[4] = corner3;
    arVal[5] = type;

    return arVal;
}
void PrintArray(double[] array)
{
    foreach (double item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

bool i = TryFolse(a, b, c);
if (i == true)
{
    
    Console.WriteLine($"данный треугольни");
double[] arrayValues = new double[6];
arrayValues = ParamTriangle(a, b, c);
string type = string.Empty;
if (arrayValues[5]==0) type = "равносторонний";
else if (arrayValues[5]==1) type = "равнобедренный";
else if (arrayValues[5]==2) type = "скалярный";
 
Console.WriteLine($"данный треугольник {type}, периметр {arrayValues[0]}, площадь: {arrayValues[1]} ");
Console.WriteLine($"Углы альфа {arrayValues[2]}, бетта {arrayValues[3]}, гамма {arrayValues[4]} ");
//PrintArray(arrayValues);



}
else
    Console.WriteLine("Да не треугольник это!!!");
//Console.WriteLine(i);
