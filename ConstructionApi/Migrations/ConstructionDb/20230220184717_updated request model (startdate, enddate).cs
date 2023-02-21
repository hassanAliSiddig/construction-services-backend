using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionApi.Migrations.ConstructionDb
{
    /// <inheritdoc />
    public partial class updatedrequestmodelstartdateenddate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "ConstructionRequests",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EstimatedEndDate",
                table: "ConstructionRequests",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(6852), new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8556), new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8824), new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(219), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "ConstructionRequests",
                keyColumn: "ConstructionRequestID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "EstimatedEndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(5879), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(7117), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "OrderID" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4388), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4388), "24d8e199-b06a-4a68-acc7-bf7faf6a8212" });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(2034), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4144), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4145) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "ConstructionRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EstimatedEndDate",
                table: "ConstructionRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

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
                columns: new[] { "AddedOn", "ChangedOn", "EstimatedEndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(5964), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(5965), new DateTime(2025, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(6899), new DateTime(2023, 2, 20, 18, 16, 19, 31, DateTimeKind.Utc).AddTicks(6644) });

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
    }
}
