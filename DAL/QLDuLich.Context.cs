//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLDuLichEntities : DbContext
    {
        public QLDuLichEntities()
            : base("name=QLDuLichEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<AMOUNT> AMOUNTs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<BILL_DETAILS> BILL_DETAILS { get; set; }
        public virtual DbSet<CHECKIN> CHECKINs { get; set; }
        public virtual DbSet<CHECKIN_DETAILS> CHECKIN_DETAILS { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<CUSTOMER_TYPE> CUSTOMER_TYPE { get; set; }
        public virtual DbSet<ROOM> ROOMs { get; set; }
        public virtual DbSet<ROOMTYPE> ROOMTYPEs { get; set; }
        public virtual DbSet<SERVICE> SERVICEs { get; set; }
    }
}
