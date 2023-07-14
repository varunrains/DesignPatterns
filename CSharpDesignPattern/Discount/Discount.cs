using InterfaceCustomer;

namespace Discount
{
    public class DiscountBillAmount : IDiscount
    {
        //All the hard-coded logic is from the table 
        //Please refer the document from where we got this percentage and BillAmount
        public decimal Calculate(ICustomer obj)
        {
            if(obj.BillAmount > 10000)
            {
                return (obj.BillAmount * Convert.ToDecimal(0.02));
            }
            else
            {
                return (obj.BillAmount * Convert.ToDecimal(0.01));
            }
        }
    }

    public class DiscountWeekend : IDiscount
    {
        //All the hard-coded logic is from the table 
        //Please refer the document from where we got this percentage and BillAmount
        public decimal Calculate(ICustomer obj)
        {
            if (obj.BillDate.DayOfWeek == DayOfWeek.Saturday || obj.BillDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return (obj.BillAmount * Convert.ToDecimal(0.01));
            }
            else
            {
                return (obj.BillAmount * Convert.ToDecimal(0.005));
            }
        }
    }
}