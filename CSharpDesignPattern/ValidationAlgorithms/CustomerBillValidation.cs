using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAlgorithms
{
    public class CustomerBillValidation : ValidationLinker
    {
        public CustomerBillValidation(IValidation<ICustomer> nextValidator) : base(nextValidator)
        {
        }

        public override void Validate(ICustomer customer)
        {
            base.Validate(customer);
            if (customer.BillAmount == 0)
            {
                throw new Exception("Bill amount is required.");
            }
            if (customer.BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date is not proper");
            }
        }
    }
}
