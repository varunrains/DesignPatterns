using InterfaceDAL;
using System.Data.Entity;

namespace EntityFrameworkDAL
{
    //Design pattern :- Adapter pattern (Class adapter pattern)
    public class EfDalAbstract<AnyType> : DbContext, IRepository<AnyType> where AnyType : class
    {
        public EfDalAbstract() : base("name=connectionstring")
        {

        }
        public void Add(AnyType type)
        {
            Set<AnyType>().Add(type); // in-memory commit
        }

        public void Save()
        {
           SaveChanges(); //physical commit
        }

        public List<AnyType> Search()
        {
            return Set<AnyType>().AsQueryable<AnyType>().ToList<AnyType>();
        }

        public void Update(AnyType type)
        {
            throw new NotImplementedException();
        }
    }
}