using StoreBox.ItemContext;

namespace StoreBox.ProductContext
{

    public class PhysicalProduct : Product
    {

        public PhysicalProduct()
        {

        }

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
    }
}