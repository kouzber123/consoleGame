namespace diab
{
    /// <summary>
    /// Set class name and inherit attributes
    /// </summary>
    public abstract class HeroClass : HeroAttributeClass
    {
        public abstract string ClassName { get; }
        public abstract int Damage(Player player);

        //public abstract string  ArmorRestrictions(string armor);
        //public abstract string WeaponRestrictions(string weapon);
        public abstract string GearRestrictions(string weapon);
  

    }
}
