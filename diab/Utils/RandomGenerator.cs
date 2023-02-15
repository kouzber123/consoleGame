namespace diab
{
    public static class RandomGenerator
    {   
        public static int RandomStat ()
        {
            Random random = new();
            return random.Next (10, 100);
        }
        
    }
}
