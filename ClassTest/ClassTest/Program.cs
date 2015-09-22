using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace ClassTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Garage cars = new Garage();
            cars.Cars.Add(new Car("volvo", "240", 4, "Red", new Engine(4, 2300)));
            cars.Cars.Add(new Car("Buatti", "Veiron", 4, "Black", new Engine(16, 6036)));
            cars.Cars.Add(new Car("Audi", "A4", 4, "Silver", new Engine(5, 4500)));

foreach(Car c in cars.Cars)
            {
                Console.WriteLine(c.GetDescription());
            }
            Console.ReadLine();

        }
    }
}
