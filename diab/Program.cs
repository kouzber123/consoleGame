using System.Numerics;

namespace diab
{
    internal class Program
    {
        static void Main(string[] args)
        {          
                Console.WriteLine("Hello, Adventurer!");
                Hero player = new();
                Console.WriteLine("Enter a name: ");
                player.HeroName = Console.ReadLine();
            while (true)
            {
                string? choise = SelectionScreen.ChooseHero();
                if (Int32.TryParse(choise, out int choiseToInt) && choiseToInt > 0 && choiseToInt <= 4)
                {
                    player.Class = PlayerClasses.PlayerClass(choiseToInt);
                    break;
                }
                else
                {
                    Console.WriteLine("Please press 1 - 4 to select a class");
                }
            }
            HandleUserAction.HandleUserActions(player);


        }
    }
}