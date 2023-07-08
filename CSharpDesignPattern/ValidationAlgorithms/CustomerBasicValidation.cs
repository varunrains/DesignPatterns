using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAlgorithms
{
    public class CustomerBasicValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer customer)
        {
            if (customer.CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required.");
            }
        }
    }
}
