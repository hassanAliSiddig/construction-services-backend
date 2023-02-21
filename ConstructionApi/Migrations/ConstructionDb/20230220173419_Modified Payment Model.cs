using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionApi.Migrations.ConstructionDb
{
    /// <inheritdoc />
    public partial class ModifiedPaymentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResponseMessage",
                table: "Payments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "AuthCode",
                table: "Payments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResponseMessage",
                table: "Payments",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "AuthCode",
                table: "Payments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(5604), new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(7941), new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(8378), new DateTime(2023, 2, 20, 15, 43, 5, 500, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(416), new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(3466), new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(6451), new DateTime(2023, 2, 20, 15, 43, 5, 501, DateTimeKind.Utc).AddTicks(6452) });
        }
    }
}
