// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
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
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 100);
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
void PrA(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        System.Console.Write($"{array[i], 3}     ");
    System.Console.WriteLine();
}
int[] WriteArrayTmp(int[,] array, int num)
{
    int[] arTmp = new int[num];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arTmp[k] = array[i, j];
            k++;
        }
    return arTmp;
}
int[,] ReadArrayTmp(int[] array, int a, int b)
{
    int k = 0;
    int[,] arTmp = new int[a, b];
    for (int i = 0; i < arTmp.GetLength(0); i++)
        for (int j = 0; j < arTmp.GetLength(1); j++)
        {
            arTmp[i, j] = array[k];
            k++;
        }
    return arTmp;
}
Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int num = rows * cols;
int[,] array = new int[rows, cols];
int[] arNum = new int[num];
FillArray(array);
PrintArray(array);
arNum = WriteArrayTmp(array, num);
arNum = FastSort(arNum, 0, num - 1);
array = ReadArrayTmp(arNum,rows,cols);
//PrA(arNum);
Console.WriteLine("**** Отсортированный ***********");
PrintArray(array);
