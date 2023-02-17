namespace diab
{

    /// <summary>
    /// Armor class handles armor related props and methods
    /// </summary>
    public class Armor : Item
    {
        
        private string? armorType = null;

        private int str = 0;
        private int dex = 0;
        private int magic = 0;
        public int Str { get => str; set => str = value; }
        public int Dex { get => dex; set => dex = value; }
        public int Magic { get => magic; set => magic = value; }

        public string? ArmorType { get => armorType; set => armorType = value; }

       
        public enum Armors
        {
            Cloth = 1,
            Leather = 2,
            Mail = 3,
            Plate = 4,
        }

        /// <summary>
        /// Return all stats combined
        /// </summary>
        /// <returns></returns>
        public int TotalAttributes()
        {
            return  Str + Dex + Magic;
        }

        /// <summary>
        /// return combined individual stats depending on argument value 
        /// </summary>
        /// <param name="player"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int TotalAttribute(Player player, int num)
        {
            if(player.Head != null && player.Body != null && player.Legs != null)
            switch (num)
            {
                
                case 1:      
                        return player.Head.Str + player.Body.Str + player.Legs.Str;
               
                case 2:
             
                        return player.Head.Dex + player.Body.Dex + player.Legs.Dex;
               case 3:
  
                        return player.Head.Magic + player.Body.Magic + player.Legs.Magic;
       
              default:
                     break;
            }

            return 0;
          
            
        }

        /// <summary>
        /// Returns play armor type as string
        /// </summary>
        /// <param name="selectedArmorType"></param>
        /// <returns></returns>
        public static string PlayerArmor(int selectedArmorType)
        {
            return ((Armors)selectedArmorType).ToString();
            
        }

    }
}
