using StoreBox.PaymentContext.Enums;

namespace StoreBox.PaymentContext
{

    public class SubscriptionPayment : Payment
    {
        public SubscriptionPayment(Guid subscriptionId, Guid idCustomer, decimal amount, DateTime dueDate,
                                    DateTime paymentDate, EPaymentStatus status) :
                                        base(idCustomer, amount, dueDate, paymentDate, status)
        {
            SubscriptionId = subscriptionId;
        }
        public Guid SubscriptionId { get; set; }

        public override void Pay()
        {
            Status = EPaymentStatus.Completed;
            Console.WriteLine("Subscription payment done!");
        }

    }
}