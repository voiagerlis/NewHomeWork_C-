// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

// Метод подсчета количества цифр числа

int LeghtNum(decimal repNum)
{
    int res = 0, count = 0, counter = 0; 
    decimal integerNum = repNum;
    // подсчитываю цифры целой части числа
    integerNum = integerNum - (integerNum % 1);
    int intNum = Convert.ToInt32(integerNum);
    while (intNum > 10)
    {
        intNum = intNum / 10;
        count++;
    }
    count++;
    // если число вещественное подсчитываю количество цифр после запятой
    if (repNum % 1 != 0)
    {
        decimal doubleNum = repNum;
        while (doubleNum != 0)
        {
            doubleNum = (doubleNum * 10) % 10;
            counter++;
        }
        counter--;
    }
    // Ссумирую результат целого и дробной части числа
    res = count + counter;
    return res;
}
Console.Clear();
Console.WriteLine("Введите число");
decimal num = Convert.ToDecimal(Console.ReadLine());
int resalt = 0;

// привожу к модулю
num = Math.Abs(num);

resalt = LeghtNum(num);

Console.WriteLine($"Количество цифр в числе = {resalt}");
