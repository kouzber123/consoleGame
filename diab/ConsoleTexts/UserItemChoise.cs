using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab.ConsoleTexts
{
    public class UserItemChoise
    {
        /// <summary>
        /// display choise and return int 1-3
        /// </summary>
        /// <returns></returns>
        public static int GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Choose from 1-3");
                string? userOption = Console.ReadLine();

                if (Int32.TryParse(userOption, out int userOptionInt) && userOptionInt > 0 && userOptionInt < 4)
                {
                    return userOptionInt;
                }
                continue;
            }
        }
    }
}
