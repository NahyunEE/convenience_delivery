using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience
{
    class ConveStore
    {
        Random rnd = new Random();

        public Dictionary<string, int> PB;
        public Dictionary<string, int> Instant;
        public Dictionary<string, int> Easy_Eats;
        public Dictionary<string, int> Dessert;
        public Dictionary<string, int> Drink;
        public Dictionary<string, int> Household;

        public void Minus_Product(int a)
        {
            a -= rnd.Next(1, 3);
        }

        public void Plus_Product(int a)
        {
            if (a < 3)
            {
                a += rnd.Next(5, 10);
            }
            else
            {
                a += rnd.Next(1, 3);
            }

        }
    }
}
