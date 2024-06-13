using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecoles_informatiques.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "60fb5145-7fa7-4e07-af4d-323a8cb19b39", 0, "f566d4f1-71db-4e1d-9d2f-0687c115a3bd", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPk+QzkkQL9UCTnt7ytQhAwrqcZtuXn//4ew15/RNW1GhploP4Q27tA/K1W6UlPjoA==", null, false, "OECJYRXF22Y64JSHS5RWDF2M7GYBQE6G", false, "admin" },
                    { "6250adfa-eb23-455b-aea7-494361b7f13f", 0, "be3506fd-2240-41aa-83fa-5ff71692e6e7", "test@test.com", true, false, null, "TEST@TEST.COM", "TEST@TEST.COM", "AQAAAAIAAYagAAAAEEXOY9AhrU7GlpjYz2sEqlCIKzTATb6ljJRGtM/ZPAuzZScicbu6WbyyuNUl7gyCPQ==", null, false, "RVWKTAEQWZLJUJXFHCXUHCQIDDWW27FQ", false, "ustest@test.comer" }
                });

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "Id", "LongLabel", "ShortLabel" },
                values: new object[,]
                {
                    { 1, "Baccalauréat", "Bac" },
                    { 2, "Diplôme de niveau Bac+2", "Bac+2" },
                    { 3, "Diplôme de niveau Bac+3", "Bac+3" },
                    { 4, "Diplôme de niveau Bac+5", "Bac+5" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "City", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "38 Rue des Drs Calmette et Guérin", "Laval", "École d'ingénieurs spécialisée en numérique et cybersécurité", "ESIEA Laval", "esiea-laval" },
                    { 2, "123 Rue de Bretagne", "Laval", "École de commerce offrant des BTS et des Bachelors", "ESUP Laval", "esup-laval" },
                    { 3, "52 Rue des Docteurs Calmette", "Laval", "Institut Universitaire de Technologie", "IUT Laval", "iut-laval" },
                    { 4, "14 Rue de l'Alma", "Laval", "Lycée général et technologique", "Lycée Douanier Rousseau", "lycee-douanier-rousseau" },
                    { 5, "28 Rue des Déportés", "Laval", "Lycée proposant des formations professionnelles et technologiques", "Lycée Réaumur", "lycee-reaumur" },
                    { 6, "5 Boulevard de l'Industrie, Saint-Berthevin", "Laval", "Institut d'Informatique Appliquée spécialisé en informatique et numérique", "IIA Laval", "iia-laval" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "60fb5145-7fa7-4e07-af4d-323a8cb19b39" },
                    { "2", "6250adfa-eb23-455b-aea7-494361b7f13f" }
                });

            migrationBuilder.InsertData(
                table: "Diplomas",
                columns: new[] { "Id", "GradeLevelId", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Diplôme d'ingénieur" },
                    { 2, 4, "Master" },
                    { 3, 3, "Licence" },
                    { 4, 2, "BTS" },
                    { 5, 2, "IUT" }
                });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "ApprenticeshipStatus", "Description", "DiplomaId", "GradeLevelId", "Name", "Price", "SchoolId", "Slug", "StudentStatus" },
                values: new object[,]
                {
                    { 1, true, "Formation en cybersécurité avec spécialisation en systèmes embarqués.", 1, 4, "Ingénierie en Cybersécurité", 5000.0, 1, "ingenierie-cybersecurite", true },
                    { 2, false, "Programme de Bachelor avec des spécialisations en développement logiciel et data science.", 3, 3, "Bachelor en Informatique", 3500.0, 2, "bachelor-informatique", true },
                    { 3, true, "Diplôme Universitaire de Technologie en informatique avec une option en réseaux et télécommunications.", 5, 2, "DUT Informatique", 0.0, 3, "dut-informatique", true },
                    { 4, true, "Brevet de Technicien Supérieur en services informatiques aux organisations.", 4, 2, "BTS Services Informatiques aux Organisations", 0.0, 4, "bts-sio", true },
                    { 5, true, "Licence professionnelle avec des cours avancés en gestion des systèmes d'information.", 3, 3, "Licence Professionnelle en Informatique", 0.0, 5, "licence-pro-informatique", true },
                    { 6, true, "Formation pour devenir développeur web et web mobile, incluant des compétences en front-end et back-end.", 4, 2, "Développeur Web et Web Mobile", 5200.0, 6, "dev-web-mobile", true },
                    { 7, true, "Formation de manager en cybersécurité pour acquérir des compétences avancées en protection des systèmes d'information.", 2, 4, "Manager Cybersécurité", 7500.0, 6, "manager-cybersecurite", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "60fb5145-7fa7-4e07-af4d-323a8cb19b39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "6250adfa-eb23-455b-aea7-494361b7f13f" });

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60fb5145-7fa7-4e07-af4d-323a8cb19b39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6250adfa-eb23-455b-aea7-494361b7f13f");

            migrationBuilder.DeleteData(
                table: "Diplomas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diplomas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diplomas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diplomas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Diplomas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
