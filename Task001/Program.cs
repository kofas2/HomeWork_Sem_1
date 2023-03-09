// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 'a': ");
int numA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число 'b': ");
int numB = Convert.ToInt32 (Console.ReadLine());
if (numA<numB)
{
    Console.WriteLine("Большее число равно: " + numB);
    Console.WriteLine("Меньшее число равно: " + numA);
}
else 
{
    Console.WriteLine("Большее число равно: " + numA);
    Console.WriteLine("Меньшее число равно: " + numB);
}