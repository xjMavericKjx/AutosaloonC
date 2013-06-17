using System.Windows.Forms;
using Autosaloon.Exceptions;

namespace Autosaloon
{
    public abstract class Applications
    {
        public string NameOfBuyer { get; set; }
        public string CellNumber { get; set; }
        public Car Car { get; set; }

        protected Applications(string nameOfBuyer)
        {
            try
            {
                if (string.IsNullOrEmpty(nameOfBuyer)) throw new PurchaserNameException("Неуказано имя покупателя!");
                NameOfBuyer = nameOfBuyer;
            }
            catch (PurchaserNameException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public abstract int СalculateCost();
    }



}
