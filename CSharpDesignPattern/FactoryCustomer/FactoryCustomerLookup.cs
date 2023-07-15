using InterfaceCustomer;
using Unity;

namespace FactoryCustomer
{
    //Simple factory pattern
    //Where you are outsourcing the object creation work to some other project
    //So that when there is a new customer type you can change
    //in only one place and not many places
    public static class FactoryCustomerLookup<AnyType> //Design Pattern :- Simple Factory pattern
    {
        //private static readonly Lazy<Dictionary<string, CustomerBase>> customers 
        //    = new Lazy<Dictionary<string, CustomerBase>>(() => SetCustomerTypes());

        private static Lazy<IUnityContainer> ObjectsOfOurProject 
            = new Lazy<IUnityContainer>(() => SetObjectTypes());

        static FactoryCustomerLookup()
        {
            //Eager loading. Not a good practice to follow
            //customers.Add("Customer", new Customer());
            //customers.Add("Lead", new Lead());

        }

        //private static Dictionary<string, CustomerBase> SetCustomerTypes()
        //{
        //    var custs = new Dictionary<string, CustomerBase>
        //    {
        //        { "Customer", new Customer() },
        //        { "Lead", new Lead() }
        //    };

        //    return custs;
        //}

        private static IUnityContainer SetObjectTypes()
        {
            var unity = new UnityContainer();

            //IValidation<ICustomer> custValidation = new PhoneValidation(new CustomerBasicValidation());
            //unity.RegisterType<CustomerBase, Customer>("Lead", new InjectionConstructor(custValidation, "Lead"));

            //custValidation = new CustomerBasicValidation();
            //unity.RegisterType<CustomerBase, Customer>("SelfService", new InjectionConstructor(custValidation, "SelfService"));

            //custValidation = new CustomerAddressValidation(new CustomerBasicValidation());
            //unity.RegisterType<CustomerBase, Customer>("HomeDelivery", new InjectionConstructor(custValidation, "HomeDelivery"));

            //custValidation = new CustomerBillValidation(new CustomerAddressValidation(new PhoneValidation(new CustomerBasicValidation())));
            //unity.RegisterType<CustomerBase, Customer>("Customer", new InjectionConstructor(custValidation, "Customer"));

           

            unity.RegisterType<FactoryBase, FactoryLead>("Lead");
            unity.RegisterType<FactoryBase, FactorySelfService>("SelfService");
            unity.RegisterType<FactoryBase, FactoryHomeDelivery>("HomeDelivery");
            unity.RegisterType<FactoryBase, FactoryCustomer>("Customer");
            return unity;

        }

        public static CustomerBase Create(string Type)
        {
            //Design Pattern :- Lazy loading
            //If can be replaced by using Lazy class (inbuilt)
            //if(customers.Count == 0)
            //{
            //    customers.Add("Customer", new Customer());
            //    customers.Add("Lead", new Lead());
            //}


            //Design Pattern :- RIP Replace if with polymorphism
            //Resol
            FactoryBase factoryBase = ObjectsOfOurProject.Value.Resolve<FactoryBase>(Type);
            return factoryBase.CreateCustomer();
            //return ObjectsOfOurProject.Value.Resolve<AnyType>(Type);
               
        }
    }
}