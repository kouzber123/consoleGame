namespace diab
{
    /// <summary>
    /// handles the option 
    /// </summary>
    public class SetArmor
    {
        /// <summary>
        /// with chosen item int 1-3 we set specific gear
        /// </summary>
        /// <param name="chosenItem"></param>
        /// <param name="armor"></param>
        /// <param name="gear1"></param>
        /// <param name="gear2"></param>
        /// <param name="gear3"></param>
        /// <param name="lvlreq1"></param>
        /// <param name="lvlreq2"></param>
        /// <param name="lvlreq3"></param>
        /// <param name="defense1"></param>
        /// <param name="defense2"></param>
        /// <param name="defense3"></param>
        public static void PlayerChoiseOfArmor(ref int chosenItem, ref Armor armor, ref string gear1, ref string gear2, ref string gear3, ref int lvlreq1, ref int lvlreq2, ref int lvlreq3, ref int defense1, ref int defense2, ref int defense3)
        {
            if (chosenItem == 1)
            {
                PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
            }
            if (chosenItem == 2)
            {
                PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
            }
            if (chosenItem == 3)
            {
                PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
            }
        }
    }
}
