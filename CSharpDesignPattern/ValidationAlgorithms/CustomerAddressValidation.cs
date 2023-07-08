using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAlgorithms
{
    public class CustomerAddressValidation : ValidationLinker
    {
        public CustomerAddressValidation(IValidation<ICustomer> nextValidator) : base(nextValidator)
        {
        }

        public override void Validate(ICustomer type)
        {
            base.Validate(type);

            if (type.Address.Length == 0)
            {
                throw new Exception("Address is required.");
            }
        }
    }
}
