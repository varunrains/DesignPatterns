using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAlgorithms
{
    public class PhoneValidation : ValidationLinker
    {
        public PhoneValidation(IValidation<ICustomer> nextValidator) : base(nextValidator)
        {
        }

        public override void Validate(ICustomer customer)
        {
            
            base.Validate(customer);
            if (customer.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required.");
            }
        }
    }
}
