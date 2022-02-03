using System;
using System.Collections.Generic;

namespace Module2HW2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            client.TakeBasket();
            client.Bas.DeleteFromBasket(client.Bas.GetBasket()[0]);
            client.GetOrder(client.Bas);
            Client client1 = new Client();
            client1.TakeBasket();
            client1.GetOrder(client1.Bas);
        }

        public static List<NameProduct> GetListProd()
        {
            var listProd = new List<NameProduct>
            {
                new NameProduct("Bread", 5.0m),
                new NameProduct("Butter", 7.0m),
                new NameProduct("Meat", 10.0m),
                new NameProduct("Fish", 9.0m),
                new NameProduct("Cakes", 4.0m),
                new NameProduct("Cheese", 6.0m),
                new NameProduct("Onion", 1.0m),
                new NameProduct("Tomato", 3.0m),
                new NameProduct("Apple", 4.0m),
                new NameProduct("Cherry", 3.0m),
                new NameProduct("Ice Cream", 2.0m),
                new NameProduct("Pasta", 4.0m),
                new NameProduct("Tea", 2.0m),
                new NameProduct("Coffee", 3.0m),
                new NameProduct("Milk", 1.0m)
            };

            return listProd;
        }
    }
}
