namespace diab
{
    public class InvalidWeaponException : Exception
        {
            readonly string Type;
            readonly string ClassName;
            public InvalidWeaponException(string className, string type) : base()
            {
                Type = type;
                ClassName = className;
            }
            public override string Message => ClassName + " cannot equip Weapontype: " + Type;
        }  
}
