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

        readonly List<string> weaponTypes = new();
        readonly List<string> armorTypes = new();
        public override string ArmorRestrictions(string armor) //cloth
        {
            armorTypes.AddRange(armorType);

            return armorTypes.Find(x => x == armor); //return if doesnt exist here
        }
       
        public override string WeaponRestrictions(string weapon)
        {
            weaponTypes.AddRange(weaponType);
            return weaponTypes.Find(x => x == weapon);
            
        }
        
        /// <summary>
        ///     Calculates player dmg based on class + lvl and weapon dmg
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int Damage(Player player)
        {
            return player.Damage + player.Magic;
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
