using AdoDotNetDAL;
using EntityFrameworkDAL;
using InterfaceCustomer;
using InterfaceDAL;
using Unity;
using Unity.Resolution;
using EfDAL = EntityFrameworkDAL;

namespace FactoryDAL
{
    public static class FactoryDAL<AnyType> // Design pattern :- Simple factory pattern
    {
        private static IUnityContainer ObjectsofOurProjects = null;


        public static AnyType Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (ObjectsofOurProjects == null)
            {
                ObjectsofOurProjects = new UnityContainer();

                //Because of EF you will have to use the CustomerBase instead of ICustomer
                ObjectsofOurProjects.RegisterType<IRepository<CustomerBase>,
                    CustomerDAL>("ADODal");
                //Limitation in EF as you cant map interface to EF mapping
                ObjectsofOurProjects.RegisterType<IRepository<CustomerBase>,
                    CustomerDAL>("EFDal");

                ObjectsofOurProjects.RegisterType<IUow,
                  AdoUnitOfWork>("AdoUow");
                ObjectsofOurProjects.RegisterType<IUow,
                 EFUnitOfWork>("EfUow");
            }
            //Design pattern :-  RIP Replace If with Poly
            return ObjectsofOurProjects.Resolve<AnyType>(Type,
                                new ResolverOverride[]
                                {
                                    //Here only for classes where connection string parameter is present
                //for that only you will send the connection string. This is not the proper way
                //but still you can do this way for time being
                                       new ParameterOverride("connectionString",@"Data source=localhost;Initial Catalog=CustomerDB;User ID=sa;Password=Database!2023;")
                                }); ;
        }
    }
}