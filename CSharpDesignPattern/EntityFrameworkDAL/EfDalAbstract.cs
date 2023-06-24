using InterfaceDAL;
using System.Data.Entity;

namespace EntityFrameworkDAL
{
    //Design pattern :- Adapter pattern (Class adapter pattern)
    public class EfDalAbstract<AnyType> : IUow,IRepository<AnyType> where AnyType : class
    {
        DbContext _dbContext;
        public EfDalAbstract()
        {
            //Self contained transaction
            _dbContext = new EFUnitOfWork();
        }
        public void Add(AnyType type)
        {
            _dbContext.Set<AnyType>().Add(type); // in-memory commit
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _dbContext.SaveChanges(); //physical commit
        }

        public List<AnyType> Search()
        {
            return _dbContext.Set<AnyType>().AsQueryable<AnyType>().ToList<AnyType>();
        }

        public void Update(AnyType type)
        {
            throw new NotImplementedException();
        }

        void IRepository<AnyType>.Add(AnyType type)
        {
            throw new NotImplementedException();
        }

        void IRepository<AnyType>.Save()
        {
            throw new NotImplementedException();
        }

        List<AnyType> IRepository<AnyType>.Search()
        {
            throw new NotImplementedException();
        }

        void IRepository<AnyType>.SetUnitOfWork(IUow uow)
        {
            //Global Transaction
            _dbContext = ((EFUnitOfWork)uow);
        }

        void IRepository<AnyType>.Update(AnyType type)
        {
            throw new NotImplementedException();
        }
    }
}