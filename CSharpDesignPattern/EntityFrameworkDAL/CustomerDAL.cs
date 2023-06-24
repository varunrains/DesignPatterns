using InterfaceCustomer;
using System.Data.Entity;

namespace EntityFrameworkDAL
{
    //This class is no longer required once we implemented the 
    //Unit of work pattern with Repository
    //Because all the mappings will be done in the 
    //Unit of work class
    //public class CustomerDAL : EfDalAbstract<CustomerBase>
    //{
    //    //Provide mapping for the EF code implementation

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        //mapping code
    //        //Only abstract or base class can be mapped and not the interface, open issue with Microsoft
    //        //modelBuilder.Entity<CustomerBase>().ToTable("tblCustomer");
    //        //modelBuilder.Entity<CustomerBase>()
    //        //    .Map<Customer>(m => m.Requires("CustomerType").HasValue("Customer"))
    //        //    .Map<Lead>(m => m.Requires("CustomerType").HasValue("Lead"));
    //        //modelBuilder.Entity<CustomerBase>().Ignore(t => t.CustomerType);
    //    }
    //}
}
