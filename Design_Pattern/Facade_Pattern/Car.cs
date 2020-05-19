using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class Car
    {
        public Car()
        {
            Body body = new Body();
            Engine engine = new Engine();
            Interior interior = new Interior();
        }

        public void CreateCar()
        {
            Console.WriteLine("Car created");
        }
    }
}
