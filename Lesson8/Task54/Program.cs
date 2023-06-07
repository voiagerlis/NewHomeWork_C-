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
void PrintArrayNegativ(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
            System.Console.Write($"{array[i, j], 3}     ");
        System.Console.WriteLine();
    }
}

int[] Sort(int[] A)
{
    for (int i = 0; i < A.Length-1; i++)
        for (int j = i; j >= 0; j--)
            if (A[j] > A[j + 1])
            {
                int t = A[j];
                A[j] = A[j + 1];
                A[j + 1] = t;
            }

    return A;
}
int[,] SArray(int[,] ar, int num)
{
    int[] arRow = new int[num];
    int[] hel = new int[num];
    int[,] helpArray = new int[ar.GetLength(0), ar.GetLength(1)];
    int count = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLongLength(1); j++)
            arRow[j] = ar[i, j];
        hel = Sort(arRow);
        for (int z = 0; z < ar.GetLongLength(1); z++)
            helpArray[count, z] = hel[z];
        count++;
    }

    return helpArray;
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int num = cols;
int[,] array = new int[rows, cols];
int[,] arNum = new int[rows, cols];
FillArray(array);
PrintArray(array);
arNum = SArray(array, cols);
Console.WriteLine("****** отсортирован *************");
PrintArrayNegativ(arNum);
