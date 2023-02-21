using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConstructionApi.Migrations.ConstructionDb
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    UserID = table.Column<long>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedBy = table.Column<string>(type: "TEXT", nullable: false),
                    EntityStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedBy = table.Column<string>(type: "TEXT", nullable: false),
                    EntityStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionRequestStatuses",
                columns: table => new
                {
                    ConstructionRequestStatusID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionRequestStatuses", x => x.ConstructionRequestStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    OrderID = table.Column<string>(type: "TEXT", nullable: false),
                    AuthCode = table.Column<long>(type: "INTEGER", nullable: false),
                    ResponseMessage = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedBy = table.Column<string>(type: "TEXT", nullable: false),
                    EntityStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatuses",
                columns: table => new
                {
                    ProjectStatusID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatuses", x => x.ProjectStatusID);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    ProjectID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EstimatedCompletionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StatusID = table.Column<long>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedBy = table.Column<string>(type: "TEXT", nullable: false),
                    EntityStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_projects_ProjectStatuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "ProjectStatuses",
                        principalColumn: "ProjectStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionRequests",
                columns: table => new
                {
                    ConstructionRequestID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Remarks = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EstimatedEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PaymentID = table.Column<long>(type: "INTEGER", nullable: false),
                    ClientID = table.Column<long>(type: "INTEGER", nullable: false),
                    ProjectID = table.Column<long>(type: "INTEGER", nullable: false),
                    StatusID = table.Column<long>(type: "INTEGER", nullable: false),
                    CompanyID = table.Column<long>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedBy = table.Column<string>(type: "TEXT", nullable: false),
                    EntityStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionRequests", x => x.ConstructionRequestID);
                    table.ForeignKey(
                        name: "FK_ConstructionRequests_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstructionRequests_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstructionRequests_ConstructionRequestStatuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "ConstructionRequestStatuses",
                        principalColumn: "ConstructionRequestStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstructionRequests_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstructionRequests_projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientID", "AddedBy", "AddedOn", "ChangedBy", "ChangedOn", "Email", "EntityStatus", "Name", "Phone", "UserID" },
                values: new object[,]
                {
                    { 1L, "", new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(5604), "", new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(5608), "john.smith@example.com", 1, "John Smith", "555-1234", 2L },
                    { 2L, "", new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(7941), "", new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(7942), "jane.doe@example.com", 1, "Jane Doe", "555-5678", 3L }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "AddedBy", "AddedOn", "Address", "ChangedBy", "ChangedOn", "Email", "EntityStatus", "Name", "Phone" },
                values: new object[,]
                {
                    { 1L, "", new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(8378), "123 Main Street", "", new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(8379), "info@abccompany.com", 1, "ABC Company", "050-555-1234" },
                    { 2L, "", new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(416), "456 Maple Avenue", "", new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(416), "info@xyzcompany.com", 1, "XYZ Company", "050-555-5678" }
                });

            migrationBuilder.InsertData(
                table: "ConstructionRequestStatuses",
                columns: new[] { "ConstructionRequestStatusID", "Name" },
                values: new object[,]
                {
                    { 1L, "Submitted" },
                    { 2L, "Pending Payment" },
                    { 3L, "Payment Successful" },
                    { 4L, "In Progress" },
                    { 5L, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "ProjectStatuses",
                columns: new[] { "ProjectStatusID", "Name" },
                values: new object[,]
                {
                    { 1L, "In Progress" },
                    { 2L, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "ProjectID", "AddedBy", "AddedOn", "Address", "ChangedBy", "ChangedOn", "Description", "EntityStatus", "EstimatedCompletionDate", "Name", "StartDate", "StatusID" },
                values: new object[,]
                {
                    { 1L, "", new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(3466), "123 Al Khan Street", "", new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(3467), "This is the first project", 1, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Mall", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L },
                    { 2L, "", new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(6451), "123 Al Emarat Street", "", new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(6452), "This is the second project", 1, new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al Madina Tower", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Name",
                table: "Clients",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Name",
                table: "Companies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionRequests_ClientID",
                table: "ConstructionRequests",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionRequests_CompanyID",
                table: "ConstructionRequests",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionRequests_PaymentID",
                table: "ConstructionRequests",
                column: "PaymentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionRequests_ProjectID",
                table: "ConstructionRequests",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionRequests_StatusID",
                table: "ConstructionRequests",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionRequestStatuses_Name",
                table: "ConstructionRequestStatuses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_projects_StatusID",
                table: "projects",
                column: "StatusID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstructionRequests");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ConstructionRequestStatuses");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "ProjectStatuses");
        }
    }
}
