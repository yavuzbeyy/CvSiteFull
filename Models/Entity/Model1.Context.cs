﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Db_CvEntities : DbContext
    {
        public Db_CvEntities()
            : base("name=Db_CvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About_Table> About_Table { get; set; }
        public virtual DbSet<Awards_Table> Awards_Table { get; set; }
        public virtual DbSet<Connection_Table> Connection_Table { get; set; }
        public virtual DbSet<Education_Table> Education_Table { get; set; }
        public virtual DbSet<Experiences_Table> Experiences_Table { get; set; }
        public virtual DbSet<LoginValidation_Table> LoginValidation_Table { get; set; }
        public virtual DbSet<Skills_Table> Skills_Table { get; set; }
        public virtual DbSet<Awards2_Table> Awards2_Table { get; set; }
    }
}
