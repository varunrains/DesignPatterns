using InterfaceCustomer;
using InterfaceDAL;
using System.Data.Entity;

namespace EntityFrameworkDAL
{
    public class EFUnitOfWork : DbContext, IUow
    {
      
        // public DbContext Context { get; set; }
        public EFUnitOfWork() : base("name=connectionstring")
        {
           // Context = new DbContext("name=connectionstring");
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerBase>().ToTable("tblCustomer");
        }

        public void Commit()
        {
           SaveChanges();
        }

        public void RollBack() //adapter pattern
        {
            RollBack();
        }
    }
}
