using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecoles_informatiques.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeds2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60fb5145-7fa7-4e07-af4d-323a8cb19b39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPk+QzkkQL9UCTnt7ytQhAwrqcZtuXn//4ew15/RNW1GhploP4Q27tA/K1W6UlPjoA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6250adfa-eb23-455b-aea7-494361b7f13f",
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEEXOY9AhrU7GlpjYz2sEqlCIKzTATb6ljJRGtM/ZPAuzZScicbu6WbyyuNUl7gyCPQ==", "test@test.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60fb5145-7fa7-4e07-af4d-323a8cb19b39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKlSarKu3b7SY5zmTJiw/PXGEl44hYib6QB5ky2Ojoop9XtqcSz0Q3CtfAN48/4iaA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6250adfa-eb23-455b-aea7-494361b7f13f",
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEDV5FsUSkQxOUS174ZmRw7BnW/jsI8GLVdguXhJP1fbyev7gdDUIDvXX2xKgtsQLBQ==", "ustest@test.comer" });
        }
    }
}
