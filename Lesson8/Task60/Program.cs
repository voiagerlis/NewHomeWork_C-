// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// bool ChekChek(int[] ar, int n)
// {
//     bool flag = false;
//     for (int i = 0; i < ar.Length; i++)
//         if (n == ar[i])
//             flag = true;
//     return flag;
// }
int Ran()
{
    int rand = new Random().Next(0, 9);
    return rand;
}
int FillNum(int size, int count)
{
    int[] helpArray = new int[size];
    int randN = Ran();
    for (int i = 0; i < helpArray.Length; i++)
        if (randN != helpArray[i])
            helpArray[count] = randN;
        else
            Ran();
    return randN;
}
void FillArray(int[,,] array, int size)
{
    int rand = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int p = 0; p < array.GetLength(2); p++)
                array[i, j, p] = FillNum(size, count);
    count++;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int p = 0; p < array.GetLength(2); p++)
                System.Console.Write($"{array[i, j, p], 3}     ");
        System.Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задайте размерность массивов");
int num = Convert.ToInt32(Console.ReadLine());
int sizeHelper = num * num * num;
int[,,] matrix = new int[num, num, num];
FillArray(matrix, sizeHelper);
PrintArray(matrix);
