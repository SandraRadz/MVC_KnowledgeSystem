using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcKnowledgeSystem.Models;

namespace MvcKnowledgeSystem.Models
{
    public class MvcKnowledgeSystemContext : DbContext
    {
        public MvcKnowledgeSystemContext (DbContextOptions<MvcKnowledgeSystemContext> options)
            : base(options)
        {
        }

        public DbSet<MvcKnowledgeSystem.Models.User> User { get; set; }

        public DbSet<MvcKnowledgeSystem.Models.Skill> Skill { get; set; }

        public DbSet<MvcKnowledgeSystem.Models.Skillf> Skillf { get; set; }
    }
}
