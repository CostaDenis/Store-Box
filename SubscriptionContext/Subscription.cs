using StoreBox.PaymentContext;
using StoreBox.PaymentContext.Enums;
using StoreBox.SubsciptionContext.Enums;
using StoreBox.SubscriptionContext.Enums;

namespace StoreBox.SubscriptionContext
{

    public abstract class Subscription
    {
        public Subscription(Guid customerId, EPlanName planName, decimal recurringAmount, EBillingCycle billingCycle,
            DateTime startDate, DateTime? endDate, bool isAutoRenewal)
        {
            SubscriptionId = Guid.NewGuid();
            CustomerId = customerId;
            PlanName = planName;
            RecurringAmount = recurringAmount;
            BillingCycle = billingCycle;
            StartDate = startDate;
            EndDate = endDate;
            IsAutoRenewal = isAutoRenewal;
        }

        public Guid SubscriptionId { get; set; }
        public Guid CustomerId { get; set; }
        public EPlanName PlanName { get; set; }
        public decimal RecurringAmount { get; set; }
        public EBillingCycle BillingCycle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime NextBillingDate => CalculateNextBillingDate();
        public bool IsAutoRenewal { get; set; }
        public Payment? Payment { get; set; }

        public DateTime CalculateNextBillingDate()
        {
            DateTime nextBillingDate = StartDate;

            switch (BillingCycle)
            {

                case EBillingCycle.Monthly:
                    nextBillingDate = StartDate.AddMonths(1);
                    break;

                case EBillingCycle.Bimonthly:
                    nextBillingDate = StartDate.AddMonths(2);
                    break;

                case EBillingCycle.Quarterly:
                    nextBillingDate = StartDate.AddMonths(4);
                    break;

                case EBillingCycle.Semiannually:
                    nextBillingDate = StartDate.AddMonths(6);
                    break;

                case EBillingCycle.Annually:
                    nextBillingDate = StartDate.AddYears(1);
                    break;
            }

            return nextBillingDate;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Subscription ID: " + SubscriptionId);
            Console.WriteLine("Customer ID: " + CustomerId);
            Console.WriteLine("Plan Name: " + PlanName);
            Console.WriteLine("Recurring Amount: " + RecurringAmount);
            Console.WriteLine("Billing Cycle: " + BillingCycle);
            Console.WriteLine("Start Date: " + StartDate);
            Console.WriteLine("End Date: " + EndDate);
            Console.WriteLine("Next Billing Date: " + NextBillingDate);
            Console.WriteLine("Is Auto Renewal: " + IsAutoRenewal);
        }
        public void CancelSubscription()
        {
            IsAutoRenewal = false;
        }

        public void RenewSubscription()
        {
            IsAutoRenewal = true;
        }

        public void SetPayment(Payment payment)
        {
            if (Payment != null)
            {
                return;
            }

            Payment = payment;
        }

        public void PaySubscription()
        {
            if (Payment == null)
            {
                Console.WriteLine("No payment found!");
                return;
            }

            if (Payment.Status != EPaymentStatus.Completed)
            {
                Payment = null;
                Console.WriteLine("Payment refused!");
                return;
            }

            Console.WriteLine("Payment completed!");
            Console.WriteLine("Next billing date: " + NextBillingDate);
        }

    }
}