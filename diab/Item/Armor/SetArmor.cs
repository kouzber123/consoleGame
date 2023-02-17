namespace diab
{
    /// <summary>
    /// handles the option 
    /// </summary>
    public class SetArmor
    {

        /// <summary>
        /// This methods places the item to the correct slot
        /// </summary>
        /// <param name="gear"></param>
        /// <param name="player"></param>
        /// <param name="armor"></param>
        /// <returns></returns>
        public static string EquipGear(int gear, Player player, Armor armor)
        {
    

            string PlayerSlot = Item.SelectedPlayerGear(gear);

            if (player.Level >= armor.RequiredLevel)
            {

                if (PlayerSlot == "Head")

                {

                    player.Head = armor;
                    return player.Head.Name!;
                }

                if (PlayerSlot == "Body")

                {

                    player.Body = armor;
                    return player.Body.Name!;

                }

                if (PlayerSlot == "Legs")

                {

                    player.Legs = armor;
                    return player.Legs.Name!;

                }

            }
            return null!;

        }
    }
}
