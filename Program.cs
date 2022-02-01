using System;
using System.Collections.Generic;

namespace Module2HW2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Basket basket1 = TakeBasket();
            Order order1 = basket1.GetOrder();
            order1.Print();
            Console.WriteLine();
            Basket basket2 = TakeBasket();
            Order order2 = basket2.GetOrder();
            order2.Print();
        }

        public static List<NameProduct> GetListProd()
        {
            var ListProd = new List<NameProduct>
            {
                new NameProduct("Bread",5.0m),
                new NameProduct("Butter",7.0m),
                new NameProduct("Meat",10.0m),
                new NameProduct("Fish",9.0m),
                new NameProduct("Cakes",4.0m),
                new NameProduct("Cheese",6.0m),
                new NameProduct("Onion",1.0m),
                new NameProduct("Tomato",3.0m),
                new NameProduct("Apple",4.0m),
                new NameProduct("Cherry",3.0m),
                new NameProduct("Ice Cream",2.0m),
                new NameProduct("Pasta",4.0m),
                new NameProduct("Tea",2.0m),
                new NameProduct("Coffee",3.0m),
                new NameProduct("Milk",1.0m)
            };

            return ListProd;
        }

        public static Basket TakeBasket()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            var res = new Basket();
            var list = GetListProd();
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));

            return res;
        }
    }
}
