﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcKnowledgeSystem.Models;

namespace MvcKnowledgeSystem.Migrations
{
    [DbContext(typeof(MvcKnowledgeSystemContext))]
    [Migration("20181211143919_NewUser")]
    partial class NewUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcKnowledgeSystem.Models.Skill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("MvcKnowledgeSystem.Models.Skillf", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("SkillId");

                    b.ToTable("Skillf");
                });

            modelBuilder.Entity("MvcKnowledgeSystem.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Skill");

                    b.Property<string>("login");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<string>("role");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MvcKnowledgeSystem.Models.Userf", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SkillId");

                    b.Property<string>("login");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<string>("role");

                    b.HasKey("UserId");

                    b.ToTable("Userf");
                });
#pragma warning restore 612, 618
        }
    }
}
