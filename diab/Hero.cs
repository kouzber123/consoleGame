﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    public class Hero
    {   
        
        public string? HeroName { get; set; } //tom
        public string? Class { get; set; } //warrior
        public int Level { get; set; }  // 10
         
        public int LevelAttributes { get; set; }  // base + 3 / 2 / 1 * 10 times
        private int totalStats;
      
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Magic { get; set; }
    
        private string? weapon = null;
        private int damage = 0;
        private int defense = 0;
        private string? head = null;
        private string? body = null;
        private string? legs = null;

        public string? Weapon { get => weapon; set => weapon = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Defense { get => defense; set => defense = value; }
        public string? Head { get => head; set=> head = value; }
        public string? Body { get => body; set=> body = value; }
        public string? Legs { get => legs; set=> legs = value; }

        public void TotalStats()
        {
            totalStats = Str + Dex + Magic;
        }

        public int GetTotalDamage(string Class)
        {
            if (Class == "Warrior" || Class == "Archer" || Class == "Rogue")
            {
                return Damage + Str + Dex;
            }
            else return Damage + Magic;
        }
        public void Slots()
        {
            var gearSlots = new Dictionary<string, string>(){
            {"Weapon", weapon! },
             {"Head", head!},
             {"Body", body!},
             {"Legs", legs!}
            };
            foreach(var gearSlot in gearSlots)
            {
                Console.WriteLine("{0} {1}", gearSlot.Key, gearSlot.Value);              
            }
        }
        public static void ShowCurrentGear()
        {
          
        }
        public void ShowInformation()
        {
            TotalStats();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("PLAYER STATUS:");      
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Name: " + HeroName);
            Console.WriteLine("Level: " +Level);
            Console.WriteLine("Status: Str {0}, Dex {1}, Magic {2}", Str, Dex, Magic);
            Console.WriteLine("Total stats: {0}", totalStats);
            Console.WriteLine("Total Damage: {0}", GetTotalDamage(Class!));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("INVENTORY:");        
            Slots();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

        }

        //get inheritence form other places
    }
}
