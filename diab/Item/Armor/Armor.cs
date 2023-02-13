using System.Numerics;

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

        public string Equip(int armor, Player player)
        {
            string? heroClass = player.Class;
            while (true)
            {
                if (armor == 1 && heroClass == "Mage")
                {

                    return armorType = PlayerArmor(armor);
                }
                if (armor == 3 && heroClass == "Warrior" || armor == 4 && heroClass == "Warrior" || armor == 2 && heroClass == "Warrior")
                {
                    return armorType = PlayerArmor(armor);
                }

                if (armor == 2 && heroClass == "Rogue")
                {
                    return armorType = PlayerArmor(armor); ;
                }
                if (armor == 2 && heroClass == "Ranger")
                {
                    return armorType = PlayerArmor(armor);
                }

                else
                {

                    return "";
                }
            }
        }

            public static string PlayerArmor(int selectedArmorType)
        {
            string heroWeaponChoise = ((Armors)selectedArmorType).ToString();
            return heroWeaponChoise;
        }

    }
}
