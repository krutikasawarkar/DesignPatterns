using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor_Pattern
{
    public class YtlGardner : IGardner
    {
        public List<Flower> ListFlowers()
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
