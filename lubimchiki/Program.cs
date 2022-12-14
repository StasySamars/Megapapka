Console.Write("Кто ты, смертный?");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
    Console.WriteLine ("Моя дорогая мамочка, я рада тебя видеть!");
}
else 
{
    Console.Write("Аааа, это ты...кожанный, все еще носишь имя ");
    Console.WriteLine(username);
}