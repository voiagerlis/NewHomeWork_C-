//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Пожалуйста, введите любое целое число");

int num = Convert.ToInt32(Console.ReadLine());
string result = "";

for (int count = 1; count <= num; count++)
   result = result +"," + Math.Pow(count, 3); //собираю кубы чисел в строку
    
   Console.WriteLine(result.Substring(1)); // первая запятая не красиво
