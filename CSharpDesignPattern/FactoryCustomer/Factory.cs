using MiddleLayer;

namespace FactoryCustomer
{
    //Simple factory pattern
    //Where you are outsourcing the object creation work to some other project
    //So that when there is a new customer type you can change
    //in only one place and not many places
    public static class Factory //Design Pattern :- Simple Factory pattern
    {
        private static Lazy<Dictionary<string, CustomerBase>> customers 
            = new Lazy<Dictionary<string, CustomerBase>>(() => SetCustomerTypes());

        static Factory()
        {
            //Eager loading. Not a good practice to follow
            //customers.Add("Customer", new Customer());
            //customers.Add("Lead", new Lead());

        }

        private static Dictionary<string, CustomerBase> SetCustomerTypes()
        {
            var custs = new Dictionary<string, CustomerBase>
            {
                { "Customer", new Customer() },
                { "Lead", new Lead() }
            };

            return custs;
        }

        public static CustomerBase Create(string typeCust)
        {
            //Design Pattern :- Lazy loading
            //If can be replaced by using Lazy class (inbuilt)
            //if(customers.Count == 0)
            //{
            //    customers.Add("Customer", new Customer());
            //    customers.Add("Lead", new Lead());
            //}


            //Design Pattern :- RIP Replace if with polymorphism
            return customers.Value[typeCust];
        }
    }
}