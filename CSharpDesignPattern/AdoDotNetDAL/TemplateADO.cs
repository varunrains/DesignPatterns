using CommonDAL;
using System.Data.SqlClient;

namespace AdoDotNetDAL
{
    public abstract class TemplateADO<AnyType> : AbstractDal<AnyType>
    {
        protected SqlConnection connection = null;
        private readonly string _connectionString;
        protected SqlCommand command = null;
        public TemplateADO(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        private void Open()
        {
            connection = new SqlConnection(_connectionString);
        }

        public abstract void ExecuteCommand(AnyType obj);
        private void Close() { }

        // Design pattern :- Template Pattern  -> You will have a fixed sequence
        //But the child classes will define how the individual methods will be used in class

        public void Execute(AnyType obj)  //Fixed sequence
        {
            Open();
            ExecuteCommand(obj);
            Close();
        }

        public override void Save()
        {
            base.Save();
        }

    }
}