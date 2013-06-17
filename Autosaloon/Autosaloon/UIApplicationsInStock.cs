using System;
using System.Windows.Forms;

namespace Autosaloon
{
    public class UIApplicationsInStock : Applications
    {

        public UIApplicationsInStock(String nameOfBuyer)
            : base(nameOfBuyer)
        {
        }

        public override int СalculateCost()
        {
            try
            {
                if (Car.QuantityInStock == 0) throw new CarNumberException("Машина отсутствует на складе");
                return Car.Cost;
            }
            catch (CarNumberException ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }
    }
}
