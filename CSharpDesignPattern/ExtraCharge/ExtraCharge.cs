using InterfaceCustomer;

namespace ExtraCharge
{
    public class ExtraChargeWeekend : IExtraCharge
    {
        public decimal Calculate(ICustomer obj)
        {
            if (obj.BillDate.DayOfWeek == DayOfWeek.Saturday || obj.BillDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return (obj.BillAmount * Convert.ToDecimal(0.01));
            }
            else
            {
                return 0;
            }
        }
    }
}