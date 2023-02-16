namespace diab
{
    public class InvalidArmorException : Exception
    {
        

        public InvalidArmorException() : base( "Invalid armor type") { }
        public InvalidArmorException(string message) : base(message)
        {
           
        }
        
        public InvalidArmorException(string message, Exception innerException ) : base(message, innerException) { }
    }
}
