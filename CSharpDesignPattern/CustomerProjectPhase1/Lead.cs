namespace MiddleLayer
{
    public class Lead : CustomerBase
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
        }
    }
   
}