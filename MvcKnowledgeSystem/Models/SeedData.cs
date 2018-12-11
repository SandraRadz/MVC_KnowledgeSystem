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
                if(context.Skillf.Any() && context.User.Any())
                {
                    return;
                }

                if (!context.Skillf.Any()) {
                    context.Skillf.AddRange(
                        new Skillf
                        {
                            SkillId = 1,
                            Name = "C#"
                        },

                        new Skillf
                        {
                            SkillId = 2,
                            Name = "C++"
                        },

                        new Skillf
                        {
                            SkillId = 3,
                            Name = "C"
                        },

                        new Skillf
                        {
                            SkillId = 4,
                            Name = "Java"
                        },

                        new Skillf
                        {
                            SkillId = 5,
                            Name = "SQL"
                        }
                        );
                }

   // Look for any movies.
                if (!context.User.Any())
                {
                    context.User.AddRange(
                     new User
                     {
                         name = "Alise May",
                         role = "student",
                         Skill= "C++",
                         login = "Alise",
                         password ="1212"
                     },

                     new User
                     {
                         name = "Tom Cat",
                         role = "admin",
                         Skill = "Java",
                         login = "cat",
                         password = "1234"
                     },

                     new User
                     {
                         name = "Oleksandra Radzievska",
                         role = "admin",
                         Skill = "C#",
                         login = "SandraRadz",
                         password = "1998"
                     },

                   new User
                   {
                       name = "Maryna",
                       role = "student",
                       Skill = "C",
                       login = "Mari",
                       password = "0000"
                   }
                );
                }

                
                context.SaveChanges();
            }
        }
    }
}
