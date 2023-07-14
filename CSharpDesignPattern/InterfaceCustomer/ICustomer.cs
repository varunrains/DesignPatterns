namespace InterfaceCustomer
{
    public interface ICustomer
    {
        int Id { get; set; }
        string CustomerType { get; set; }
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }
        void Validate();
        //You are not following the SRP
        //This is just an example for Design pattern
        void Clone(); // Create a copy of the object
        void Revert(); //Revert back to the old copy
        decimal ActualCost(); //ActualCost = (BillAmount - Discount) + ExtraCharge;
    }
}