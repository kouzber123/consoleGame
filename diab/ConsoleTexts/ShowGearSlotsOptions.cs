using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab.ConsoleTexts
{
    public class ShowGearSlotsOptions
    {
        public static int ShowGearSlotOption()
        {
            while (true)
            {
                Console.WriteLine("What type of defense are you looking for?");
                Console.WriteLine("(1) head protection?");
                Console.WriteLine("(2) body protection?");
                Console.WriteLine("(3) leg protection?");

                string? choise = Console.ReadLine();

                if (Int32.TryParse(choise, out int value) && value > 0 && value < 4)
                {
                    return value;
                }
                continue;


            }

        }
    }
}
