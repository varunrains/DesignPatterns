using InterfaceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAlgorithms
{
    //Design pattern: Decorator pattern - When you want to add logic on top of the base class
    //Here validationlinker is just a helper to achieve the decorator pattern
    //Imaging decorator pattern has a cake where you get the base flavor and 
    //you start adding flavors on top of it to get a new flavor without much modifications.
    public class ValidationLinker : IValidation<ICustomer>
    {
        IValidation<ICustomer> _nextValidator;
        public ValidationLinker(IValidation<ICustomer> nextValidator)
        {
            _nextValidator= nextValidator;
        }

        public virtual void Validate(ICustomer type)
        {
            _nextValidator.Validate(type);
        }
    }
}
