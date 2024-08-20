using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience
{
    class SortProduct
    {
        CU cu;
        SEVEN seven;
        GS gs;


        public void getItem(string storeName, int a, string item)
        {
            int flag = a;

            if (storeName == "CU")
            {
                switch (flag)
                {
                    case 1: cu.PB.Add(item, 3); break;
                    case 2: cu.Instant.Add(item, 3); break;
                    case 3: cu.Easy_Eats.Add(item, 3); break;
                    case 4: cu.Dessert.Add(item, 3); break;
                    case 5: cu.Drink.Add(item, 3); break;
                    case 6: cu.Household.Add(item, 3); break;
                    default: break;
                }
            }
            switch (flag)
            {
                case 1: cu.PB.Add(item, 3); break;
                case 2: cu.Instant.Add(item, 3); break;
                case 3: cu.Easy_Eats.Add(item, 3); break;
                case 4: cu.Dessert.Add(item, 3); break;
                case 5: cu.Drink.Add(item, 3); break;
                case 6: cu.Household.Add(item, 3); break;
                default: break;
            }

            switch (flag)
            {
                case 1: seven.PB.Add(item, 3); break;
                case 2: seven.Instant.Add(item, 3); break;
                case 3: seven.Easy_Eats.Add(item, 3); break;
                case 4: seven.Dessert.Add(item, 3); break;
                case 5: seven.Drink.Add(item, 3); break;
                case 6: seven.Household.Add(item, 3); break;
                default: break;
            }


            switch (flag)
            {
                case 1: gs.PB.Add(item, 3); break;
                case 2: gs.Instant.Add(item, 3); break;
                case 3: gs.Easy_Eats.Add(item, 3); break;
                case 4: gs.Dessert.Add(item, 3); break;
                case 5: gs.Drink.Add(item, 3); break;
                case 6: gs.Household.Add(item, 3); break;
                default: break;
            }
        }

    }
}
