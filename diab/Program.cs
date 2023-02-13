namespace diab
{
    internal class Program
    {

        /// <summary>
        /// Starting file character is init by name
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            Player player = new()
            {
                HeroName = SelectionScreen.PlayerGivenName()            
            };     
            while (true)
            {
                Console.WriteLine("Please press 1 - 4 to select a class");
                try
                {
                    SelectionScreen.ChooseHero();
                    int choise = int.Parse(Console.ReadLine());
                    if (choise > 0 && choise <= 4)
                    {
                        player.Class = PlayerClasses.PlayerClass(choise);
                        HeroAttribute.SetStatPoints(player);
                        player.ShowInformation();
                        break;
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Invalid Input please enter a number");
                }
              
            }
           
        
            HandleUserAction.HandleUserActions(player);


        }
    }
}