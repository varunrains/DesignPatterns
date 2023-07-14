using InterfaceCustomer;
using ValidationAlgorithms;

namespace FactoryCustomer
{
    public class FactoryLead : FactoryBase
    {
        public FactoryLead()
        {
            _customerType = "Lead";
        }
        public override IDiscount CreateDiscount()
        {
            return null;
        }

        public override IExtraCharge CreateExtraCharge()
        {
            return null;
        }

        public override IValidation<ICustomer> CreateValidation()
        {
            return new PhoneValidation(new CustomerBasicValidation());
        }
    }
}
