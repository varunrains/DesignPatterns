using FactoryCustomer;
using InterfaceCustomer;
using InterfaceDAL;
using System.Data.SqlClient;

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
        protected override void ExecuteCommand(ICustomer obj)
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

        protected override List<ICustomer> ExecuteCommand()
        {
            command.CommandText = "select * from tblCustomer";
            SqlDataReader dr = null;
            dr = command.ExecuteReader();
            List<ICustomer> custs = new List<ICustomer>();
            while (dr.Read())
            {
                ICustomer cust = Factory<ICustomer>.Create("Customer");
                cust.CustomerName = dr["CustomerName"].ToString();
                cust.BillDate = Convert.ToDateTime(dr["BillDate"]);
                cust.BillAmount = Convert.ToDecimal(dr["BillAmount"]);
                cust.PhoneNumber = dr["PhoneNumber"].ToString();
                cust.Address = dr["Address"].ToString();
                custs.Add(cust);
            }

            return custs;
            
        }
    }
}
