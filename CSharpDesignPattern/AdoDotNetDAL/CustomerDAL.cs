using FactoryCustomer;
using InterfaceCustomer;
using InterfaceDAL;
using System.Data.SqlClient;

namespace AdoDotNetDAL
{
    public class CustomerDAL : TemplateADO<CustomerBase>, IRepository<CustomerBase>
    {
        public CustomerDAL(string connectionString) : base(connectionString)
        {
        }

        public override void Add(CustomerBase type)
        {
            type.Validate();
            base.Add(type);
        }

        //Template Pattern
        //Fixed sequence
        //Child classes can override the methods in the sequence
        //But the child classes cannot override the sequence itself (VIMP point)
        protected override void ExecuteCommand(CustomerBase obj)
        {
            if (obj.Id == 0)
            {
                command.CommandText = "insert into tblCustomer(" +
                                              "CustomerName," +
                                              "CustomerType," +
                                              "BillAmount,BillDate," +
                                              "PhoneNumber,Address)" +
                                              "values('" + obj.CustomerName + "','" +
                                              obj.CustomerType + "'," +
                                              obj.BillAmount + ",'" +
                                              obj.BillDate + "','" +
                                              obj.PhoneNumber + "','" +
                                              obj.Address + "')";
                command.ExecuteNonQuery();
            }
            else
            {
                //update
            }
        }

        protected override List<CustomerBase> ExecuteCommand()
        {
            command.CommandText = "select * from tblCustomer";
            SqlDataReader dr = null;
            dr = command.ExecuteReader();
            //Load it to in-memory collection
            //List<CustomerBase> custs = new List<CustomerBase>();
            while (dr.Read())
            {
                CustomerBase cust = Factory<CustomerBase>.Create("Customer");
                cust.Id = Convert.ToInt32(dr["ID"].ToString());
                cust.CustomerName = dr["CustomerName"].ToString();
                cust.CustomerType = dr["CustomerType"].ToString();
                cust.BillDate = Convert.ToDateTime(dr["BillDate"]);
                cust.BillAmount = Convert.ToDecimal(dr["BillAmount"]);
                cust.PhoneNumber = dr["PhoneNumber"].ToString();
                cust.Address = dr["Address"].ToString();
                anyTypes.Add(cust);
            }

            return anyTypes;
            
        }
    }
}
