// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три целых числа: ");
int[] nums = new int[3];
int max = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"\nВведите число номер {i+1}:\t ");
    nums[i] = int.Parse(Console.ReadLine());
}
for (int n = 0; n < nums.Length; n++)
{
    if (nums[n] > max)
    {
        max = nums[n];  
    }
}
Console.WriteLine("\nМаксимальное число равно: " + max);