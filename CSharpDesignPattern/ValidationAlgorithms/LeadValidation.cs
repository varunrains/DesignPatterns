using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAlgorithms
{
    public class LeadValidation : IValidation<ICustomer>
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
        }
    }
}
