// See https://aka.ms/new-console-template for more information
Console.Write("Имя, ");
string username = Console.ReadLine();

if (username.ToLower()=="маша")
{
    Console.WriteLine("Ура это же Маша!");
}
else 
{
    Console.Write("Привет,"+username);
}