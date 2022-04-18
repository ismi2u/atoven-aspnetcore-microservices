using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Domain.Common;
using VendorRegistration.Domain.Entities;

namespace VendorRegistration.Infrastructure.Persistence
{
    public class CompanyContext : DbContext
    {

        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Company>().HasKey( x=> x.Id );
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.Entity<Company>().Property(x=> x.CompanyName).IsRequired();
            modelBuilder.Entity<Company>().Property(x => x.CommercialRegistrationNo).IsRequired();
            

            base.OnModelCreating(modelBuilder);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "AtoVen";
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "AtoVen";
                        break;
                }
            }




            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
