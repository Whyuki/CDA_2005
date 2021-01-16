using Freelancer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Data
{
    public class MvcFreelancerContext : DbContext
    {
        public MvcFreelancerContext(DbContextOptions<MvcFreelancerContext> options)
            : base(options)
        {
        }

        public DbSet<CategorieClient> CategoriesClient { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Devis> Devis { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }
    }
}
