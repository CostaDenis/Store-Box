namespace StoreBox.ProductContext
{

    public abstract class Product
    {
        public Product(Guid idSeller, string name, decimal price, string desciption)
        {
            Id = Guid.NewGuid();
            IdSeller = idSeller;
            Name = name;
            Price = price;
            Description = desciption;
        }

        public Guid Id { get; set; }
        public Guid IdSeller { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // public abstract void AddToCart();
        // public abstract void RemoveFromCart();
        public abstract void ShowDetails();
    }
}