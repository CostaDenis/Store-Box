using StoreBox.AccountContext.Enums;

namespace StoreBox.AccountContext
{

    public class CustomerAccount : Account
    {
        public CustomerAccount(string name, EAccountType accountType, string email) :
             base(name, accountType, email)
        {
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Customer: {Name} - {Email}");
        }
    }
}