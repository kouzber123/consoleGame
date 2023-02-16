namespace diab
{
    public class WarriorClass: HeroClass
    {
        public override string ClassName => "Warrior";
        public override int Str => 5;
        public override int Dex => 2;
        public override int Magic => 1;
  
        readonly string[] armorType = {"Mail", "Plate", null, "" };
        readonly string[] weaponType = { "Sword", "Axe", "Hammer" };
        readonly List<string> itemTypes = new();


        /// <summary>
        /// Check if Class itemTypeList contains this value if not then false
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>    
        public override bool GearRestrictions(string item)
        {
            itemTypes.AddRange(armorType.Union(weaponType));
            if (itemTypes.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///     Calculates player dmg based on class + lvl and weapon dmg
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int Damage(Player player)
        {
            return (player.Weapon!.WeaponDamage == 0 ? 1 : player.Weapon.WeaponDamage)  * (1 + player.Str / 100);
        }

        /// <summary>
        /// Calculate total stats from player attributes leveling and item attributes um
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int TotalAttributes(Player player)
        {
          
                return (player.TotalStats() + player.Head!.TotalAttributes() + player.Body!.TotalAttributes() + player.Legs!.TotalAttributes());

        }


        /// <summary>
        /// Get indiviudal attribute e.g. player Magic + Item1 magic + item2 magic + item3magic
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="armorAttribute"></param>
        /// <returns></returns>
        public override int TotalAttribute(int attribute, int armorAttribute)
        {
            return attribute + armorAttribute;
        }

        /// <summary>
        /// Level up pass player class and increase its stats by specific amount + 1 lvl
        /// </summary>
        /// <param name="player"></param>
        public override void LevelUp(Player player)
        {
            player.Str += 3;
            player.Dex += 2;
            player.Magic += 1;
            player.Level++;
        }


    }
}
