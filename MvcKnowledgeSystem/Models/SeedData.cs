using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcKnowledgeSystem.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcKnowledgeSystemContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcKnowledgeSystemContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                     new User
                     {
                         name = "Alise May",
                         role = "student",
                         login = "Alise",
                         password ="1212"
                     },

                     new User
                     {
                         name = "Tom Cat",
                         role = "admin",
                         login = "cat",
                         password = "1234"
                     },

                     new User
                     {
                         name = "Oleksandra Radzievska",
                         role = "admin",
                         login = "SandraRadz",
                         password = "1998"
                     },

                   new User
                   {
                       name = "Maryna",
                       role = "student",
                       login = "Mari",
                       password = "0000"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
