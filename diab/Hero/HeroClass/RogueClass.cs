namespace diab
{
    internal class RogueClass: HeroClass
    {
        public override string ClassName => "Rogue";
        public override int Str => 2;
        public override int Dex => 6;
        public override int Magic => 1;

        string[] weaponTypes = { "Bow" };
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
            player.Dex += 4;
            player.Magic += 1;


            player.Level++;
        }
    }
}
