using System;
using System.Collections.Generic;
using System.Linq;

namespace Module2HW2
{
    public class Order
    {
        private List<Product> _prodInOrder = new List<Product>() { };
        public Order(int id, List<Product> item)
        {
            OrderID = id;
            _prodInOrder = item;
            Total = item.Select(x => x.Sum).Sum();
        }

        public decimal Total { get; set; }
        public int OrderID { get; set; }

        public void Print()
        {
            Console.WriteLine($"Order with ID {OrderID}");
            foreach (var item in _prodInOrder)
            {
                Console.WriteLine($"{item.Name} -- {item.Number} -- {item.Cost} -- {item.Sum}");
            }

            Console.WriteLine($"Total : {Total}");
        }
    }
}