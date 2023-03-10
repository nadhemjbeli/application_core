using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OnDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneId",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneId",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
