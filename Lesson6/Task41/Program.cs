// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите размерность массива чисел");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [num];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите чисело  ");
    array [i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}
int Counting (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}
Console.Clear();
Console.Write("Ваш массива чисел: " );
PrintArray(array);
int cou = Counting(array);
Console.WriteLine($"количество чисел более нуля:- {cou} " );