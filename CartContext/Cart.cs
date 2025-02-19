using StoreBox.ProductContext;

namespace StoreBox.CartContext
{

    public class Cart
    {
        public Cart(Guid customerId, List<Product> items)
        {
            Id = Guid.NewGuid();
            CustomerId = customerId;
            Items = items;
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
    }
}