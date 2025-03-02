using StoreBox.SubsciptionContext.Enums;
using StoreBox.SubscriptionContext.Enums;

namespace StoreBox.SubscriptionContext
{

    public abstract class Subscription
    {

        public Guid SubscriptionId { get; set; }
        public Guid CustomerId { get; set; }
        public EPlanName PlanName { get; set; }
        public decimal RecurringAmount { get; set; }
        public EBillingCycle BillingCycle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime NextBillingDate { get; set; }
        public bool IsAutoRenewal { get; set; }

        public abstract DateTime CalculateNextBillingDate();
        public virtual void CancelSubscription()
        {
            IsAutoRenewal = false;
        }

    }
}