using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class RangerClass: HeroClass
    {
        public override string ClassName => "Ranger";
        public override int Str => 1;
        public override int Dex => 7;
        public override int Magic => 1;



        /// <summary>
        ///     Calculates player dmg based on class + lvl and weapon dmg
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int Damage(Player player)
        {
            return player.Damage + player.Dex;
        }

        public override void LevelUp(Player player)
        {
            player.Str += 1;
            player.Dex += 5;
            player.Magic += 1;

            player.Level++;
        }
    }
}

/*
    case "Mage":
                    player.Str += 1;
                    player.Dex += 1;
                    player.Magic += 8;
                    break;
                case "Archer":
                    player.Str += 1;
                    player.Dex += 7;
                    player.Magic += 1;
                    break;
                case "Rogue":
                    player.Str += 2;
                    player.Dex += 6;
                    player.Magic += 1;
                    break;
                case "Warrior":
                    player.Str += 5;
                    player.Dex += 2;
                    player.Magic += 1;
                    break;
                default:
                    break;
 
 */