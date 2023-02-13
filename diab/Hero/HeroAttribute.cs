namespace diab
{
    public abstract class HeroAttribute
    {
        /*
         methods to add 2  instances together and return the or increa the one instance by speciefied amount
         
         */


        public int Str { get; set; }
        public int Dex { get; set; }
        public int Magic { get; set; }

        /// <summary>
        /// Takes hero class object and sets starting stats related to class and set lvl to 1 
        /// </summary>
        /// <param name="hero"></param>
        public static void SetStatPoints(Player player)
        {
            player.Level = 1;
            switch (player.Class)
            {
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
            }
        }


    }
}
