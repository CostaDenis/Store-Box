using StoreBox.PaymentContext;
using StoreBox.PaymentContext.Enums;

namespace StoreBox.PaymentContext
{

    public class CryptoPayment : Payment
    {
        public CryptoPayment(Guid idCustomer, decimal amount, DateTime dueDate,
                        DateTime paymentDate, EPaymentStatus status, string walletAddress, ECryptoType cryptoType) :
                            base(idCustomer, amount, dueDate, paymentDate, status)
        {
            WalletAddress = walletAddress;
            CryptoType = cryptoType;
        }

        public string WalletAddress { get; set; }
        public ECryptoType CryptoType { get; set; }

        public override void Pay()
        {
            Status = EPaymentStatus.Completed;
            Console.WriteLine("Crypto payment done!");
        }
    }

}