using StoreBox.PaymentContext.Enums;

namespace StoreBox.PaymentContext
{
    public abstract class Payment
    {
        public Payment(Guid idCustomer, decimal amount, DateTime dueDate,
                        DateTime paymentDate, EPaymentStatus status)
        {
            Id = Guid.NewGuid();
            IdCustomer = idCustomer;
            Amount = amount;
            DueDate = dueDate;
            PaymentDate = paymentDate;
            Status = status;
        }

        public Guid Id { get; set; }
        public Guid IdCustomer { get; set; }
        public decimal Amount { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public EPaymentStatus Status { get; set; }

        public virtual void Pay()
        {
            Status = EPaymentStatus.Completed;
        }
    }
}