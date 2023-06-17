using InterfaceCustomer;
using System.Net;

namespace ValidationAlgorithms
{
    public class CustomerValidationAll : IValidation<ICustomer>
    {
        public void Validate(ICustomer customer)
        {
            if (customer.CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required.");
            }
            if (customer.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required.");
            }
            if (customer.BillAmount == 0)
            {
                throw new Exception("Bill amount is required.");
            }
            if (customer.BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date is not proper");
            }
            if (customer.Address.Length == 0)
            {
                throw new Exception("Address is required.");
            }
        }
    }
}