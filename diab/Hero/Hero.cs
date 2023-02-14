namespace diab
{

    /// <summary>
    /// Hero handles setting class and name
    /// </summary>
    public abstract class Hero
    {
        
        /// <summary>
        /// this class contains correct heroclass
        /// </summary>
        public HeroClass Class { get; set; }

        public int Level { get; set; }

        /// <summary>
        /// Player class sets these and we get hero class here and so we can use their methods
        /// </summary>
        /// <param name="heroName"></param>
        /// <param name="heroClass"></param>
        public Hero(int level, HeroClass heroClass) {
           
            Level = level;
            Class = heroClass;           
        }
        
        
        public bool CheckItemType(string item)
        {
          string IsRestricted = Class.GearRestrictions(item);
          
            if(IsRestricted != null)
            {
                return true;
            }
            return false;
             
        }
        /// <summary>
        /// Generates damage output with correct stats of class
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public int Damage(Player player)
        {

           return Class.Damage(player);
    
        }

        /// <summary>
        /// LEVEL UP WITH CORRECT CLASS with class.llvup
        /// </summary>
        /// <param name="player"></param>
        public void LevelUp(Player player)
        {
            Class.LevelUp(player);
        }
      
    }
}
