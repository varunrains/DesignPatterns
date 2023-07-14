using InterfaceCustomer;
using ValidationAlgorithms;

namespace FactoryCustomer
{
    public class FactoryHomeDelivery : FactoryBase
    {
        public FactoryHomeDelivery() {
            _customerType = "HomeDelivery";
        }

        public override IValidation<ICustomer> CreateValidation()
        {
            return new CustomerAddressValidation(new CustomerBasicValidation());
        }
    }
}
