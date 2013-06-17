using System;

namespace Autosaloon
{
    public class CarNumberException : Exception
    {
        public CarNumberException(string message)
            :base(message)
        {
        }
    }
}
