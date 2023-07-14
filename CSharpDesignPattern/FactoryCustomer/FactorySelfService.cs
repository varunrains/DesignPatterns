using InterfaceCustomer;

namespace FactoryCustomer
{
    public class FactorySelfService :FactoryBase
    {
        public FactorySelfService()
        {
            _customerType = "SelfService";
        }

        public override IExtraCharge CreateExtraCharge()
        {
            return null;
        }
    }
}
