using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class panssenger_fullname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullName_lastName",
                table: "Passangers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "fullName_firstName",
                table: "Passangers",
                newName: "firstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Passangers",
                newName: "fullName_lastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Passangers",
                newName: "fullName_firstName");
        }
    }
}
