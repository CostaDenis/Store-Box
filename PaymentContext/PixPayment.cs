using StoreBox.PaymentContext.Enums;

namespace StoreBox.PaymentContext
{

    public class PixPayment : Payment
    {
        public PixPayment(string pixKey, Guid idCustomer, decimal amount, DateTime dueDate,
                        DateTime paymentDate, EPaymentStatus status) :
                         base(idCustomer, amount, dueDate, paymentDate, status)
        {
            PixKey = pixKey;
        }

        public string PixKey { get; set; }

        public override void Pay()
        {
            Status = EPaymentStatus.Completed;
            Console.WriteLine("Pix payment done!");
        }
    }
}