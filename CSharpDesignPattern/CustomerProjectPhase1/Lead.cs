using InterfaceCustomer;

namespace MiddleLayer
{
    public class Lead : CustomerBase
    {
        public Lead(IValidation<ICustomer> custValidation) 
            : base(custValidation)
        {

        }
    }
   
}