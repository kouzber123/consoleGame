namespace diab
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Player player = new()
            {
                HeroName = SelectionScreen.PlayerGivenName()
                
            };
            while (true)
            {
                string? choise = SelectionScreen.ChooseHero();
                if (Int32.TryParse(choise, out int choiseToInt) && choiseToInt > 0 && choiseToInt <= 4)
                {
                    player.Class = PlayerClasses.PlayerClass(choiseToInt);
                    HeroAttribute.SetStatPoints(player);
                    player.ShowInformation();
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