using AccountContext;
using StoreBox.AccountContext;
using StoreBox.AccountContext.Enums;
using StoreBox.CartContext;
using StoreBox.PaymentContext;
using StoreBox.PaymentContext.Enums;
using StoreBox.ProductContect.Enums;
using StoreBox.ProductContext;
using StoreBox.SubsciptionContext.Enums;
using StoreBox.SubscriptionContext;
using StoreBox.SubscriptionContext.Enums;

namespace StoreBox
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            CustomerAccount denis = new CustomerAccount("Denis", EAccountType.Customer, "denis@gmail.com");
            SellerAccount amanda = new SellerAccount("Amanda", EAccountType.Seller, "amanda@yahoo.com");

            // denis.ShowDetails();
            // amanda.ShowDetails();

            PhysicalProduct DeadRisingXONE = new PhysicalProduct(1.5, "20x20x20", DateTime.Now, amanda.Id,
                "Dead Rising 4", 59.99m, "Xbox One Game");

            DigitalProduct XboxLive = new DigitalProduct(EDigitalType.StreamingSubscription, DateTime.Today,
            ProductContext.Enums.EAgeRating.Quatorze, amanda.Id,
            "Xbox Live Subscription", 29.99m, "Xbox Live Subscription for 1 month");

            var product = new List<Product>();
            product.Add(DeadRisingXONE);
            product.Add(XboxLive);

            Cart cart = new Cart(denis.Id, product);
            // cart.ShowCart();

            PixPayment pix = new PixPayment("123456789", denis.Id, cart.Total, DateTime.Now,
            DateTime.Now.AddSeconds(120), EPaymentStatus.Completed);

            cart.SetPayment(pix);
            amanda.AddScore(EScoreSeller.Five, cart.PucharseCart());


            // StorePrimeVideo sPrimeVideo = new StorePrimeVideo(denis.Id, EPlanName.Basic, 9.99m, EBillingCycle.Monthly,
            //  DateTime.Now, null, true);

            // // sPrimeVideo.CancelSubscription();

            // sPrimeVideo.ShowDetails();



        }
    }
}