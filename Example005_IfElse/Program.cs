Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "григорий") 
{
    Console.WriteLine("Hi, Greg! I'm glad to see you!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}