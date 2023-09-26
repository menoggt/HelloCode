// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
/*int M = -N;
Console.WriteLine("Промежуток от " + M + " до " + N + ": ");
while (M <= N)
{
    if (M == -N)
        Console.Write("|" + M + ",");
    else if (M == N)
        Console.Write(M + "|");
    else if (M < N)
        Console.Write(M + ",");
    M += 1;
}*/
for (int i = N * (-1); i <= N; i++) // i = i + 1
    Console.Write(i + " ");