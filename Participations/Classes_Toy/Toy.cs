using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public void AddNote(string note)
        {
            Notes += note + Environment.NewLine;
        }

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }

        public string GetAisle()
        {
            string aisle = "";
            Random r = new Random();

            aisle = Manufacturer.ToUpper()[0].ToString();
            aisle += r.Next(1, 25);

            return aisle;
        }

        public override string ToString()
        {
            return $"Toy: {Name}, Manufacturer: {Manufacturer}, Price: {Price:C}, Aisle: {GetAisle()}, Notes: {Notes}";

        }
    }
}


