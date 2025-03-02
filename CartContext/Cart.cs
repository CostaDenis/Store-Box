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

        public void ShowCart()
        {
            Console.WriteLine($"Cart ID: {Id}");
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Total: {Total}");
            Console.WriteLine("Items:");

            foreach (var item in Items)
            {
                item.ShowDetails();
            }
        }
    }
}