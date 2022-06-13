using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEindproject
{
    public class Place
    {
        public string id;
        public float price = 15f;

        public static Place empty = new Place(string.Empty, 0);

        public Place(string id, float price = 15.0f)
        {
            this.id = id;
            this.price = price;
        }
    }
}
