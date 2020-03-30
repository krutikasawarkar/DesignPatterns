using System;

namespace Adaptor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IGardner gardner = new GardenAdaptor();
            Client client = new Client(gardner);
            client.ShowAllFlowers();
        }
    }
}
