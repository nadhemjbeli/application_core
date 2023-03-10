using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OnDeleteSetNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
