// See https://aka.ms/new-console-template for more information

using TamagotchiApp;

Console.WriteLine("Write down you tamogochi's name!");
string? petName = Console.ReadLine();
if (petName == null)
{
    Console.WriteLine("Pet name cannot be empty!");
}
Pet newPet = new Pet(petName);
newPet.ConsoleOutput();