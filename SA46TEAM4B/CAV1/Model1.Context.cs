﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAV1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA46TEAM04B_Sports_SystemEntities1 : DbContext
    {
        public SA46TEAM04B_Sports_SystemEntities1()
            : base("name=SA46TEAM04B_Sports_SystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookingTran> BookingTrans { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<MemberCategory> MemberCategories { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<SlotName> SlotNames { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    }
}
