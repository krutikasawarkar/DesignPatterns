using System.Collections.Generic;

namespace Adaptor_Pattern
{
    public class GardenAdaptor : ThirdPartyFlowerCollection, IGardner
    {
        public List<Flower> ListFlowers()
        {
            return MyFlowerCollection();
        }
    }
}