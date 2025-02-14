using StoreBox.PaymentContext.Enums;

namespace StoreBox.PaymentContext
{

    public class BoletoPayment : Payment
    {

        public BoletoPayment(Guid idCustomer, decimal amount, DateTime dueDate,
                        DateTime paymentDate, EPaymentStatus status, string barCode, string boletoNumber) :
                            base(idCustomer, amount, dueDate, paymentDate, status)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }

        public override void Pay()
        {
            Status = EPaymentStatus.Completed;
            Console.WriteLine("Boleto payment done!");
        }
    }
}