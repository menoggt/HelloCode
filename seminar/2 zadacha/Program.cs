// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет



Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("квадрат этого числа равен: ");
int k = Convert.ToInt32(Console.ReadLine());
if (n * n == k)
{
    Console.WriteLine("Истина");
}
else
{
    Console.WriteLine("Ложь");
}