using System.Collections.Generic;

namespace Adaptor_Pattern
{
    public class ThirdPartyFlowerCollection
    {
        public List<Flower> MyFlowerCollection()
        {
            return new List<Flower>()
            {
                new Flower("Rose", Color.Red),
                new Flower("Sunflower",Color.Yellow),
                new Flower("Daffodil", Color.Yellow),
                new Flower("Snowdrop", Color.Blue)
            };
        }
    }
}