using InterfaceCustomer;

namespace MiddleLayer
{
    //This class is not requried as the customer base can handle the customer type by 
    //passing the string
    public class LeadNotRequired : CustomerBase
    {
        //Entity framework should create the objects of Lead
        // This parameterless constructor is required for this purpose
        //When we dont want to validate the customer if it is coming from DB to client
        //Only validate when it is going from client to DB
        //public Lead() {

        //    CustomerType = "Lead";
        //}
        //public Lead(IValidation<ICustomer> custValidation) 
        //    : base(custValidation)
        //{
        //    CustomerType = "Lead";
        //}
    }
   
}