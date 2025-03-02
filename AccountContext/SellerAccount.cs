using StoreBox.AccountContext;
using StoreBox.AccountContext.Enums;

namespace AccountContext
{
    public class SellerAccount : Account
    {
        public SellerAccount(string name, EAccountType accountType, string email) :
             base(name, accountType, email)
        {
            ScoreHistory = new List<int>();
        }
        public double Rating => ScoreHistory.Count > 0 ? ScoreHistory.Sum() / ScoreHistory.Count : 0;  //Media de todas as notas
        public List<int> ScoreHistory { get; set; }
        public int Score { get; set; } //Ver a questao das notas

        public override void ShowDetails()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Seller Account");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Rating: {Rating}");
            Console.WriteLine("--------------------------------------");
        }
    }
}