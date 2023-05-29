// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1,
//                                       0-21  13  -8  5  -3  2  -1  1
//                                          0, 1, 1, 2, 3, 5, 8, 13, 21]
//                                          0 1  1   2 3  5  8  13  21
//                                       0-21 13 -8 5 -3 2 -1 1
// F−1 = 1,
// F−2 = -1,
// Fn = F(n+2)−F(n+1).


int[] Fibonachi(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
int[] NegFibonachi(int[] array, int num)
{
    num = num - 1;
    int[] arrayNeg = new int[num];
    arrayNeg[num - 1] = 1;
    arrayNeg[num - 2] = -1;
    for (int k = num - 3; k >= 0; k--)
    {
        arrayNeg[k] = arrayNeg[k + 2] - arrayNeg[k + 1];
    }
    return arrayNeg;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
}

Console.Clear();
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] fibo = new int[num];
int[] netfibo = new int[num];
fibo = Fibonachi(num);
netfibo = NegFibonachi(fibo, num);
PrintArray(netfibo);
PrintArray(fibo);
