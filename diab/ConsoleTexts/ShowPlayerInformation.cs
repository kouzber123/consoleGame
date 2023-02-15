using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class ShowPlayerInformation
    {

        /// <summary>
        /// Displays user status
        /// </summary>
        public static void ShowInformation(Player player)
        {
            
            Console.Clear();
            Console.WriteLine("Hero Current Status");
            player.TotalStats();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("PLAYER STATUS:");
            Console.WriteLine("Class: " + player.Class.ClassName);
            Console.WriteLine("Name: " + player.PlayerName);
            Console.WriteLine("Level: " + player.Level);
            Console.WriteLine("Total Status points: Str {0}, Dex {1}, Magic {2}",
                player.Class.TotalAttribute(player.Str, Armor.TotalAttribute(player, 1)),
                player.Class.TotalAttribute(player.Dex, Armor.TotalAttribute(player, 2)),
                player.Class.TotalAttribute(player.Magic, Armor.TotalAttribute(player, 3))
               );
             
            Console.WriteLine("Total level attributes: {0}", player.TotalStats());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("INVENTORY:");
            player.Slots();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

        }
    }
}
