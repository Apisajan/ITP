﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinishedGoodManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sampleinventoryEntities : DbContext
    {
        public sampleinventoryEntities()
            : base("name=sampleinventoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SaleOfBiscuit> SaleOfBiscuits { get; set; }
        public virtual DbSet<SalesOfCake> SalesOfCakes { get; set; }
        public virtual DbSet<SalesOfChocalate> SalesOfChocalates { get; set; }
    }
}
