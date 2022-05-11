using System.Collections.Generic;

namespace H2
{
    public class Car : Vehicle
    {
        string registrationNumber { get; set; }
        string registrationYear { get; set; }
        IEngine engine { get; set; }
        List<Tire> wheels { get; set; }
        Gearbox gearbox { get; set; }

        internal Car()
        {

        }

        public Car(string color)
        {

        }

        public Car(string color, float size)
        {

        }

        public void Start()
        {

        }
    }
}