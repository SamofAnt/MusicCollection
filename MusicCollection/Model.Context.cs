﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicCollection
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Executors> Executors { get; set; }
        public virtual DbSet<MusicDisk> MusicDisk { get; set; }
        public virtual DbSet<Publishers> Publishers { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }
        public virtual DbSet<Styles> Styles { get; set; }
        public virtual DbSet<DisksSongs> DisksSongs { get; set; }
    }
}