﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentApi5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flight_passenger");

            migrationBuilder.CreateTable(
                name: "table_flight_passenger",
                columns: table => new
                {
                    flightsFlightId = table.Column<int>(type: "int", nullable: false),
                    passangersPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_flight_passenger", x => new { x.flightsFlightId, x.passangersPassportNumber });
                    table.ForeignKey(
                        name: "FK_table_flight_passenger_MyFlight_flightsFlightId",
                        column: x => x.flightsFlightId,
                        principalTable: "MyFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_table_flight_passenger_Passangers_passangersPassportNumber",
                        column: x => x.passangersPassportNumber,
                        principalTable: "Passangers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_table_flight_passenger_passangersPassportNumber",
                table: "table_flight_passenger",
                column: "passangersPassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_flight_passenger");

            migrationBuilder.CreateTable(
                name: "flight_passenger",
                columns: table => new
                {
                    flightsFlightId = table.Column<int>(type: "int", nullable: false),
                    passangersPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flight_passenger", x => new { x.flightsFlightId, x.passangersPassportNumber });
                    table.ForeignKey(
                        name: "FK_flight_passenger_MyFlight_flightsFlightId",
                        column: x => x.flightsFlightId,
                        principalTable: "MyFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_flight_passenger_Passangers_passangersPassportNumber",
                        column: x => x.passangersPassportNumber,
                        principalTable: "Passangers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_flight_passenger_passangersPassportNumber",
                table: "flight_passenger",
                column: "passangersPassportNumber");
        }
    }
}
