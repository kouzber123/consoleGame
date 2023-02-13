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
            string result = PlayerGear(gear);
            try
            {
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
                    Slot = result;
                    return Name!;
                }

            }
            catch (ArgumentException)
            {

                Console.WriteLine("Player given type is unexpected ");
            }
            return null!;
          

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
