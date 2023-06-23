﻿using InterfaceCustomer;
using System.Data.Entity;

namespace EntityFrameworkDAL
{
    public class CustomerDAL : EfDalAbstract<CustomerBase>
    {
        //Provide mapping for the EF code implementation

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //mapping code
            //Only abstract or base class can be mapped and not the interface, open issue with Microsoft
            modelBuilder.Entity<CustomerBase>().ToTable("tblCustomer");
            //modelBuilder.Entity<CustomerBase>()
            //    .Map<Customer>(m => m.Requires("CustomerType").HasValue("Customer"))
            //    .Map<Lead>(m => m.Requires("CustomerType").HasValue("Lead"));
            //modelBuilder.Entity<CustomerBase>().Ignore(t => t.CustomerType);
        }
    }
}
