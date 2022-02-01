namespace Module2HW2
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Number { get; set; }
        public decimal Sum { get; set; }

        public Product(NameProduct product, decimal number)
        {
            Name = product.Name;
            Cost = product.Cost;
            Number = number;
            Sum = product.Cost * number;
        }
    }
}