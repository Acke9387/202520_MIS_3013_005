using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Easterbunny
{
    public class Bunny
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int BasketSize { get; set; }
        public string EggColor { get; set; }
        public int EggCount { get; set; }
        public string Location { get; set; }
        public string FavoriteColor { get; set; }

        public Bunny()
        {
            Name = string.Empty;
            Age = 0;
            DeliveryDate = DateTime.MinValue;
            BasketSize = 0;
            EggColor = string.Empty;
            EggCount = 0;
            Location = string.Empty;
            FavoriteColor = string.Empty;
        }
        public Bunny(string name, int age)
        {
            Name = name;
            Age = age;
            DeliveryDate = DateTime.MinValue;
            BasketSize = 0;
            EggColor = string.Empty;
            EggCount = 0;
            Location = string.Empty;
            FavoriteColor = string.Empty;
        }

        public int HowManyEasterBaskets()
        {
            int baskets = EggCount / BasketSize;
            baskets = (int)Math.Ceiling((double)baskets);

            return baskets;
        }

        public override string ToString()
        {
            return $"Bunny Name: {Name}, Age: {Age}, Delivery Date: {DeliveryDate.ToShortDateString()}, Basket Size: {BasketSize}, Egg Color: {EggColor}, Egg Count: {EggCount}, Location: {Location}, Favorite Color: {FavoriteColor}";
        }


    }
}


