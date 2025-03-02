using AccountContext;
using StoreBox.AccountContext;
using StoreBox.AccountContext.Enums;
using StoreBox.CartContext;
using StoreBox.ProductContext;

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
            PhysicalProduct FarCryPrimalXONE = new PhysicalProduct(1.5, "20x20x20", DateTime.Now, amanda.Id,
                "Far Cry Primal", 59.99m, "Xbox One Game");

            var product = new List<Product>();
            product.Add(DeadRisingXONE);
            product.Add(FarCryPrimalXONE);

            Cart cart = new Cart(denis.Id, product);
            cart.ShowCart();


        }
    }
}