namespace diab
{   public class SelectionScreen
    {
        /// <summary>
        /// Handles user name input with min len of  2
        /// </summary>
        /// <returns></returns>
        public static string PlayerGivenName()
        {
            while (true)
            {
                Console.WriteLine("Hello, Adventurer!");
                Console.WriteLine("Enter a name: ");
               string? name =  Console.ReadLine();
                if(name?.Length > 2)
                {
                    return name;
                }
                continue;
            }     
        }

       /// <summary>
       /// Starting screen
       /// </summary>
        public static void ChooseHero()
        {
            Console.WriteLine("Choose a class: ");
            Console.WriteLine("(1) Mage: ");
            Console.WriteLine("(2) Rogue: ");
            Console.WriteLine("(3) Archer: ");
            Console.WriteLine("(4) Warrior: ");
          
        }

        /// <summary>
        /// Action controoler list
        /// </summary>
        /// <returns></returns>
        public static string? ActionList()
        {
            Console.WriteLine("Please select an action");
            Console.WriteLine("(1) Fight to level up");
            Console.WriteLine("(2) Equip a gear");
            Console.WriteLine("(3) Damage");
            Console.WriteLine("(4) Total Attributes");
            Console.WriteLine("(5) Show Status");
            Console.WriteLine("(6) Quit Game");

            return Console.ReadLine();
        }

        /// <summary>
        /// show when player equips a gear
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="gear"></param>
        public static void ShowAcquiredItem( string itemName,  string gear)
        {
            Console.WriteLine("YOU HAVE ACQUIRED A NEW Item {0}", itemName);
            Console.WriteLine("Your current Itemtype: {0}", gear);
        }
       
     
    }
}
