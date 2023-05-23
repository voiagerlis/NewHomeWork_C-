//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 99);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] FindSums(int[] array)
{
    int sumNum = array[0];
    int numMax = array[0];
    int indxMax = 0;
    int numMin = array[0];
    int indxMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (numMax < array[i])
        {
            numMax = array[i];
            indxMax = i;
        }
        if (numMin > array[i])
        {
            numMin = array[i];
            indxMin = i;
        }
        sumNum = sumNum + array[i];
    }
    int lengthSum = array.Length;
    int[] result = { numMax, indxMax, numMin, indxMin, sumNum, lengthSum };
    return result;
}

Console.Clear();
int[] array = new int[9];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);
int[] rez = FindSums(array);
double medium = rez[4] / rez[5];
System.Console.WriteLine(
    $"максимального число = {rez[0]} / индекс [{rez[1]}] минимальное = {rez[2]} / индекс [{rez[3]}] "
);
System.Console.WriteLine(
    $"Сумма чисел массива = {rez[4]}, количество элементов = {rez[5]}, среднее арифметическое ={medium}"
);
