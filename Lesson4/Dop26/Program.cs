// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

// Метод подсчета количества цифр числа

int LeghtNum(decimal repNum)
{
    int res = 0;
    int count = 0;
    int counter = 0;
    decimal integerNum = repNum;
    integerNum = integerNum - (integerNum % 1);
    int intNum = Convert.ToInt32(integerNum);
    while (intNum > 10)
    {
        intNum = intNum / 10;
        count++;
    }
    count++;
    if (repNum % 1 != 0)
    {
        double i = 0.1;
        double doubleNum = Convert.ToDouble(repNum);
        doubleNum = doubleNum % 1  ;
        Console.WriteLine($" Дробное число = {doubleNum}");
        while (doubleNum > 0)
        {
            doubleNum = doubleNum % i;
            counter++;
            Console.WriteLine($" Дробное число = {doubleNum}");
        }
    }
    res = count + counter;
    return res;
}


Console.WriteLine("Введите число");
decimal num = Convert.ToDecimal(Console.ReadLine());
int resalt = 0;
// привожу к модулю
num = Math.Abs(num);

resalt = LeghtNum(num);

Console.WriteLine($"Количество цифр в числе = {resalt}");
