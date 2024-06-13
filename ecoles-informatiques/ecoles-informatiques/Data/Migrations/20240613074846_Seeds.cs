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
                    { "1", 0, "ec189e15-c493-41dd-a6a3-7e06d221abab", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEEUUwZdPcSmAhYjoDC+s7SQbQCj3fIfNoTfmifqBkbTN1Zjrz4+RsMH1QyWNMZodqQ==", null, false, "", false, "admin" },
                    { "2", 0, "c152dc2e-f586-4f45-9f8d-59b35b2c8e4c", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER", "AQAAAAIAAYagAAAAEKmZ0V9yI4wMmA0n0mli/SDatImAP5hKe3rsxSByvsTPU1RXV9NMUlKlVvTSG4VoKg==", null, false, "", false, "user" }
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
                    { "1", "1" },
                    { "2", "2" }
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
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

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
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

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
