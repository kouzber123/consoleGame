using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class ChoosePlayerClass
    {
        public static HeroClass ChooseClass()
        {      
            while (true)
            {
                HeroClass hero;
                Console.WriteLine("Please press 1 - 4 to select a class");
                try
                {
                    
                    SelectionScreen.ChooseHero();
                    int choise = int.Parse(Console.ReadLine()!);
                    if (choise > 0 && choise <= 4)
                    {
                       
                        if(choise == 1)
                        {
                         return hero = new MageClass();    
                         

                        }
                        if(choise == 2)
                        {
                           return hero = new RogueClass();
                   
                        }
                        if(choise == 3)
                        {
                           return hero = new RangerClass();
                            
                        }
                        if(choise == 4)
                        {
                            return hero = new WarriorClass();
                           
                        }
                    }                 
                }

                catch (FormatException)
                {

                    Console.WriteLine("Invalid Input please enter a number");
                }

            }
        }
    }
}

