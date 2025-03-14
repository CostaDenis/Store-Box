using StoreBox.ProductContext;

namespace StoreBox.ProductContext
{

    public class PhysicalProduct : Product
    {
        public PhysicalProduct(double weight, string dimension, DateTime manufactureDate,
         Guid sellerId, string name, decimal price, string description)
            : base(sellerId, name, price, description)
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
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Physical Product: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Dimension: {Dimension}");
            Console.WriteLine($"Manufacture Date: {ManufactureDate}");
            Console.WriteLine();

        }
    }
}