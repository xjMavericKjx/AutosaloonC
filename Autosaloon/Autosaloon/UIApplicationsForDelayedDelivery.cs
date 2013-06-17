using System.Windows.Forms;

namespace Autosaloon
{
    public class UIApplicationsForDelayedDelivery : Applications
    {
        public int SalePercent { get; set; }


        public UIApplicationsForDelayedDelivery(string nameOfBuyers,int percent)
            : base(nameOfBuyers)
        {
            SalePercent = percent;
        }

        public override int СalculateCost()
        {
            try
            {
                if(Car.QuantityInStock == 0)throw new CarNumberException("Машина отсутствует на складе");
                return Car.Cost*(1 - (SalePercent/100));
            }
            catch (CarNumberException ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }
    }
}
