using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Domain.Migrations
{
    public partial class addcolumnForuserregister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "permentAddress",
                table: "UserRegister",
                newName: "sex");

            migrationBuilder.RenameColumn(
                name: "passportNumber",
                table: "UserRegister",
                newName: "secondaryContact");

            migrationBuilder.AddColumn<string>(
                name: "rollnumber",
                table: "UserRegister",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rollnumber",
                table: "UserRegister");

            migrationBuilder.RenameColumn(
                name: "sex",
                table: "UserRegister",
                newName: "permentAddress");

            migrationBuilder.RenameColumn(
                name: "secondaryContact",
                table: "UserRegister",
                newName: "passportNumber");
        }
    }
}
