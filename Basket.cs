using System.Collections.Generic;

namespace Module2HW2
{
    public class Basket
    {
        private List<Product> _prodInBasket = new List<Product>() { };

        public void AddToBasket(Product item)
        {
            _prodInBasket.Add(item);
        }

        public void DeleteFromBasket(Product item)
        {
            for (int i = 0; i < _prodInBasket.Count; i++)
            {
                if (_prodInBasket[i].Name == item.Name)
                {
                    _prodInBasket.RemoveAt(i);
                }
            }
        }

        public List<Product> GetBasket()
        {
            return _prodInBasket;
        }

        public void CleanBasket()
        {
            _prodInBasket.Clear();
        }
    }
}