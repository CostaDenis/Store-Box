namespace StoreBox.ProductContext
{

    public abstract class Product
    {
        public Product(Guid Sellerid, string name, decimal price, string description)
        {
            Id = Guid.NewGuid();
            SellerId = Sellerid;
            Name = name;
            Price = price;
            Description = description;
        }

        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // public abstract void AddToCart();
        // public abstract void RemoveFromCart();
        public abstract void ShowDetails();
    }
}