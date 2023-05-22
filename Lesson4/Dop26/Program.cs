// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

/// Метод подсчета чисел при значении от 0 до 1 
int SummLessOne (double number)
{
    while (number <= 1)
    {
        num = num * 10;
        count++;
    }
}
return count;

//// Метод подсчета цифр целочисленног числа
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



Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
// привожу к модулю
num = Math.Abs(num);
int count = 0;

if (num < 1) 
SummLessOne(num);
else
if (num == 10)
{
    Console.WriteLine("Сумма цифр в числе = 1");
    return;
}



Console.WriteLine($"Сумма цифр в числе = {count}");
// else
// {
// int digitCount = Convert.ToInt32(Math.Log10(num) + 1);
// Console.WriteLine("Разрядность числа " + num + " равна " + digitCount);
// }



// Console.WriteLine("Введите целочисленное число");
// double num = Convert.ToDouble(Console.ReadLine());

// /// Если число отрицательное привожу его к модулю
// num = Math.Abs(num);
// // if (num == 10)
// // {
// //     Console.WriteLine("Сумма цифр в числе = 1");
// //     return;
// // }
// /// Функция подсчета сумм цифр в числе
// int LeghtNum(int repNum)
// {
//     int tmpNum = 0;
//     while (repNum > 10)
//     {
//         tmpNum = tmpNum + repNum % 10;
//         repNum = repNum / 10;
//     }
//     tmpNum = tmpNum + repNum;
//     return tmpNum;
// }

// int result = LeghtNum(num);
// Console.WriteLine($"Сумма цифр в числе = {result}");
