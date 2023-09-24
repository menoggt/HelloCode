int[] mas = {15,66,267,76,40,75,66,57,38,92,10};

int n = mas.Length;
int find = 66;

int index = 0;

while (index < n)
{
    if (mas[index] == find)
    {
        Console.WriteLine("Индекс числа: " + index);
        break;
    }
    index += 1;
}