Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "глебастер")
{
    Console.WriteLine("Здарова Глебас!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);    
}
