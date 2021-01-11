using Freelance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance.Data
{
    public class MvcClientContext : DbContext
    {
        public MvcClientContext(DbContextOptions<MvcClientContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
    }
}
