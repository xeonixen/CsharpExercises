using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Garage
    {
        public List<Car> Cars = new List<Car>();
    }
    public class Car
    {
        public String Make, Model;
        public string Color;
        public Engine engine;
        public Int32 Wheels;

        public Car(Int32 _Wheels,string _Color)
        {
            Wheels = _Wheels;
            Color = _Color;
            engine = new Engine(4, 1000);
        }
        public Car(Int32 _Wheels, string _Color,Engine _engine)
        {
            Wheels = _Wheels;
            Color = _Color;
            engine = _engine;
        }
        public Car(string _Make,string _Model, Int32 _Wheels, string _Color, Engine _engine)
        {
            Make = _Make;
            Model = _Model;
            Wheels = _Wheels;
            Color = _Color;
            engine = _engine;
        }
        public string GetDescription()
        {
            const string defaultDescriptor = "Unknown";
            string descriptor = "";
            if (Make != null)
            {
                descriptor += Make;
            }
            if (Model != null)
            {
                descriptor += " "+Model;
            }
            if (Make == null && Model == null)
                descriptor = defaultDescriptor;
            
            return String.Format("This car is a {0}.\nIt is {1}, and it has {2} Wheels.\nThe Engine has {3} Horsepowers.\n",descriptor,Color,Wheels,engine.HorsePower);
        }

        
    }
    public class Engine
    {


        public Int32 Displacement;

        public Int32 HorsePower
        {
            get
            {
                return (Cylinders * Displacement)/95;
            }
        }
        public Int32 Cylinders;
        public Engine(Int32 _Cylinders, Int32 _Displacement)
        {
            Cylinders = _Cylinders;
            Displacement = _Displacement;
        }
    }
}
