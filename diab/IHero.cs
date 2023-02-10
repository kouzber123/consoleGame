using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal interface IHero

    {
        //There is a hero, hero has basic things like name, hp, class but > different statuses
        //all cars work the same they follow same certain pattern like breaks 
        //heroes all lvl up, all equip items, damage, and display details
        
        public void ShowInformation(string heroClass,string name, int level)
        {
            Console.WriteLine("Class: " + heroClass);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Level: " + level);
        }
        public int LevelUp(int level) 
        {
          return  level += level;
        }
    }
}
