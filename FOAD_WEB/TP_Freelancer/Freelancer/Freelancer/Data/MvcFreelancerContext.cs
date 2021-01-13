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
    }
}
