namespace diab
{
    /// <summary>
    /// Handles setting hero class and also player related mehods
    /// </summary>
    public class Player : Hero
    {
        public string PlayerName { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Magic { get; set; }

        private string? weapon = null;
        private int damage = 0;
        private int defense = 0;
        private string? head = null;
        private string? body = null;
        private string? legs = null;

        /// <summary>
        /// set name and stats based on class 
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="level"></param>
        /// <param name="heroClass"></param>
        public Player(string playerName, int level, HeroClass heroClass) : base(level, heroClass)
        {
            PlayerName = playerName;
            Str = heroClass.Str;
            Dex = heroClass.Dex;
            Magic = heroClass.Magic;

        }
        public string? Weapon { get => weapon; set => weapon = value; }
        public new int Damage { get => damage; set => damage = value; }
        public int Defense { get => defense; set => defense = value; }
        public string? Head { get => head; set => head = value; }
        public string? Body { get => body; set => body = value; }
        public string? Legs { get => legs; set => legs = value; }

        /// <summary>
        /// Show player total stats
        /// </summary>
        public int TotalStats()
        {
            return Str + Dex + Magic;
        }

        /// <summary>
        /// Display current equipped gear, also dictioray
        /// </summary>
        public void Slots()
        {
            var gearSlots = new Dictionary<string, string>(){
            {"Weapon", weapon! },
             {"Head", head!},
             {"Body", body!},
             {"Legs", legs!}
            };
            foreach (var gearSlot in gearSlots)
            {
                Console.WriteLine("{0} {1}", gearSlot.Key, gearSlot.Value);
            }
        }

    }
}


