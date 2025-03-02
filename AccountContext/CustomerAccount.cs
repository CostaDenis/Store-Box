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
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Customer Account");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("--------------------------------------");
        }
    }
}