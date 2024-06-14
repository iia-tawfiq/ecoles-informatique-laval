using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecoles_informatiques.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddParameterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60fb5145-7fa7-4e07-af4d-323a8cb19b39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELmwpdXnMyoLlQ+JEtCa3jLKBq7pd/S4eUcCy4imrZcJ3LTaTLPqSRP+OYWsiLeFOw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6250adfa-eb23-455b-aea7-494361b7f13f",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIlypOGk1n8RfW5Dgqbjcj8eueMeL9PHpxGT4N6wUZynbidIay4Ut+aWJusiPM1BPg==");
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
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDV5FsUSkQxOUS174ZmRw7BnW/jsI8GLVdguXhJP1fbyev7gdDUIDvXX2xKgtsQLBQ==");
        }
    }
}
