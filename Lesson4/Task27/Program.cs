// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//********************************************************************************

Console.WriteLine("Введите целочисленное число отличное от нуля");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0)
/// Проверяю условия нуля
{
    Console.WriteLine("Вы ввели нуль");
    return;
}

/// Если число отрицательное привожу его к модулю
num = Math.Abs(num);

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
