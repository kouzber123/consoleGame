namespace diab
{
    internal class SelectWeaponOrArmor
    {
        public static int SelectWeaponOrArmors()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("|GEAR HUB|");
                Console.WriteLine("(1) Weapons");
                Console.WriteLine("(2) Gears");
                string? choose = Console.ReadLine();

                if(Int32.TryParse(choose, out int choice))
                {

                    return choice;
                }
                else
                {
                    continue;
                }
            }
          


        }
                   
    }
}
