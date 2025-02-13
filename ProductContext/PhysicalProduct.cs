using StoreBox.ItemContext;

namespace StoreBox.ProductContext
{

    public class PhysicalProduct : Product
    {
        public PhysicalProduct(double weight, string dimension, DateTime manufactureDate,
         string name, double price, string desciption)
            : base(name, price, desciption)
        {
            Weight = weight;
            Dimension = dimension;
            ManufactureDate = manufactureDate;
        }

        public double Weight { get; set; }
        public string Dimension { get; set; }
        public DateTime ManufactureDate { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"Physical Product: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Dimension: {Dimension}");
            Console.WriteLine($"Manufacture Date: {ManufactureDate}");
        }
    }
}