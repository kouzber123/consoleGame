namespace diab
{
    public class InvalidArmorException : Exception
    {
        readonly string Type;
        readonly string ClassName;
        public InvalidArmorException(string classname, string type) : base()
        {
            Type = type;
            ClassName = classname;
        }

        public override string Message => ClassName + " cannot equip armortype: " + Type;
    }
}
