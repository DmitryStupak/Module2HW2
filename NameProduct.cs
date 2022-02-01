namespace Module2HW2
{
    public class NameProduct
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public NameProduct(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}