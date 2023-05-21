// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//********************************************************************************

Console.WriteLine("Введите целочисленное число отличное от нуля");
int num = Convert.ToInt32(Console.ReadLine());
int[] numArrey; //= new int [];

/// Если число отрицательное привожу его к модулю
num = Math.Abs(num);

/// Функция заполнения массива цифр из числа
//int LeghtNum(int repNum)
//{
int tmpNum = 0;
int index = 0;
while (num > 10)
{
    numArrey[index] = num % 10;
    num = num / 10;
    index++;
}
index++;
numArrey[index] = num;

//    Console.WriteLine($"tmp = {tmpNum}");
// Console.WriteLine($"rep = {repNum}");

//tmpNum = tmpNum + repNum;
//return tmpNum;
//}
// int SumNumber (int [] arrayN)
// {

// }
// int result = LeghtNum(num);
// Console.WriteLine($"Сумма цифр в числе = {result}");
