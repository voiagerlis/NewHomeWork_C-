// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int FindSums(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; )
    {
        result = result + array[i];
        i = i + 2;
    }
    return result;
}
Console.Clear();
int[] array = new int[6];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);
int rez = FindSums(array);
System.Console.WriteLine(
    $"Сумма чисел элементов массива находящаяся на нечетных позициях равна {rez}");
