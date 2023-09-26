// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите день недели (число): ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Наименование дня недели: ");
if(d == 1)
{
    Console.WriteLine("Monday");
}
else if(d == 2)
{
    Console.WriteLine("Tuesday");
}
else if(d == 3)
{
    Console.WriteLine("Wednesday");
}
else if(d == 4)
{
    Console.WriteLine("Thursday");
}
else if(d == 5)
{
    Console.WriteLine("Friday");
}
else if(d == 6)
{
    Console.WriteLine("Saturday");
}
else if(d == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Неверно (Введите число от 1 до 7).");
}