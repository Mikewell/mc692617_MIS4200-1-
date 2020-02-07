using mc692617_MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.DAL
{
    public class MIS4200Context: DbContext
    {
        //Set Initializer

        public MIS4200Context() : base ("name=DefaultConnection")
        {                       // this method is a constructor and is called when a new contact is created
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, mc692617_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet <Vet> Vets { get; set; }
        public DbSet <Pet> Pets { get; set; }
        public DbSet <Visits> Visits { get; set; }
        public DbSet <Owner> Owners { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}