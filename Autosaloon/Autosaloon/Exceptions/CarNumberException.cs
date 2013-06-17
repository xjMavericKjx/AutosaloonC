using System;

namespace Autosaloon.Exceptions
{
    public class CarNumberException : Exception
    {
        public CarNumberException(string message)
            :base(message)
        {
        }
    }
}
