using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcKnowledgeSystem.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "User",
                nullable: true);
        }
         

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill",
                table: "User");
        }
    }
}
