
using System;
namespace ParkIT.Shared.Abstractions.Exceptions
{
    public abstract class ParkItException : Exception
    {
        protected ParkItException(string message) : base(message)
        {
        }
    }

}
