using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCustomer
{
    public interface IExtraCharge
    {
        decimal Calculate(ICustomer obj);
    }
}
