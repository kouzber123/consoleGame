namespace diab
{
    public class Armor : Item
    {
        //THIS IS ARMOR PLACE
        private string? armorType = null;
        private int gearStats = 0;

        private int str = 0;
        private int dex = 0;
        private int magic = 0;
        public int Str { get => str; set => str = value; }
        public int Dex { get => dex; set => dex = value; }
        public int Magic { get => magic; set => magic = value; }



        //convert stats based on class? or based on gear
        public int GearStats { get => gearStats; set => gearStats = value; }
        public string? ArmorType { get => armorType; }


        public enum Armors
        {
            Cloth = 1,
            Leather = 2,
            Mail = 3,
            Plate = 4,
        }

        public int TotalAttributes()
        {
            return  Str + Dex + Magic;
        }

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
        /// Set armor type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string SetArmorType(string type)
        {
            return armorType = type;
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
