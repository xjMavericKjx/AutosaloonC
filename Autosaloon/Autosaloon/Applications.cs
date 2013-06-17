namespace Autosaloon
{
    public abstract class Applications
    {
        public string NameOfBuyer { get; set; }
        public string CellNumber { get; set; }
        public Car Car { get; set; }

        public Applications(string nameOfBuyer)
        {
            NameOfBuyer = nameOfBuyer;
        }

        public abstract int СalculateCost();

    }



}
