namespace diab
{
    public class Armor : Item
    {
        //THIS IS ARMOR PLACE
        private string? armorType = null;
        public int ArmorDefense { get; set; }
        public string? ArmorType { get => armorType; }

        public enum Armors
        {
            Cloth = 1,
            Leather = 2,
            Mail = 3,
            Plate = 4,
        }

        /// <summary>
        /// defends against inccorect armor and playclass types
        /// </summary>
        /// <param name="armor"></param>
        /// <param name="player"></param>
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
