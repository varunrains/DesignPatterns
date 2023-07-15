using Discount;
using ExtraCharge;
using InterfaceCustomer;
using MiddleLayer;
using ValidationAlgorithms;

namespace FactoryCustomer
{
    /// <summary>
    /// Design pattern: Factory method and not factory pattern
    /// The factory method defines an interface for creating object but lets sub-classes decide which classes
    /// to instantaiates
    /// </summary>
    public class FactoryBase
    {
        protected string _customerType = "";
        public virtual IValidation<ICustomer> CreateValidation()
        {
            //Pick the most used validation as this is just a base class.
            return new CustomerBasicValidation();
        }

        public virtual IDiscount CreateDiscount()
        {
            //Base class pick the most Billed type
            return new DiscountBillAmount();
        }

        public virtual IExtraCharge CreateExtraCharge()
        {
            //As this is a base class pick the most used extra charge
            return new ExtraChargeWeekend();
        }

        public  CustomerBase CreateCustomer()
        {
            return new Customer(CreateValidation(), CreateDiscount(), CreateExtraCharge(), _customerType);
        }
    }
}
