using System;

namespace Autosaloon.Exceptions
{
    public class PurchaserNameException : Exception
    {
        public PurchaserNameException(string message)
            : base(message)
        {
        }
    }
}
