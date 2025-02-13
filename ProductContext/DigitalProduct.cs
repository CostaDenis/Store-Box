using StoreBox.ProductContect.Enums;
using StoreBox.ProductContext.Enums;

namespace StoreBox.ItemContext
{

    public class DigitalProduct : Product
    {
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

        public override void ShowDetails()
        {
            Console.WriteLine($"Digital Product: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Digital Type: {DigitalType}");
            Console.WriteLine($"Release Date: {ReleaseDate}");
            Console.WriteLine($"Age Rating: {AgeRating}");
        }
    }

}