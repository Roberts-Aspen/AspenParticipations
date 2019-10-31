using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle { get; set; }

        public Toy()
        {
            return;
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int num = rand.Next(1, 25);

            string uManu = Manufacturer.ToUpper();
            char firstLetter = uManu[0];

            string Aisle = $"{firstLetter}{num}";

            return Aisle;

        }
    }
}
