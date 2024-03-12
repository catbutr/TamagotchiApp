// See https://aka.ms/new-console-template for more information

using TamagotchiApp;
Console.WriteLine("Write down you tamogochi's name!");
var isMenuEnded = false;
var petName = Console.ReadLine();
if (petName == null)
{
    Console.WriteLine("Pet name cannot be empty!");
}
Pet newPet = new Pet(petName);
newPet.ConsoleOutput();
while (isMenuEnded == false)
{
    Console.WriteLine("Choose the command:");
    Console.WriteLine("1:Feed");
    Console.WriteLine("2:Play");
    Console.WriteLine("3:Sleep");
    var inputCommand = Console.ReadLine();
    var inputCommandInt = Convert.ToInt32(inputCommand);
    switch (inputCommandInt)
    {
        case 1:newPet.Feed(); newPet.ConsoleOutput();
            break;
        case 2:newPet.Play();newPet.ConsoleOutput();
            break;
        case 3:newPet.Play(); newPet.ConsoleOutput();
            break;
        default: Console.WriteLine("Incorrect Command"); break;
    }
}
