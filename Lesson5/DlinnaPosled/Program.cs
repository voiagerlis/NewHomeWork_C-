// Имеется массив случайных целых чисел. Создайте массив, в который попадают числа, описывающие
// максимальную сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.


int LengthSequence(int[] aNum, int num)
{
    int[] arrayTmp = new int[num];
    for (int x = 0; x < arrayTmp.Length; x++)
    {
        arrayTmp[x] = 1;
    }
    int[] Dlinna = new int[num];
    int maxLen = arrayTmp[0];
    for (int i = 1; i < aNum.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (aNum[i] > aNum[j] && arrayTmp[i] <= arrayTmp[j])
            {
                arrayTmp[i] = arrayTmp[i] + 1;
            }
        }
    }
    for (int k = 1; k < arrayTmp.Length; k++)
    {
        if (maxLen < arrayTmp[k])
            maxLen = arrayTmp[k];
    }

    int tmpMax = maxLen;
    for (int i = arrayTmp.Length - 1; i >= 1; i--)
    {
        if (arrayTmp[i] == tmpMax)
        {
            Dlinna[i] = aNum[i];
            tmpMax--;
        }
    }
    string b = string.Empty;
    for (int i = 0; i < Dlinna.Length; i++)
        if (Dlinna[i] != 0)
        {
            b = b  + Dlinna[i] + ",";
        }
    System.Console.WriteLine($"Получилась следующая непрерывная возрастающая последовательность: {b}");
    return maxLen;
}
int [] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {array[i] = new Random().Next(1, 99);}
        return array;

}
void PrintArray(int[] array)
{
    foreach (int item in array)

        Console.Write($"{item} ");
}
Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrayNew = new int[num];
arrayNew = FillArray(arrayNew);
Console.Clear();
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(arrayNew);
System.Console.WriteLine("");
int rez = LengthSequence(arrayNew, num);
System.Console.WriteLine($"Длинна последовательности = {rez}");
