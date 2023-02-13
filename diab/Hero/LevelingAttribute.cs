using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class LevelingAttribute
    {
        /// <summary>
        /// Handles level up and stats increase
        /// </summary>
        /// <param name="hero"></param>
        public static void LevelUp(ref Player player)
        {
            switch (player.Class)
            {
                case "Mage":
                    player.Str += 1;
                    player.Dex += 1;
                    player.Magic += 5;
                    break;
                case "Archer":
                    player.Str += 1;
                    player.Dex += 5;
                    player.Magic += 1;
                    break;
                case "Rogue":
                    player.Str += 1;
                    player.Dex += 4;
                    player.Magic += 1;
                    break;
                case "Warrior":
                    player.Str += 3;
                    player.Dex += 2;
                    player.Magic += 1;
                    break;
                default:
                    break;
            }

            player.Level++;

        }
    }
}
