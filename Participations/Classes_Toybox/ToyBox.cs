using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toybox
{
    public class ToyBox
    {

        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }


        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }

        public Toy GetRandomToy()
        {
            Random r = new Random();
            int randomIndex = r.Next(0, Toys.Count);
            return Toys[randomIndex];
        }

        public override string ToString()
        {
            return $"{Owner} owns the Toybox found at {Location} and has {Toys.Count} toys inside of it";
        }

    }
}
