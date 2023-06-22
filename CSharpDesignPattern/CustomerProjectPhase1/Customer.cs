using InterfaceCustomer;

namespace MiddleLayer
{
    public class Customer : CustomerBase
    {
        //Entity framework should create the objects of Customer
        // This parameterless constructor is required for this purpose
        //When we dont want to validate the customer if it is coming from DB to client
        //Only validate when it is going from client to DB
        public Customer() {
            CustomerType = "Customer";
        }
        public Customer(IValidation<ICustomer> custValidation):
            base(custValidation)
        {
            CustomerType = "Customer";
        }
    }
}