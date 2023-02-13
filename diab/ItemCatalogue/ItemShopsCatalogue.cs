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
                Console.WriteLine("Choose a weapon.");
                string? selectedWeapon = Console.ReadLine();

                if (Int32.TryParse(selectedWeapon, out int selectedWeaponInt) && selectedWeapon != null && selectedWeaponInt > 0 && selectedWeaponInt < weaponsInInventory ) {

                    return selectedWeaponInt;                  
                }
                else
                {
                    Console.WriteLine("Please select a weaponType from 1-6");
                    continue;
                }              
            }
        }

        /// <summary>
        /// Loop enum and show data of armors types return user input
        /// </summary>
        /// <returns></returns>
        public static int ShowArmorsCatalogue()
        {
            int armorsInInventory = 1;
            while (true)
            {
                foreach (int i in Enum.GetValues(typeof(Armor.Armors)))
                {
                    armorsInInventory++;
                    Console.WriteLine($"{i}: {Enum.GetName(typeof(Armor.Armors), i)}");
                }
                Console.WriteLine("Choose an armor.");
                string? selectedArmor = Console.ReadLine();

                if (Int32.TryParse(selectedArmor, out int selectedArmorInt) && selectedArmor != null && selectedArmorInt > 0 && selectedArmorInt < armorsInInventory)
                {

                    return selectedArmorInt;
                }
                else
                {
                    Console.WriteLine("Please select an Armor from 1-6");
                    continue;
                }
            }
        }
      
  
       
    }
}
