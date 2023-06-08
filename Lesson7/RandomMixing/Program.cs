void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 99);
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
void Mixed(int[,] array)
{
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            int n = new Random().Next(0, array.GetLength(0) - 1);
            int m = new Random().Next(0, array.GetLength(1) - 1);
            int tmp = array[n, m];
            array[n, m] = array[i, j];
            array[i, j] = tmp;
        }
}
Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows * cols % 2 == 0)
{
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("*****************************************");
    Mixed(array);
    PrintArray(array);
}
else
    Console.WriteLine(
        "Введите количество строк и коллонок, что бы количество элеиентов массива было четным"
    );
