using InterfaceCustomer;
using InterfaceDAL;

namespace AdoDotNetDAL
{
    public class CustomerDAL : TemplateADO<ICustomer>, IDal<ICustomer>
    {
        public CustomerDAL(string connectionString) : base(connectionString)
        {
        }

        //Template Pattern
        //Fixed sequence
        //Child classes can override the methods in the sequence
        //But the child classes cannot override the sequence itself (VIMP point)
        public override void ExecuteCommand(ICustomer obj)
        {
            command.CommandText = "insert into tblCustomer(" +
                                          "CustomerName," +
                                          "BillAmount,BillDate," +
                                          "PhoneNumber,Address)" +
                                          "values('" + obj.CustomerName + "'," +
                                          obj.BillAmount + ",'" +
                                          obj.BillDate + "','" +
                                          obj.PhoneNumber + "','" +
                                          obj.Address + "')";
            command.ExecuteNonQuery();
        }
    }
}
