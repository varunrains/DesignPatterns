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
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
        }

        //Child classes have liberty to override the methods if needed
        protected abstract void ExecuteCommand(AnyType obj); //For POST

        protected abstract List<AnyType> ExecuteCommand(); //For GET
        private void Close()
        {
            connection.Close();
        }

        // Design pattern :- Template Pattern  -> You will have a fixed sequence
        //But the child classes will define how the individual methods will be used in class

        public void Execute(AnyType obj)  //Fixed sequence
        {
            Open();
            ExecuteCommand(obj);
            Close();
        }

        public List<AnyType> Execute()  //Fixed sequence for GET operation
        {
            Open();
            List<AnyType> objs = ExecuteCommand();
            Close();

            return objs;
        }

        public override void Save()
        {
           foreach(AnyType o in anyTypes)
            {
                Execute(o);
            }
        }

        public override List<AnyType> Search()
        {
            return Execute();
        }

    }
}