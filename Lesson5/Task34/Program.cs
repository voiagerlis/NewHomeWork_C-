//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Не выдумывал помянял пару строк из кода разбираемого на семинаре
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
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
    foreach (int item in array)
        if (item % 2 == 0)
        {
            result++;
        }
    return result;
}
Console.Clear();
int[] array = new int[4];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);
int rez = FindSums(array);
System.Console.WriteLine($"Число четных элементов массива равно {rez}");

