using System.Collections.Immutable;

namespace diab
{
    internal class MageClass : HeroClass
    {
        public override string ClassName => "Mage";
        public override int Str => 1;
        public override int Dex => 1;
        public override int Magic => 8;

        readonly string[] armorType = { "Cloth" };
        readonly string[] weaponType = { "Staff", "Wand" };

        readonly List<string> itemTypes = new();

        public override string GearRestrictions(string item)
        {
            itemTypes.AddRange(armorType.Union(weaponType));
            return itemTypes.Find(x => x == item)!;
        }


        /// <summary>
        ///     Calculates player dmg based on class + lvl and weapon dmg
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int Damage(Player player)
        {
            return (player.Weapon!.WeaponDamage == 0 ? 1 : player.Weapon.WeaponDamage) * (1 + player.Magic / 100);
        }

        public override int TotalAttributes(Player player)
        {
            if (player.Head == null && player.Body == null && player.Legs == null)
            {
                return player.TotalStats();
            } 
            if (player.Head != null && player.Body == null && player.Legs == null)
            {
                return player.TotalStats() + player.Head.TotalAttributes();
            } 
            if (player.Head != null && player.Body != null && player.Legs == null)
            {
                return player.TotalStats() + player.Head!.TotalAttributes() + player.Body!.TotalAttributes();
            }
            else
            {
                return (player.TotalStats() + player.Head!.TotalAttributes() + player.Body!.TotalAttributes() + player.Legs!.TotalAttributes());
            }

        }

        public override int TotalAttribute(int attribute, int armorAttribute)
        {
            return attribute + armorAttribute;
        }
        public override void LevelUp(Player player)
        {
            player.Str +=1;
            player.Dex +=1;
            player.Magic +=5;

            player.Level++;
        }

    }
}
