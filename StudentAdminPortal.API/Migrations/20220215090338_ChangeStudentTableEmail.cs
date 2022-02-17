using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdminPortal.API.Migrations
{
    public partial class ChangeStudentTableEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Student",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Student",
                newName: "EmailAddress");
        }
    }
}
