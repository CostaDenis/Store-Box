using StoreBox.PaymentContext.Enums;

namespace StoreBox.PaymentContext
{

    public class DebitPayment : Payment
    {
        public DebitPayment(string cardNumber, string cardHolderName, DateTime expirationDate,
                int cvv, Guid idCustomer, decimal amount, DateTime dueDate,
                        DateTime paymentDate, EPaymentStatus status) : base(idCustomer, amount, dueDate,
                        paymentDate, status)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpirationDate = expirationDate;
            CVV = cvv;
        }

        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVV { get; set; }

        public override void Pay()
        {
            Status = EPaymentStatus.Completed;
            Console.WriteLine("Debit payment done!");
        }
    }
}