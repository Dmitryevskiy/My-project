Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "дима")
{
    Console.WriteLine("Привет Дима!");
}    
else
{
    Console.Write("Привет!, ");
    Console.WriteLine(username);
}

