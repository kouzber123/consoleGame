namespace diab
{
         public class OptionalClassParams
        {
            private Weapon? weapon;
            private Armor? armor;
       

            public Weapon Class1
            {
                get { return weapon!; }
                set
                {
                    weapon = value;
           
                }
            }

            public Armor Class2
            {
                get { return armor!; }
                set
                {
                    armor = value;
                  
                }
            }
        }
    }

