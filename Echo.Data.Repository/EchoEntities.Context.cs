﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Echo.Data.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EchoEntities : DbContext
    {
        public EchoEntities()
            : base("name=EchoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LogSheet> LogSheet { get; set; }
        public virtual DbSet<LogSheetActivity> LogSheetActivity { get; set; }
        public virtual DbSet<MonthlyAssociationDue> MonthlyAssociationDue { get; set; }
        public virtual DbSet<PaymentHistory> PaymentHistory { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TenantArchive> TenantArchive { get; set; }
        public virtual DbSet<TenantProfile> TenantProfile { get; set; }
        public virtual DbSet<UnitProfile> UnitProfile { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<WaterBilling> WaterBilling { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Request> Request { get; set; }
    }
}
