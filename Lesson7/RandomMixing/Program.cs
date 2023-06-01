//

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 100);
}
void FillArrayMinusOne(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = -1;
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

// int[] WriteArrayTmp(int[,] array, int num)
// {
//     int[] arTmp = new int[num];
//     int k = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j])
//             arTmp[k] = array[i, j];
//             k++;
//         }
//     return arTmp;
// }
// int[,] ReadArrayTmp(int[] array, int a, int b)
// {
//     int k = 0;
//     int[,] arTmp = new int[a, b];
//     for (int i = 0; i < arTmp.GetLength(0); i++)
//         for (int j = 0; j < arTmp.GetLength(1); j++)
//         {
//             arTmp[i, j] = array[k];
//             k++;
//         }
//     return arTmp;
// }
int[] Generator(int rows, int cols);
{
    int [] MemoIdx = new int [4]
    int[] MemoIdxRows = new int[2];
    int[] MemoIdxCols = new int [2];
    for (int i=0; i==1;i++)
    int MemoIdxRows[i] = new Random().Next(0,rows);
    int MemoIdxCols[i] = new Random().Next(0,cols); 
    for (int j =0; )
    
    
    return RandomNum;
}






Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int num = rows * cols ;
int[,] array = new int[rows, cols];
int[,] arNum = new int[rows, cols];
FillArrayMinusOne(arNum);

//PrintArray(arNum);
Generator(array, arNum,rows);
FillArray(array);
PrintArray(array);
// arNum = WriteArrayTmp(array, num);
// array = ReadArrayTmp(arNum, rows, cols);
// Console.WriteLine("**** Отсортированный ***********");
// PrintArray(array);
