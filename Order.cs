using System;
using System.Collections.Generic;
using System.Linq;

namespace Module2HW2
{
    public class Order
    {
        private List<Product> ProdInOrder = new List<Product>(){};
        public decimal Total { get; set; }
        public int OrderID { get; set; }


        public Order (int id,List<Product> item)
        {
            OrderID = id;
            ProdInOrder = item;
            Total = item.Select(x=>x.Sum).Sum();
        }

        public void Print ()
        {
            Console.WriteLine($"Order with ID {OrderID}");
            foreach (var item in ProdInOrder)
            {
                Console.WriteLine($"{item.Name} -- {item.Number} -- {item.Cost} -- {item.Sum}");
            }
            Console.WriteLine($"Total : {Total}");
        }
    }
}