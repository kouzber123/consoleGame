﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace diab
{
    /// <summary>
    /// PlayrClasses handles level and stats related functionalities
    /// </summary>
    internal class PlayerClasses
    {
        private enum Classes
        {
            Mage = 1,
            Archer = 2,
            Rogue = 3,
            Warrior = 4
        }

        /// <summary>
        /// Player Class takes int 1-4 and return Enum based on that
        /// </summary>
        /// <param name="selectedHero"></param>
        /// <returns>string heroclass</returns>
        public static string PlayerClass(int selectedHero)
        {
            string heroClass = ((Classes)selectedHero).ToString();  
            return heroClass;
        }   
       
    }
}
