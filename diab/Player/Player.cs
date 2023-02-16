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
        public Weapon? Weapon { get; set; }
        public Armor? Head { get; set; }
        public Armor? Body { get; set; }
        public Armor? Legs { get; set; }
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
            {"Weapon", Weapon.damage! == 0 ? null! : $"{Weapon.Name} Damage: {Weapon.WeaponDamage}" },
            { "Head", Head.Name! == null ? null! : $"{Head.Name} | Str:{Head.Str} | Dex: {Head.Dex} | Magic: {Head.Magic}"},
             {"Body", Body.Name! == null ? null! : $"{Body.Name}| Str:{Body.Str} | Dex: {Body.Dex} | Magic: {Body.Magic}"},
             {"Legs", Legs.Name! == null ? null! : $"{Legs.Name} | Str:{Legs.Str} | Dex: {Legs.Dex} | Magic: {Legs.Magic}"}
            };
            foreach (var gearSlot in gearSlots)
            {
                Console.WriteLine("{0} {1}", gearSlot.Key, gearSlot.Value);
            }
        }

        }
}


