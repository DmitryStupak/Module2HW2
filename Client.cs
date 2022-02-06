using System;
using System.Collections.Generic;

namespace Module2HW2
{
    public class Client
    {
        public Basket Bas { get; set; }

        public void TakeBasket()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            var res = new Basket();
            var list = Program.GetListProd();
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));

            Bas = res;
        }

        public Order GetOrder(Basket list)
        {
            var prod = new List<Product>(Bas.GetBasket());
            Order res = new Order(list);
            list.CleanBasket();
            Console.WriteLine($"Order with ID {res.OrderId}");
            foreach (var item in prod)
            {
                Console.WriteLine($"{item.Name} -- {item.Number} -- {item.Cost} -- {item.Sum}");
            }

            Console.WriteLine($"Total : {res.Total}");
            return res;
        }
    }
}
