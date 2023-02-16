namespace diab
{
    internal class Program
    {

        /// <summary>
        /// init game set name,  lvl and choose class then pass it to the end functions 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {



            Player? player = new(SelectionScreen.PlayerGivenName(), 1, ChoosePlayerClass.ChooseClass())
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            HandleUserAction.HandleUserActions(player);


        }
    }
}