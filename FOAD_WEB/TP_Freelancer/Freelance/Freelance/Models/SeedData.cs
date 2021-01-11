using Freelance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcClientContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcClientContext>>()))
            {
                // Look for any movies.
                if (context.Client.Any())
                {
                    return;   // DB has been seeded
                }

                context.Client.AddRange(
                    new Client
                    {
                        Nom = "Meowstache",
                        Email = "stashy@mail.com"

                    },

                    new Client
                    {
                        Nom = "Nyupont",
                        Email = "m.nyu@mail.com"
                    },

                    new Client
                    {
                        Nom = "Nyoe",
                        Email = "john.nyoe@mail.com"
                    },

                    new Client
                    {
                        Nom = "Chatouillette",
                        Email = "touillette@mail.com"
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
