using ParkIT.Shared.Abstractions.Exceptions;

namespace ParkIT.Domain.Exceptions;

public class EmptyParkingListNameException : ParkItException
{
    public EmptyParkingListNameException() : base("packing list name cannot be empty.")
    {
    }
}
