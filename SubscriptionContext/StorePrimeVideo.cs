using StoreBox.SubsciptionContext.Enums;
using StoreBox.SubscriptionContext.Enums;

namespace StoreBox.SubscriptionContext
{

    public class StorePrimeVideo : Subscription
    {

        public StorePrimeVideo(Guid customerId, EPlanName planName, decimal recurringAmount, EBillingCycle billingCycle,
            DateTime startDate, DateTime? endDate, bool isAutoRenewal) :
            base(customerId, planName, recurringAmount, billingCycle, startDate, endDate, isAutoRenewal)
        {

        }

    }
}