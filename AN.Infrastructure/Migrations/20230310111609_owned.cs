using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class owned : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassengerName",
                table: "Passangers",
                newName: "fullName_firstName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passangers",
                newName: "fullName_lastName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullName_lastName",
                table: "Passangers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fullName_firstName",
                table: "Passangers",
                newName: "PassengerName");
        }
    }
}
