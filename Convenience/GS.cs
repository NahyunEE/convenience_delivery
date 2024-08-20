using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience
{
    class GS :ConveStore
    {
        public Dictionary<string, int> PB = new Dictionary<string, int>();
        public Dictionary<string, int> Instant = new Dictionary<string, int>();
        public Dictionary<string, int> Easy_Eats = new Dictionary<string, int>();
        public Dictionary<string, int> Dessert = new Dictionary<string, int>();
        public Dictionary<string, int> Drink = new Dictionary<string, int>();
        public Dictionary<string, int> Household = new Dictionary<string, int>();

        public GS()
        {
            //PB
            PB.Add("복숭아아이스티", 5);
            PB.Add("유어스미용티슈", 5);
            PB.Add("인절미아이스크림", 5);

            //Instatnt
            Instant.Add("1등급란", 5);
            Instant.Add("낙지볶음밥", 5);
            Instant.Add("불막창", 5);

            //Easy_Eats
            Easy_Eats.Add("햄치즈크랩맛살샌드", 5);
            Easy_Eats.Add("뉴참치마요골드", 5);
            Easy_Eats.Add("아임파인샌드위치", 5);

            //Dessert
            Dessert.Add("노가리먹태", 5);
            Dessert.Add("리치젤리", 5);
            Dessert.Add("자이언트허쉬", 5);

            //Drink
            Drink.Add("스페셜티 모카", 5);
            Drink.Add("요구하이", 5);
            Drink.Add("유기농콜드브루", 5);

            //HouseHold
            Household.Add("메디안치약", 5);
            Household.Add("칫솔", 5);
            Household.Add("해피바쓰촉촉내튜럴워시", 5);
        }
    }
}
