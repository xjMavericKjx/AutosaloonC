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
        private readonly ArrayList _cars= new ArrayList();

        public ArrayList GetCars()
        {
            return _cars;
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            _cars.Remove(car);
        }

        public Car SearchCar(string carName)
        {
            return _cars.Cast<Car>().FirstOrDefault(car => car.Name == carName);
        }
    }
}
