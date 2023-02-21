using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionApi.Migrations.ConstructionDb
{
    /// <inheritdoc />
    public partial class AddedPaymentandRequestsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(2986), new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(4453), new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(4793), new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentID", "AddedBy", "AddedOn", "Amount", "AuthCode", "ChangedBy", "ChangedOn", "EntityStatus", "OrderID", "ResponseMessage", "Status" },
                values: new object[] { 1L, "", new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(9472), 250000000.0, null, "", new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(9472), 1, "9c85143b-e7c9-498e-9853-a498b7a5f918", null, 0 });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(7545), new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(9245), new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.InsertData(
                table: "ConstructionRequests",
                columns: new[] { "ConstructionRequestID", "AddedBy", "AddedOn", "ChangedBy", "ChangedOn", "ClientID", "CompanyID", "Description", "EntityStatus", "EstimatedEndDate", "PaymentID", "ProjectID", "Remarks", "StartDate", "StatusID" },
                values: new object[] { 1L, "", new DateTime(2023, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(750), "", new DateTime(2023, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(751), 1L, 1L, "First Request Description", 1, new DateTime(2025, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(1678), 1L, 1L, "First Request Remarks", new DateTime(2023, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(1425), 2L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConstructionRequests",
                keyColumn: "ConstructionRequestID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 34, 19, 373, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 2, 20, 17, 34, 19, 373, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 34, 19, 373, DateTimeKind.Utc).AddTicks(9808), new DateTime(2023, 2, 20, 17, 34, 19, 373, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(100), new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(1288), new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(3045), new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(4808), new DateTime(2023, 2, 20, 17, 34, 19, 374, DateTimeKind.Utc).AddTicks(4809) });
        }
    }
}
