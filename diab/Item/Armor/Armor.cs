namespace diab
{
    public class Armor : Item
    {
        //THIS IS ARMOR PLACE
        private string? armorType;
        public int ArmorDefense { get; set; }
        public string? ArmorType { get => armorType; }

        public enum Armors
        {
            cloth = 1,
            leather = 2,
            mail = 3,
            plate = 4,
        }

        public string Equip(int armor)
        {
            var result = PlayerArmor(armor);
            if (result != null)
            {
                return armorType = result;
            }

            return null!;
        }

        public static string PlayerArmor(int selectedArmorType)
        {
            string heroWeaponChoise = ((Armors)selectedArmorType).ToString();
            return heroWeaponChoise;
        }

    }
}
