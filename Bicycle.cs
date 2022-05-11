using System.Collections.Generic;

namespace H2
{
    public class Bicycle
    {
        string registrationNumber { get; set; }
        List<Tire> Wheels { get; set; }

        public Bicycle(int numberOfWheels)
        {

        }
    }
}