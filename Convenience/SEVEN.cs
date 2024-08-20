using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience
{
    class SEVEN:ConveStore
    {
        public Dictionary<string, int> PB = new Dictionary<string, int>();
        public Dictionary<string, int> Instant = new Dictionary<string, int>();
        public Dictionary<string, int> Easy_Eats = new Dictionary<string, int>();
        public Dictionary<string, int> Dessert = new Dictionary<string, int>();
        public Dictionary<string, int> Drink = new Dictionary<string, int>();
        public Dictionary<string, int> Household = new Dictionary<string, int>();


        public SEVEN()
        {

            //PB
            PB.Add("매운낚지볶음밥", 5);
            PB.Add("베이컨크림리조뜨", 5);
            PB.Add("아이스요구르트딸기", 5);

            //Instatnt
            Instant.Add("햇반컵밥", 5);
            Instant.Add("신라면", 5);
            Instant.Add("팔도비빔면", 5);

            //Easy_Eats
            Easy_Eats.Add("두부김치주먹밥", 5);
            Easy_Eats.Add("마라볶음삼각김밥", 5);
            Easy_Eats.Add("우삼격불고기김밥", 5);

            //Dessert
            Dessert.Add("더위사냥", 5);
            Dessert.Add("버터와플", 5);
            Dessert.Add("크라운산도", 5);

            //Drink
            Drink.Add("스페셜티 모카", 5);
            Drink.Add("요구하이", 5);
            Drink.Add("유기농콜드브루", 5);

            //HouseHold
            Household.Add("도루코일회용면도기", 5);
            Household.Add("디자인칫솔", 5);
            Household.Add("와이드헤드칫솔", 5);



        }
    }
}
