using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class CustomerBase : ICustomer
    {

        public IValidation<ICustomer>? _customerValidation = null;

        public CustomerBase(IValidation<ICustomer> custValidation)
        {
            _customerValidation = custValidation;
        }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public  void Validate()
        {
            _customerValidation?.Validate(this);
        }
    }
}
