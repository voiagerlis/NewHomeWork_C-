// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int[] arrayNum = new int[8];
Console.Clear();
Console.WriteLine("Заполните целочисленный массив из восьми злементов");
int num = 0;
string str = "";
for (int i = 0; i < 8; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    arrayNum[i] = num;
}
for (int i = 0; i < 8; i++)
{
    str = str + "," + arrayNum[i];
}
Console.WriteLine($"Ваш массив "+ str.Substring(1));
