using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecoles_informatiques.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigrationFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diplomas_GradeLevels_GradelevelsId",
                table: "Diplomas");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_GradeLevels_MinimumGradeId",
                table: "Formations");

            migrationBuilder.RenameColumn(
                name: "MinimumGradeId",
                table: "Formations",
                newName: "GradeLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Formations_MinimumGradeId",
                table: "Formations",
                newName: "IX_Formations_GradeLevelId");

            migrationBuilder.RenameColumn(
                name: "GradelevelsId",
                table: "Diplomas",
                newName: "GradeLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Diplomas_GradelevelsId",
                table: "Diplomas",
                newName: "IX_Diplomas_GradeLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diplomas_GradeLevels_GradeLevelId",
                table: "Diplomas",
                column: "GradeLevelId",
                principalTable: "GradeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_GradeLevels_GradeLevelId",
                table: "Formations",
                column: "GradeLevelId",
                principalTable: "GradeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diplomas_GradeLevels_GradeLevelId",
                table: "Diplomas");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_GradeLevels_GradeLevelId",
                table: "Formations");

            migrationBuilder.RenameColumn(
                name: "GradeLevelId",
                table: "Formations",
                newName: "MinimumGradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Formations_GradeLevelId",
                table: "Formations",
                newName: "IX_Formations_MinimumGradeId");

            migrationBuilder.RenameColumn(
                name: "GradeLevelId",
                table: "Diplomas",
                newName: "GradelevelsId");

            migrationBuilder.RenameIndex(
                name: "IX_Diplomas_GradeLevelId",
                table: "Diplomas",
                newName: "IX_Diplomas_GradelevelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diplomas_GradeLevels_GradelevelsId",
                table: "Diplomas",
                column: "GradelevelsId",
                principalTable: "GradeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_GradeLevels_MinimumGradeId",
                table: "Formations",
                column: "MinimumGradeId",
                principalTable: "GradeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
