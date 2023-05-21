// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//********************************************************************************
Console.WriteLine("Введите целочисленное число");
int num = Convert.ToInt32(Console.ReadLine());

/// Если число отрицательное привожу его к модулю
num = Math.Abs(num);
if (num == 10)
{
    Console.WriteLine("Сумма цифр в числе = 1");
    return;
}
/// Функция подсчета сумм цифр в числе
int LeghtNum(int repNum)
{
    int tmpNum = 0;
    while (repNum > 10)
    {
        tmpNum = tmpNum + repNum % 10;
        repNum = repNum / 10;
    }
    tmpNum = tmpNum + repNum;
    return tmpNum;
}

int result = LeghtNum(num);
Console.WriteLine($"Сумма цифр в числе = {result}");