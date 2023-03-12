Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") //перевод символов в нижний регистр
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    //Console.Write("Привет, ", username);
    Console.Write($"Привет, {username}");
    //Console.Write("Привет, ");
    //Console.WriteLine(username);
}