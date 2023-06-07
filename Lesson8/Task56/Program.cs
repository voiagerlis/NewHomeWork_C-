// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 9);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j], 3}     ");
        System.Console.WriteLine();
    }
}
void PrAr(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i], 3}  ");
        System.Console.WriteLine();
    }
}

int SumRows(int[] A)
{
    int sum = 0;
    for (int i = 0; i < A.Length; i++)
        sum += A[i];
    return sum;
}
int[] SArray(int[,] ar, int num)
{
    int[] arRow = new int[num];
    int hel = 0;
    int[] helpArray = new int[num];
    int count = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLongLength(1); j++)
            arRow[j] = ar[i, j];
        hel = SumRows(arRow);
        helpArray[count] = hel;
        count++;
    }

    return helpArray;
}
int[] MaxSum(int[] array)
{
    int[] maxS = new int[2];
    int m = array[0];
    for (int i = 0; i < array.Length; i++)
        if (m < array[i])
        {
            m = array[i];
            maxS[0] = array[i];
            maxS[1] = i;
        }
    return maxS;
}
Console.Clear();
Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());
int num = rows;
int[,] array = new int[num, num];
int[] arNum = new int[num];
int[] maxim = new int[2];
FillArray(array);
PrintArray(array);
arNum = SArray(array, num);

//PrAr(arNum);

//       Console.WriteLine($"count = {count}");
maxim = MaxSum(arNum);

//PrAr(maxim);
Console.WriteLine($"Наибольшая сумма: {maxim[0]} строка: {maxim[1] + 1}");
