using StoreBox.AccountContext;
using StoreBox.AccountContext.Enums;

namespace AccountContext
{
    public class SellerAccount : Account
    {
        public SellerAccount(double rating, string name, EAccountType accountType, string email) :
             base(name, accountType, email)
        {
            Rating = rating;
        }
        public double Rating { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"Seller: {Name} - {Email}");
        }
    }
}