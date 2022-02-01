namespace Module2HW2
{
    public class NameProduct
    {
        public NameProduct(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}