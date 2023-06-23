using InterfaceDAL;
using System.Configuration;
using System.Data.SqlClient;

namespace AdoDotNetDAL
{
    public class AdoUnitOfWork : IUow
    {
        public SqlConnection Connection { get; set; }
        public SqlTransaction Transaction { get; set; }

        public AdoUnitOfWork()
        {
            Connection = new SqlConnection
                (ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
            Connection.Open();
            Transaction = Connection.BeginTransaction();
        }
        public void Commit()
        {
            Transaction.Commit();
            Connection.Close();
        }

        public void RollBack() //Design Pattern :- Adapter design pattern (Object adapter)
        {
            Transaction.Rollback();
            Connection.Close();
        }
    }
}
