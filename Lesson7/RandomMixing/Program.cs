//

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 99);
}
void FillArrayFlag(bool[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = false;
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
void PrnAr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i], 3}     ");
    System.Console.WriteLine();
}
int[] Generator(bool[,] arFlag, int rows, int cols)
{
    bool FlagNum1 = false;
    bool FlagNum2 = false;
    int[] MemoIdx = new int[4];
    while (FlagNum1 == false)
    {
        int x = new Random().Next(0, rows);
        int y = new Random().Next(0, cols);
        for (int i = 0; i < arFlag.GetLength(0); i++)
            for (int j = 0; j < arFlag.GetLength(1); j++)
            {
                if (arFlag[x, y] == false)
                {
                    MemoIdx[0] = x;
                    MemoIdx[1] = y;
                    FlagNum1 = true;
                    arFlag[x, y] = true;
                }
            }
    }

    while (FlagNum2 == false)
    {
        int x = new Random().Next(0, rows);
        int y = new Random().Next(0, cols);
        for (int i = 0; i < arFlag.GetLength(0); i++)
            for (int j = 0; j < arFlag.GetLength(1); j++)
            {
                if (arFlag[x, y] == false)
                {
                    MemoIdx[2] = x;
                    MemoIdx[3] = y;
                    FlagNum2 = true;
                    arFlag[x, y] = true;
                }
            }
    }

    return MemoIdx;
}
void PrintFlag(bool[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j], 5}     ");
        System.Console.WriteLine();
    }
}

int[,] MixArray(int[,] array, bool[,] arFlag, int rows, int cols)
{
    int[] helper = new int[4];
    int Proverka = (rows + 1) * (cols + 1);
    int count = 0;
    int tmp = 0;
    for (int g = 0; g < rows * cols / 2; g++)
    {
       
        helper = Generator(arFlag, rows, cols);
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            { 
                tmp = array[helper[0], helper[1]];
                Console.WriteLine($"*********  {tmp}");
                array[helper[0], helper[1]] = array[helper[2], helper[3]];
                array[helper[2], helper[3]] = tmp;
            }
    }

    return array;
}
Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows * cols % 2 == 0)
{
    bool[,] arrayFlag = new bool[rows, cols];
    int[,] array = new int[rows, cols];
    int[,] MixedArray = new int[rows, cols];
    int[] helperArray = new int[4];
    FillArrayFlag(arrayFlag);
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("*****************************************");
    MixedArray = MixArray(array, arrayFlag, rows - 1, cols - 1);
    //PrintFlag(arrayFlag);
    // PrnAr(helperArray);
    // PrintFlag(arrayFlag);
    PrintArray(MixedArray);
}
else
    Console.WriteLine(
        "Введите количество строк и коллонок, что бы количество элеиентов массива было четным"
    );
