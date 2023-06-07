// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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
int[,] ChekNum(int[,] array1, int[,] array2, int num)
{
    int[,] helper = new int[num, num];
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(1); j++)
            helper[i, j] = array1[i, j] * array2[i, j];
    return helper;
}
Console.Clear();
Console.WriteLine("Задайте размерность массивов");
int num = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[num, num];
int[,] matrix2 = new int[num, num];
int[,] resArray = new int[num, num];
FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine("------- Первая матрица -------");
PrintArray(matrix1);
Console.WriteLine("------- Вторая матрица -------");
PrintArray(matrix2);
resArray = ChekNum(matrix1, matrix2, num);
Console.WriteLine("----------- Результат --------");
PrintArray(resArray);
