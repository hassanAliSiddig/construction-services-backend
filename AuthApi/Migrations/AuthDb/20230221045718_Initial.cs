using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthApi.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthUsers",
                columns: table => new
                {
                    AuthUserID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedBy = table.Column<string>(type: "TEXT", nullable: false),
                    EntityStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthUsers", x => x.AuthUserID);
                });

            migrationBuilder.InsertData(
                table: "AuthUsers",
                columns: new[] { "AuthUserID", "AddedBy", "AddedOn", "ChangedBy", "ChangedOn", "EntityStatus", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1L, "Default", new DateTime(2023, 2, 21, 4, 57, 18, 161, DateTimeKind.Utc).AddTicks(7062), "Default", new DateTime(2023, 2, 21, 4, 57, 18, 161, DateTimeKind.Utc).AddTicks(7557), 1, "P9U@crCnKg8ncv7", 0, "adminSetter" },
                    { 2L, "Default", new DateTime(2023, 2, 21, 4, 57, 18, 161, DateTimeKind.Utc).AddTicks(8031), "Default", new DateTime(2023, 2, 21, 4, 57, 18, 161, DateTimeKind.Utc).AddTicks(8032), 1, "Test(li3nt1.", 2, "TestClient1" },
                    { 3L, "Default", new DateTime(2023, 2, 21, 4, 57, 18, 161, DateTimeKind.Utc).AddTicks(8035), "Default", new DateTime(2023, 2, 21, 4, 57, 18, 161, DateTimeKind.Utc).AddTicks(8035), 1, "Test(li3nt2#", 2, "TestClient2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthUsers_Username",
                table: "AuthUsers",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthUsers");
        }
    }
}
