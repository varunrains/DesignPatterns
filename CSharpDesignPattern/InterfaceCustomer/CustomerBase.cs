using System.ComponentModel.DataAnnotations;

namespace InterfaceCustomer
{
    //Because of the shortcoming in the EF we are defining it as 
    //abstract class here, and you cannot create a object of abstract class
    //We are removing the abstract key word from here
    public class CustomerBase : ICustomer
    {

        public IValidation<ICustomer>? _customerValidation = null;

        public CustomerBase(IValidation<ICustomer> custValidation)
        {
            _customerValidation = custValidation;
        }

        //For entity framework we need a primary key
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public string CustomerType { get; set; }

        public CustomerBase()
        {
            CustomerName = "";
            PhoneNumber = "";
            BillAmount = 0;
            BillDate = DateTime.Now;
            Address = "";
        }


        public  virtual void Validate()
        {
            _customerValidation?.Validate(this);
        }
    }
}
