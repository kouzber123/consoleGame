namespace diab
{
    /// <summary>
    /// Handles adisplaying weapons and armors
    /// </summary>
    internal class ItemShopsCatalogue
    {
        /// <summary>
        /// Loops enum data and return userinput
        /// </summary>
        /// <returns></returns>
        public static int ShowWeaponsCatalogue() 
        {
            int weaponsInInventory = 1;
            while (true)
            {
                foreach (int i in Enum.GetValues(typeof(WeaponType)))
                {
                    weaponsInInventory++;
                    Console.WriteLine($"{i}: {Enum.GetName(typeof(WeaponType), i)}");                  
                }
                
                try
                {
                    Console.WriteLine("Choose a weapon.");
                    int selectedWeapon = int.Parse(Console.ReadLine()!);
                    if (selectedWeapon > 0 && selectedWeapon < weaponsInInventory)
                    {

                        return selectedWeapon;
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter a correct number");
                }
            
                        
            }
        }

        /// <summary>
        /// Loop enum and show data of armors types return user input
        /// </summary>
        /// <returns></returns>
        public static int ShowArmorsTypeCatalogue()
        {
            int armorsInInventory = 1;
            while (true)
            {
                foreach (int i in Enum.GetValues(typeof(Armor.Armors)))
                {
                    armorsInInventory++;
                    Console.WriteLine($"{i}: {Enum.GetName(typeof(Armor.Armors), i)}");
                }
                try
                {
                    Console.WriteLine("Choose an armor.");
                    int selectedArmor = int.Parse(Console.ReadLine()!);

                    if (selectedArmor > 0 && selectedArmor < armorsInInventory)
                    {
                        return selectedArmor;
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please type a number from 1-4");
                }
             
              
            }
        }
      
  
       
    }
}
