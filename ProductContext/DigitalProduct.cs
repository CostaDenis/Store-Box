using StoreBox.ProductContect.Enums;
using StoreBox.ProductContext.Enums;

namespace StoreBox.ItemContext
{

    public class DigitalProduct : Product
    {
        public DigitalProduct()
        {

        }

        public DigitalProduct(EDigitalType digitalType, DateTime releaseDate, EAgeRating ageRating,
         string name, double price, string desciption)
            : base(name, price, desciption)
        {
            DigitalType = digitalType;
            ReleaseDate = releaseDate;
            AgeRating = ageRating;
        }

        public EDigitalType DigitalType { get; set; }
        public DateTime ReleaseDate { get; set; }
        public EAgeRating AgeRating { get; set; }
    }

}