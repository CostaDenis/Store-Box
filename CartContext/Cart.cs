using StoreBox.PaymentContext;
using StoreBox.PaymentContext.Enums;
using StoreBox.ProductContext;

namespace StoreBox.CartContext
{

    public class Cart
    {
        public Cart(Guid customerId, List<Product> items)
        {
            Id = Guid.NewGuid();
            CustomerId = customerId;
            Items = items ?? new List<Product>();
        }
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public List<Product> Items { get; set; }
        public decimal Total => Items.Sum(i => i.Price);
        public Payment? Payment { get; private set; }

        public void AddItem(Product item)
        {
            Items.Add(item);
        }
        public void RemoveItem(Product item)
        {
            Items.Remove(item);
        }
        public void ClearCart()
        {
            Items.Clear();
        }

        public void SetPayment(Payment payment)
        {
            if (Payment != null)
            {
                return;
            }

            Payment = payment;
        }

        public void ShowCart()
        {
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Cart ID: {Id}");
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Total: {Total}");
            Console.WriteLine("Items:");

            foreach (var item in Items)
            {
                item.ShowDetails();
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

        }

        public bool PucharseCart()
        {

            if (Payment == null)
            {
                Console.WriteLine("Add a payment method to proceed with the purchase!");
                return false;
            }

            if (Payment.Status != EPaymentStatus.Completed)
            {
                Console.WriteLine("Payment refused!");
                return false;
            }

            if (Items.Count == 0)
            {
                Console.WriteLine("Add items to the cart to proceed with the purchase!");
                return false;
            }

            Console.WriteLine("Purchase completed!");
            ClearCart();
            return true;
        }
    }
}