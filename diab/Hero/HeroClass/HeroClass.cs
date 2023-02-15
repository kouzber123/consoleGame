namespace diab
{
    /// <summary>
    /// Set class name and inherit attributes
    /// </summary>
    public abstract class HeroClass : HeroAttributeClass
    {
        public abstract string ClassName { get; }
        public abstract int Damage(Player player);

        public abstract int TotalAttributes(Player player);

        public abstract int TotalAttribute(int x, int y);
        public abstract string GearRestrictions(string weapon);
  

    }
}
