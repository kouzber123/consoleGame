using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class ItemShopsCatalogue
    {
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
        public static void PlayerChoiseOfWeapon(ref int chosenItem, ref Weapon weapon, ref string weapon1, ref string weapon2, ref string weapon3, ref int lvlreq1, ref int lvlreq2, ref int lvlreq3, ref int damage1, ref int damage2, ref int damage3) 
        {
            if (chosenItem == 1)
            {
                PlayerSelectedGear.SetWeapon(weapon, weapon1, lvlreq1, damage1);
            }
            if (chosenItem == 2)
            {
                PlayerSelectedGear.SetWeapon(weapon, weapon2, lvlreq2, damage2);
            }
            if (chosenItem == 3)
            {
                PlayerSelectedGear.SetWeapon(weapon, weapon3, lvlreq3, damage3);
            }
        } 
        public static void PlayerChoiseOfArmor(ref int chosenItem, ref Armor armor, ref string gear1, ref string gear2, ref string gear3, ref int lvlreq1, ref int lvlreq2, ref int lvlreq3, ref int defense1, ref int defense2, ref int defense3) 
        {
            if (chosenItem == 1)
            {
                PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
            }
            if (chosenItem == 2)
            {
                PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
            }
            if (chosenItem == 3)
            {
                PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
            }
        }
    }
}
