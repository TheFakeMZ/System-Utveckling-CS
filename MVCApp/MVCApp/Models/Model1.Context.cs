﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DiveModel : DbContext
    {
        public DiveModel()
            : base("name=DiveModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Dive> Dives { get; set; }
        public virtual DbSet<DiveChar5> DiveChar5 { get; set; }
        public virtual DbSet<DiveCode1> DiveCode1 { get; set; }
        public virtual DbSet<DiveCode2> DiveCode2 { get; set; }
        public virtual DbSet<PlatformsHeight> PlatformsHeights { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
    }
}
