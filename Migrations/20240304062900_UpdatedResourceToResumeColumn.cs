using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplicationDashboard.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedResourceToResumeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Resource",
                table: "Application",
                newName: "Resume");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Resume",
                table: "Application",
                newName: "Resource");
        }
    }
}
