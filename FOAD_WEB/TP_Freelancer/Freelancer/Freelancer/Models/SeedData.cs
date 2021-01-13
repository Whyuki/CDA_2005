using Freelancer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFreelancerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFreelancerContext>>()))
            {
                // Look for any category
                if (context.CategoriesClient.Any())
                {
                    return;   // DB has been seeded
                }

                context.CategoriesClient.AddRange(
                    new CategorieClient
                    {
                        Nom = "Particulier",
                        Description = "Mr et Mme ToutLeMonde"
                    },

                     new CategorieClient
                     {
                         Nom = "Entreprise",
                         Description = "Unité économique, juridiquement autonome dont la fonction principale est de produire des biens ou des services pour le marché"
                     }, 
                     
                     new CategorieClient
                     {
                         Nom = "Association",
                         Description = "À but non lucratif"
                     },
                     
                     new CategorieClient
                     {
                         Nom = "Secteur public",
                         Description = "Principalement dirigé par l'État"
                     }


                );
                context.SaveChanges();
            }
        }
    }
}
