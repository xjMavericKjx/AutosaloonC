using System.Collections;
using System.Linq;

namespace Autosaloon
{
    public class Avtosaloon
    {
        public string Name { get; set; }

        public Avtosaloon(string name)
        {
            Name = name;
        }
        private readonly ArrayList Cars= new ArrayList();

        public ArrayList GetCars()
        {
            return Cars;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }

        public Car SearchCar(string carName)
        {
            return Cars.Cast<Car>().FirstOrDefault(car => car.Name == carName);
        }
    }
}
