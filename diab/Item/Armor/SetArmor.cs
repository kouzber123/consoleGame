namespace diab
{
    /// <summary>
    /// handles the option 
    /// </summary>
    public class SetArmor
    {

        /// <summary>
        /// Player class gets the selecte armor or weapon class stats 
        /// Conditionals sets the correct slot without overwriting inventory
        /// </summary>
        /// <param name="gear"></param>
        /// <param name="player"></param>
        /// <param name="item"></param>
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
