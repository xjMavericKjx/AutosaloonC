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
            return Car.Cost*(1-(SalePercent/100));
        }
    }
}
