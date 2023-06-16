namespace MiddleLayer
{
    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required.");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required.");
            }
            if (BillAmount == 0)
            {
                throw new Exception("Bill amount is required.");
            }
            if (BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date is not proper");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is required.");
            }
        }
    }
}