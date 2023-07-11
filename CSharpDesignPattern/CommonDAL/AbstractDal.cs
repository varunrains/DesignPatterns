using InterfaceDAL;

namespace CommonDAL
{
    //This is like a GlobalRespository class which will implement
    //common CRUD operations
    //This is half defined parent class hence abstract class
    public abstract class AbstractDal<AnyType> : IRepository<AnyType>
    {
        //The heart of any DB related stuff is the connection string
        protected string ConnectionString = "";

        public AbstractDal(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected List<AnyType> anyTypes= new List<AnyType>();

        //You are keeping this virtual because in any of the new
        //implementation let's say EF you might have 
        //a good technique to add objects to in-memory.
        //So for that reason we are keeping this virtual.
        public virtual void Add(AnyType type)
        {
            anyTypes.Add(type);
        }

        public virtual IEnumerable<AnyType> Search()
        {
            return anyTypes;
        }

        public virtual void Update(AnyType type)
        {
            anyTypes.Add(type);
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual void SetUnitOfWork(IUow uow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AnyType> GetData()
        {
            return anyTypes;
        }
    }
}