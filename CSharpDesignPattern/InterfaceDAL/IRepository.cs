namespace InterfaceDAL
{
    // Design Pattern :- Generic Repository Pattern
    public interface IRepository<AnyType>
    {
        void SetUnitOfWork(IUow uow);
        void Add(AnyType type); //In memory Addition
        void Update(AnyType type); //In memory Updation

        //Design Pattern : Iterator Pattern
        IEnumerable<AnyType> Search();
        IEnumerable<AnyType> GetData();

        AnyType GetData(int index);
        void Save(); //Physical Commit
    }
}