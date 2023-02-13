namespace diab
{
    public abstract class Hero : HeroAttribute
    {

        public string? HeroName { get; set; } //tom
        public string? Class { get; set; } //warrior
        public int Level { get; set; }  // 10

        public int LevelAttributes { get; set; }  // base + 3 / 2 / 1 * 10 times
        private int totalStats;

        private string? weapon = null;
        private int damage = 0;
        private int defense = 0;
        private string? head = null;
        private string? body = null;
        private string? legs = null;

        public string? Weapon { get => weapon; set => weapon = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Defense { get => defense; set => defense = value; }
        public string? Head { get => head; set => head = value; }
        public string? Body { get => body; set => body = value; }
        public string? Legs { get => legs; set => legs = value; }

        /// <summary>
        /// Show player total stats
        /// </summary>
        public void TotalStats()
        {
            totalStats = Str + Dex + Magic;
        }

        
        /// <summary>
        /// Show total damage based on class 
        /// </summary>
        /// <param name="playerClass"></param>
        /// <returns></returns>
        public int GetTotalDamage(string playerClass)
        {
            if (playerClass == "Warrior" || playerClass == "Archer" || playerClass == "Rogue")
            {
                return Damage + Str + Dex;
            }
            else return Damage + Magic;
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

        /// <summary>
        /// Displays user status
        /// </summary>
        public void ShowInformation()
        {
            Console.Clear();
            Console.WriteLine("Hero Current Status");
            TotalStats();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("PLAYER STATUS:");
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Name: " + HeroName);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Status: Str {0}, Dex {1}, Magic {2}", Str, Dex, Magic);
            Console.WriteLine("Total stats: {0}", totalStats);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("INVENTORY:");
            Slots();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

        }

        //get inheritence form other places
    }
}
