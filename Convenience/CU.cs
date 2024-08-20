using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience
{
    class CU:ConveStore
    {
        //CU클래스로 폼이 없다
        public Dictionary<string, int> PB = new Dictionary<string, int>();
        public Dictionary<string, int> Instant = new Dictionary<string, int>();
        public Dictionary<string, int> Easy_Eats = new Dictionary<string, int>();
        public Dictionary<string, int> Dessert = new Dictionary<string, int>();
        public Dictionary<string, int> Drink = new Dictionary<string, int>();
        public Dictionary<string, int> Household = new Dictionary<string, int>();

        public CU()
        {
            //PB
            PB.Add("바닐라향아메리카노", 5);
            PB.Add("콘소메맛팝콘", 5);
            PB.Add("쿠앤크오믈렛", 5);

            //Instatnt
            Instant.Add("미니소시지떡꼬치", 5);
            Instant.Add("불닭볶음면", 5);
            Instant.Add("자이언트롱다리", 5);

            //Easy_Eats
            Easy_Eats.Add("참치마요", 5);
            Easy_Eats.Add("백종원12찬한판도시락", 5);
            Easy_Eats.Add("햄에그샌드위치", 5);

            //Dessert
            Dessert.Add("꼬북칩", 5);
            Dessert.Add("포카칩어니언", 5);
            Dessert.Add("콘칩", 5);

            //Drink
            Drink.Add("바리스타카라멜", 5);
            Drink.Add("빙그레바나나", 5);
            Drink.Add("코카콜라캔", 5);

            //HouseHold
            Household.Add("팬톤치약", 5);
            Household.Add("지금부터숙취해소제", 5);
            Household.Add("가글라임", 5);



        }

        public void Product_Numbering()
        {
            int i;
            for (i = 0; i < PB.Count; i++)
            {
                int a = Convert.ToInt32(PB.Keys.ToList()[i]);
                Minus_Product(a);
                Plus_Product(a);
            }


            for (i = 0; i < Instant.Count; i++)
            {
                int a = Convert.ToInt32(Instant.ToList()[i]);
                Minus_Product(a);
                Plus_Product(a);
            }
        }
    }
}
