namespace diab
{
    public class Item
    {
        public string? Name { get; set; } //helmet of speed
        public int RequiredLevel { get; set; } //8
        public string? Slot { get; set; } //head


        public enum Slots
        {
            Weapon = 1,
            Head = 2,
            Body = 3,
            Legs = 4,
        }

        /// <summary>
        /// This will defend against level requirement and sets the gear in the right slot
        /// </summary>
        /// <param name="gear"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public string EquipGear(int gear, Player player)
            //here use conditionals
        {
            var result = PlayerGear(gear);
            if (result != null && player.Level >= RequiredLevel)
            {
                if (result == "Weapon")
                {
                    player.Weapon = Name;
                }
                if (result == "Head")
                {
                    player.Head = Name;
             
                }
                if (result == "Body")
                {
                    player.Body = Name;
                }
                if (result == "Legs")
                {
                    player.Legs = Name;             
                }
            
            }
            else
            {
                Console.WriteLine("You do not meet the requirements to equip that");
            }
            
            Slot = result;
            return Name!;  
    }

        /// <summary>
        /// This gets the correct enum for gear
        /// </summary>
        /// <param name="slot"></param>
        /// <returns></returns>
        public static string PlayerGear(int slot)
        {
            string heroWeaponChoise = ((Slots)slot).ToString();
            return heroWeaponChoise;
        }
    }
}
