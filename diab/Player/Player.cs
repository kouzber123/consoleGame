namespace diab
{
    /// <summary>
    /// Handles setting hero class and also player related mehods
    /// </summary>
    public class Player : Hero
    {
        public string PlayerName { get; set; }
        public string HeroClass { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Magic { get; set; }

        private Armor? _head;
        private Armor? _body;
        private Armor? _legs;
        private Weapon? _weapon;
        /// <summary>
        /// set name and stats based on class 
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="level"></param>
        /// <param name="heroClass"></param>
        public Player(string playerName, int level, HeroClass heroClass) : base(level, heroClass)
        {
            PlayerName = playerName;
            HeroClass = heroClass.ClassName;
            Str = heroClass.Str;
            Dex = heroClass.Dex;
            Magic = heroClass.Magic; 

        }

        /// <summary>
        /// Guard for weapon thor error if false
        /// </summary>
        public Weapon? Weapon { get { return _weapon; } set
            { 
                if(CheckItemType(value.WeaponTypes) != true)
                {
                    throw new InvalidWeaponException($"This {value.WeaponTypes} cannot be worn by {HeroClass}");
                }
                _weapon = value;
            } }
        /// <summary>
        /// Guard for armor thor error if false
        /// </summary>
        public Armor? Head
        {
            get { return _head; }
            set
            {
                if (CheckItemType(value.ArmorType) != true)
                {
                    throw new InvalidArmorException($"This {value.ArmorType} cannot be worn by {HeroClass}");
                }
                _head = value;
            }
        }
        /// <summary>
        /// Guard for armor thor error if false
        /// </summary>
        public Armor? Body {
            get { return _body; }
            set
            {
                if (CheckItemType(value.ArmorType) != true)
                {
                    throw new InvalidArmorException($"This {value.ArmorType} cannot be worn by {HeroClass}");
                }
                _body = value;
            }
        }
        /// <summary>
        /// Guard for armor thor error if false
        /// </summary>
        public Armor? Legs {
            get { return _legs; }
            set
            {
                if (CheckItemType(value.ArmorType) != true)
                {
                    throw new InvalidArmorException($"This {value.ArmorType} cannot be worn by {HeroClass}");
                }
                _legs= value;
            }
        }
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
            {"Weapon", _weapon.damage! == 0 ? null! : $"{_weapon.Name} Damage: {_weapon.WeaponDamage}" },
            { "Head", _head.Name! == null ? null! : $"{_head.Name} | Str:{_head.Str} | Dex: {_head.Dex} | Magic: {_head.Magic}"},
             {"Body", _body.Name! == null ? null! : $"{_body.Name}| Str:{_body.Str} | Dex: {_body.Dex} | Magic: {_body.Magic}"},
             {"Legs", _legs.Name! == null ? null! : $"{_legs.Name} | Str:{_legs.Str} | Dex: {_legs.Dex} | Magic: {_legs.Magic}"}
            };
            foreach (var gearSlot in gearSlots)
            {
                Console.WriteLine("{0} {1}", gearSlot.Key, gearSlot.Value);
            }
        }

        }
}


