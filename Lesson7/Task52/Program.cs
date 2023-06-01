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
            System.Console.Write($"{array[i, j],3}     ");
        System.Console.WriteLine();
    }
}
void PrA(double[] array)
{
    for (int i = 0; i < array.Length; i++)

        System.Console.Write($"{array[i],3}     ");
    System.Console.WriteLine();
}

double[] ArMean(int[,] array, int num)
{
    int endRows = array.GetLength(0);
    int endCols = array.GetLength(1);
    double[] helper = new double[num];
<<<<<<< HEAD
    double sum = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLongLength(1) ; j++)
            if (i+j == i)
            sum = sum + array[j,i];
            // {
            //     sum = 0;
            //     for (int j = count; j == i; j++)
            //     {//Console.WriteLine(array[i, j]);
            //         sum = sum + array[i, j];

            //         Console.WriteLine(sum);
            //     }
            //     count++;
            //     helper[i] = Math.Round(sum, 2);
            // }

            return helper;
=======

    for (int i = 0; i < endCols; i++)
    {
      double  sum = 0;
        for (int j = 0; j < endRows; j++)
            sum = sum + array[j, i];
        helper[i] = Math.Round(sum / endRows, 2);
    }
    return helper;
>>>>>>> ba497855c726a5f6de9c057ad5bcf39b21c0a51b
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
