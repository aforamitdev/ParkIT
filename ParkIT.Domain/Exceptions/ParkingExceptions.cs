namespace ParkIT.Domain.Exceptions;

public class ParkingExceptions
{
    public abstract class ParkingItException : Exception
    {
        protected ParkingItException(string message) : base("Parking list name is empty!")
        {
            
        }
    }
}