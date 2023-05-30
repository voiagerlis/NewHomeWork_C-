// На вход программы подаются три целых положительных числа.
//  Определить , является ли это сторонами треугольника.
//  Если да, то вывести всю информацию по нему - площадь, периметр, значения углов
//  треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
Console.Clear();
Console.WriteLine("Введите число  a  ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число  b  ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число  c  ");
double c = Convert.ToDouble(Console.ReadLine());

bool TryFolse(double a, double b, double c)
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

double[] ParamTriangle(double a, double b, double c)
{
    double[] arVal = new double[6];
    double perimetr = a + b + c;
    double pper = perimetr / 2;
    double square = Math.Round(Math.Sqrt(pper * ((pper - a) * (pper - b) * (pper - c))), 2);
    double corner1 = Math.Round((Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 57.2958), 2);
    double corner2 = Math.Round((Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 57.2958), 2);
    double corner3 = Math.Round((Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 57.2958), 2);

    double type = 0;

    if (a == b || a == c || b == c)
    {
        type = 1;
        //Console.Write($"первый прошел ");
    }
    else if (a == b && a == c && b == c)
    {
        type = 0;
        //Console.Write($"второй прошел ");
    }
    else if (a != b && a != c && b != c)
    {
        type = 2;
        Console.Write($"третьий прошел ");
    }
    arVal[0] = perimetr;
    arVal[1] = square;
    arVal[2] = corner1;
    arVal[3] = corner2;
    arVal[4] = corner3;
    arVal[5] = type;

    return arVal;
}

bool i = TryFolse(a, b, c);
if (i == true)
{
    Console.WriteLine($"данный треугольни");
    double[] arrayValues = new double[6];
    arrayValues = ParamTriangle(a, b, c);
    string type = string.Empty;
    if (arrayValues[5] == 0)
        type = "равносторонний";
    else if (arrayValues[5] == 1)
        type = "равнобедренный";
    else if (arrayValues[5] == 2)
        type = "скалярный";

    Console.WriteLine(
        $"данный треугольник {type}, периметр {arrayValues[0]}, площадь: {arrayValues[1]} "
    );
    Console.WriteLine(
        $"Углы альфа {arrayValues[2]}, бетта {arrayValues[3]}, гамма {arrayValues[4]} "
    );
    //PrintArray(arrayValues);
}
else
    Console.WriteLine("Да не треугольник это!!!");
