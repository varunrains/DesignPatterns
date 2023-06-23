namespace InterfaceDAL
{
    // Design Pattern :- Generic Repository Pattern
    public interface IRepository<AnyType>
    {
        void SetUnitOfWork(IUow uow);
        void Add(AnyType type); //In memory Addition
        void Update(AnyType type); //In memory Updation
        List<AnyType> Search();

        void Save(); //Physical Commit
    }
}