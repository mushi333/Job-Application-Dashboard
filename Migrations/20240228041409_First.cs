using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplicationDashboard.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<int>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        Company = table.Column<string>(type: "TEXT", nullable: true),
                        Role = table.Column<string>(type: "TEXT", nullable: true),
                        Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                        Resource = table.Column<string>(type: "TEXT", nullable: true),
                        Status = table.Column<string>(type: "TEXT", nullable: true),
                        Other = table.Column<string>(type: "TEXT", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Application");
        }
    }
}
