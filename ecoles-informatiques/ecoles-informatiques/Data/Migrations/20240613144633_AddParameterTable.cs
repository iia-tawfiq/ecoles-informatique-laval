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
                value: "AQAAAAIAAYagAAAAECBA2P9NbBF4EYnzbeOzgLBDnjEYEm7cTMozZhKpUxsSvgf3UgyJ0BcUAD6MEaCUJQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6250adfa-eb23-455b-aea7-494361b7f13f",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBcTkYciWW4JcO+khhM72JhyLQdE4pJqtwld0nLun38kuv22+8lzma89SdbPQV27WA==");
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
