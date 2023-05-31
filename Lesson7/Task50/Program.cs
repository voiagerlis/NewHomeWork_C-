// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
int[] ChekNum(int[,] array, int numer)
{
    int[] helper = new int[3];
    helper[2] = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (numer == array[i, j])
            {
                helper[0] = i;
                helper[1] = j;
                helper[2] = 1;
            }
        }
    }
    return helper;
}
Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
int[] arNum = new int[2];
FillArray(array);
PrintArray(array);
arNum = ChekNum(array, num);
if (arNum[2] == 1)
    Console.WriteLine(
        $"Позиция введенного числа в данном массиве строка {arNum[0]} столбец {arNum[1]}"
    );
else
    Console.WriteLine("Такого числа в массиве нет");
