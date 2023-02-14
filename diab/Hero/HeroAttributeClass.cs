namespace diab
{
    /// <summary>
    /// Class related stats and lvl stats
    /// </summary>
    public abstract class HeroAttributeClass : LevelingAttributeClass
    {
        public abstract int Str { get;}
        public abstract int Dex { get;}
        public abstract int Magic { get; }

    }
}
