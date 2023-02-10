using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    public class SelectionScreen
    {

        /*
         RETURNS VALUE FOR USER
         */
        public static string? ChooseHero()
        {
            Console.WriteLine("Choose a class: ");
            Console.WriteLine("(1) Mage: ");
            Console.WriteLine("(2) Rogue: ");
            Console.WriteLine("(3) Archer: ");
            Console.WriteLine("(4) Warrior: ");
            return Console.ReadLine();
        }

        /*
         * ACTION UI TO SHOW WHAT USER CAN DO
         */
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


        /*
         TEMPLATE FOR SHOWING SHOP CONTENT
         */
        public static void ShowShopItems(string name1, int lvl, int dmg)
        {
            Console.WriteLine($"Name: {name1}  lvl requirement: {lvl} dmg: {dmg} ");
            
        }
        /*
         * DISPLAY ITEMS PLAYER CAN CHOOSE FROM
         * **/
        
        public static void ShowAcquiredItem( string player,  string weapon)
        {
            Console.WriteLine("YOU HAVE ACQUIRED A NEW A WEAPON {0}", player);
            Console.WriteLine("Your current weapontype: {0}", weapon);
            Console.ReadKey();
        }
    }
}
