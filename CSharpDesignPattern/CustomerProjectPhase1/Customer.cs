using InterfaceCustomer;

namespace MiddleLayer
{
    public class Customer : CustomerBase
    {
        public Customer(IValidation<ICustomer> custValidation):
            base(custValidation)
        {

        }
    }
}