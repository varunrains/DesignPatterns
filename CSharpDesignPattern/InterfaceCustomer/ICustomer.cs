namespace InterfaceCustomer
{
    public interface ICustomer
    {
        int Id { get; set; }
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }

        void Validate();
    }
}