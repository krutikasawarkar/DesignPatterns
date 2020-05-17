using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.CreateCar();
            Console.WriteLine();
        }
    }
}
