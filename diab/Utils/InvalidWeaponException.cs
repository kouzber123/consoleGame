namespace diab
{
    public class InvalidWeaponException : Exception
        {

        public InvalidWeaponException() : base("Invalid weapon type") { }
        public InvalidWeaponException(string message) : base(message)
        {

        }

        public InvalidWeaponException(string message, Exception innerException) : base(message, innerException) { }
    }  
}
