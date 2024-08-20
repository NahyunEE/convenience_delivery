using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server_ab        

    {
        protected Dictionary<string, int> PB = new Dictionary<string, int>();
        protected Dictionary<string, int> Instant = new Dictionary<string, int>();
        protected Dictionary<string, int> Easy_Eats = new Dictionary<string, int>();
        protected Dictionary<string, int> Dessert = new Dictionary<string, int>();
        protected Dictionary<string, int> Drink = new Dictionary<string, int>();
        protected Dictionary<string, int> HouseHold = new Dictionary<string, int>();

        //string : client 이름 
        //int    :재고수

        protected Dictionary<string, bool> Client_List = new Dictionary<string, bool>();

       public void Add_PB(string a, int b)
        {
            PB.Add(a, b);
        }

        public void Remove_PB(string a)
        {
            PB.Remove(a);
        }

        public void Add_Instant(string a, int b)
        {
            Instant.Add(a, b);
        }

        public void Remove_Instant(string a)
        {
            Instant.Remove(a);
        }


        public void Easy_Eats_Add(string a, int b)
        {
            Easy_Eats.Add(a, b);
        }

        public void Easy_Eats_Remove(string a)
        {
            Easy_Eats.Remove(a);
        }

        public void Dessert_Add(string a, int b)
        {
            Easy_Eats.Remove(a);
        }


        public void Dessert_Remove(string a)
        {
            Dessert.Remove(a);

        }

        public void Drink_Add(string a, int b) {

            Drink.Add(a, b);
        }

        public void Drink_Remove(string a)
        {
            Drink.Remove(a);
        }

        public void HouseHold_Add(string a, int b)
        {
            HouseHold.Add(a, b);
        }

        public void HouseHold_Remove(string a)
        {
            HouseHold.Remove(a);
        }
       

    }
}
