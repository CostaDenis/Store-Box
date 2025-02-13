namespace StoreBox.ItemContext
{

    public abstract class Product
    {
        public Product(string name, double price, string desciption)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Description = desciption;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        // public abstract void AddToCart();
        // public abstract void RemoveFromCart();
        public abstract void ShowDetails();
    }
}