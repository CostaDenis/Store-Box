using StoreBox.PaymentContext.Enums;

namespace StoreBox.PaymentContext
{

    public class CreditCardPayment : Payment
    {

        public CreditCardPayment(string cardNumber, string cardHolderName, DateTime expirationDate,
                string cvv, Guid idCustomer, decimal amount, DateTime dueDate,
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
        public string CVV { get; set; }
    }
}