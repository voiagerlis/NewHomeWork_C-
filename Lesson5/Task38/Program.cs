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
    int numMax = array[0];
    int numMin = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (numMax < array[i])
        {
            numMax = array[i];
        }
        if (numMin > array[i])
        {
            numMin = array[i];
        }
    }
    int[] result = { numMax, numMin };
    return result;
}

Console.Clear();
int[] array = new int[18];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);
int[] rez = FindSums(array);
System.Console.WriteLine(
    $"Разница чисел максимального = {rez[0]} и минимального = {rez[1]} значения массива равна {rez[0] - rez[1]}");
