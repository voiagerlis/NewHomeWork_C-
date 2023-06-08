// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] Mixed(int[] helper)
{
    for (int i = helper.Length - 1; i >= 0; i--)
    {
        int n = new Random().Next(0, helper.Length - 1);
        int tmp = helper[n];
        helper[n] = helper[i];
        helper[i] = tmp;
    }
    return helper;
}
void FillRang(int[] array)
{
    int count = 10;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = count;
        count++;
    }
}
void FillArray(int[,,] array, int[] helper)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int n = 0; n < array.GetLength(2); n++)
            {
                array[i, j, n] = helper[count];
                count++;
            }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int p = 0; p < array.GetLength(2); p++)
                System.Console.Write($"{array[i, j, p], 3} ({i},{j},{p})     ");
        System.Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задайте размерность массивов");
int num = Convert.ToInt32(Console.ReadLine());
int[] helper = new int[90];
int[,,] matrix = new int[num, num, num];
FillRang(helper);
helper = Mixed(helper);
FillArray(matrix, helper);
PrintArray(matrix);
