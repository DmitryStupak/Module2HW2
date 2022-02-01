using System.Collections.Generic;

namespace Module2HW2
{
    public class Basket
    {     
        private List<Product> ProdInBasket = new List<Product>(){};
        private static int countId = 1;

        public void AddToBasket (Product item)
        {
            ProdInBasket.Add(item);
        }

        public List<Product> GetBasket ()
        {
            return ProdInBasket;
        }

        public Order GetOrder()
        {
            var prod = new List<Product>(ProdInBasket);
            Order res = new Order (countId,prod);
            countId++;
            ProdInBasket.Clear();
            return res;
        }
    }
}