using InterfaceCustomer;
using ValidationAlgorithms;

namespace FactoryCustomer
{
    public class FactoryCustomer : FactoryBase
    {
        public FactoryCustomer() {
            _customerType = "Customer";
        }

        public override IValidation<ICustomer> CreateValidation()
        {
            return new CustomerBillValidation(new CustomerAddressValidation(new PhoneValidation(new CustomerBasicValidation())));
        }
    }
}
