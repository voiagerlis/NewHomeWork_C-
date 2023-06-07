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
int SortArray(int[] aNum, int indMin, int indMax)
{
    int pivot = indMin - 1;
    int tmpNum = 0;
    for (int i = indMin; i < indMax; i++)
    {
        if (aNum[i] < aNum[indMax])
        {
            pivot++;
            tmpNum = aNum[pivot];
            aNum[pivot] = aNum[i];
            aNum[i] = tmpNum;
        }
    }
    pivot++;
    tmpNum = aNum[pivot];
    aNum[pivot] = aNum[indMax];
    aNum[indMax] = tmpNum;
    return pivot;
}

int[] FastSort(int[] aNum, int indMin, int indMax)
{
    if (indMin >= indMax)
    {
        return aNum;
    }
    int pivot = SortArray(aNum, indMin, indMax);
    FastSort(aNum, indMin, pivot - 1);
    FastSort(aNum, pivot + 1, indMax);
    return aNum;
}
int[,] SArray(int[,] ar, int num)
{
    int[] arRow = new int[num];
    int[] helper = new int[num];
    int count = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
        for (int j = 0; j < ar.GetLongLength(1); j++)
            for (int p = i; p < ar.GetLongLength(1); p++)
                arRow[p] = ar[count, p];
    helper = FastSort(arRow, count, num - 1);
    for (int z = count; z < ar.GetLongLength(1); z++)
        ar[count, z] = helper[z];
    count++;
    return ar;
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
PrintArray(arNum);
