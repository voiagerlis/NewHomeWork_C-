// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//********************

Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[n, n];
int k = 1;
int temp = 0;
int i,j=0;
int n1 = n;
while (k <= n1 * n1)
{
       for (i = temp; i < n; i++)
            mas[j, i] = k++;
        j=i-1;

        for (i = temp+1; i < n; i++)
            mas[i, j] = k++;

        for (i = n - 2; i >= temp; i--)
             mas[j, i] = k++;
        j=temp;

        for(i=n-2;i>temp;i--)
             mas[i, j] = k++;
        n--;
        temp++;
         j = temp;
}

for (i = 0; i < mas.GetLength(0); i++)
{
      for (j = 0; j < mas.GetLength(1); j++)
           Console.Write("{0,3} ", mas[i, j]);
      Console.WriteLine();
}
