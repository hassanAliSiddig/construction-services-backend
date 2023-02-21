using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionApi.Migrations.ConstructionDb
{
    /// <inheritdoc />
    public partial class updatedseededrequestcreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 30, DateTimeKind.Utc).AddTicks(8170), new DateTime(2023, 2, 20, 18, 16, 19, 30, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 30, DateTimeKind.Utc).AddTicks(9611), new DateTime(2023, 2, 20, 18, 16, 19, 30, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 30, DateTimeKind.Utc).AddTicks(9920), new DateTime(2023, 2, 20, 18, 16, 19, 30, DateTimeKind.Utc).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(1085), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "ConstructionRequests",
                keyColumn: "ConstructionRequestID",
                keyValue: 1L,
                columns: new[] { "AddedBy", "AddedOn", "ChangedOn", "EstimatedEndDate", "StartDate" },
                values: new object[] { "TestClient1", new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(5964), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(5965), new DateTime(2025, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(6899), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "OrderID" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(4632), "8f3183ae-1385-4a73-b86b-9dcbdbb4860d" });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(2687), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(4401), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(4401) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "ConstructionRequests",
                keyColumn: "ConstructionRequestID",
                keyValue: 1L,
                columns: new[] { "AddedBy", "AddedOn", "ChangedOn", "EstimatedEndDate", "StartDate" },
                values: new object[] { "", new DateTime(2023, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(1678), new DateTime(2023, 2, 20, 17, 35, 13, 814, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "OrderID" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(9472), new DateTime(2023, 2, 20, 17, 35, 13, 813, DateTimeKind.Utc).AddTicks(9472), "9c85143b-e7c9-498e-9853-a498b7a5f918" });

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
        }
    }
}
