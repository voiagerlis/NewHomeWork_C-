
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//********************
// 00 01 02 03 
// 10 11 12 13 
// 20 21 22 23
// 30 31 32 33
// num * num - сторона
void Snail(int[,] array)
{
    int num = array.GetLength(0);
    int count = 0;
    int j = 0;
    for (int i = 0; i < num; i++)// 0 строка слева на право
    {
        array[j, i] = count++;
    }
    for (int k = 1; k <= num - 1; k++) // последний столбец вниз
    {
        array[k, num - 1] = count++;
    }
    for (int p = num-1; p >= 0; p--) // последняя строка с права на лево 
    {
       array[num-1 , p] = count++;
    }
    for (int y = num-1; y >=num-2;y--)
    {
        array[0,num-2]=count++;
    }
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
Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[num, num];
Snail(array);
PrintArray(array);
// Console.WriteLine("Введите размерность массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] mas = new int[n, n];
// int k = 1;
// int temp = 0;
// int i,j=0;
// int n1 = n;
// while (k <= n1 * n1)
// {
//        for (i = temp; i < n; i++)
//             mas[j, i] = k++;
//         j=i-1;
//         for (i = temp+1; i < n; i++)
//             mas[i, j] = k++;
//         for (i = n - 2; i >= temp; i--)
//              mas[j, i] = k++;
//         j=temp;
//         for(i=n-2;i>temp;i--)
//              mas[i, j] = k++;
//         n--;
//         temp++;
//          j = temp;
// }

// for (i = 0; i < mas.GetLength(0); i++)
// {
//       for (j = 0; j < mas.GetLength(1); j++)
//            Console.Write("{0,3} ", mas[i, j]);
//       Console.WriteLine();
// }

