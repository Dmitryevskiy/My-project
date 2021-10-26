Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "дима")
{
    Console.WriteLine("Привет красавчик!");
}    
else
{
    Console.Write("Привет!, ");
    Console.WriteLine(username);
}

