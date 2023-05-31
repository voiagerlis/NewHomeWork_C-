// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
void PrA(double[] array)
{
    for (int i = 0; i < array.Length; i++)

        System.Console.Write($"{array[i], 3}     ");
    System.Console.WriteLine();
}

double[] ArMean(int[,] array, int num)
{
    double[] helper = new double[num];
    double sum = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (count < array.GetLength(1))
        {
            Console.WriteLine(array[i, count]);
            sum = array[i, count];
        }
        else
        {
            count++;
            helper[i] = sum;
            sum = 0;
        }
    }
    // {
    //     sum = 0;
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         sum = sum + array[j, i];

    //     }
    //     sum = sum / array.GetLength(1);
    //     helper[i] = Math.Round(sum, 2);
    // }

    return helper;
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int num = cols;

int[,] array = new int[rows, cols];
double[] arNum = new double[num];
FillArray(array);
PrintArray(array);
arNum = ArMean(array, num);
Console.WriteLine("**********************************");
PrA(arNum);
