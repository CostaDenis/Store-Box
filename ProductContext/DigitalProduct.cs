using StoreBox.ProductContect.Enum;

namespace StoreBox.ItemContext
{

    public class DigitalProduct : Product
    {
        public DigitalProduct()
        {

        }

        public DigitalProduct(EDigitalType digitalType, DateTime releaseDate, string name, double price, string desciption)
            : base(name, price, desciption)
        {
            DigitalType = digitalType;
            ReleaseDate = releaseDate;
        }

        public EDigitalType DigitalType { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

}