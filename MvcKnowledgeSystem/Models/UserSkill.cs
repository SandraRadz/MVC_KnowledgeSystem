using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcKnowledgeSystem.Models
{
  
    public class UserSkill
    {
        public int ID { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }

    public class SystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EFCore-SchoolDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSkill>().HasKey(sc => new { sc.UserId, sc.SkillId });

            modelBuilder.Entity<UserSkill>()
               .HasOne<User>(sc => sc.User)
               .WithMany(s => s.UserSkills)
               .HasForeignKey(sc => sc.ID);

/*
            modelBuilder.Entity<UserSkill>()
                .HasOne<Skill>(sc => sc.Skill)
                .WithMany(s => s.UserSkills)
                .HasForeignKey(sc => sc.ID);
                */
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
    }
}
