using StoreBox.AccountContext.Enums;

namespace StoreBox.AccountContext
{
    public abstract class Account
    {

        public Account(string name, EAccountType accountType, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            AccountType = accountType;
            Email = email;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EAccountType AccountType { get; set; }
        public string Email { get; set; }
        // public string Password { get; set; }

        public abstract void ShowDetails();

    }
}