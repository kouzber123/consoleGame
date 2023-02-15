namespace diab
{
    public class Item
    {
      
        public string? Name { get; set; } //helmet of speed
        public int RequiredLevel { get; set; } //8

        public enum Slots
        {
            Weapon = 1,
            Head = 2,
            Body = 3,
            Legs = 4,
        }

        /// <summary>
        /// This gets the correct enum for gear
        /// </summary>
        /// <param name="slot"></param>
        /// <returns></returns>
        public static string SelectedPlayerGear(int slot)
        {
            string heroWeaponChoise = ((Slots)slot).ToString();
            return heroWeaponChoise;
        }
    }
}
