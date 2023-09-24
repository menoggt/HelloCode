void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index += 1;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position += 1;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index += 1;
    }
    return position;
}

int[] mas = new int[10];

FillArray(mas);
mas[3] = 4;
mas[5] = 4;
PrintArray(mas);
Console.WriteLine();

int pos = IndexOf(mas, 4);
if (pos == -1)
{
    Console.WriteLine("Не найдено");
}
else
{
    Console.WriteLine(pos);
}
