using System.Collections.Generic;

namespace Adaptor_Pattern
{
    public class Client
    {
        private readonly IGardner _gardner;
        public Client(IGardner gardner)
        {
            this._gardner = gardner;
        }

        public void ShowAllFlowers()
        {
            List<Flower> flowers = _gardner.ListFlowers();
        }
    }
}