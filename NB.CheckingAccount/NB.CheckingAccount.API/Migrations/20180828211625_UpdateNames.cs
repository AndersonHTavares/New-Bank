﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace NB.CheckingAccount.API.Migrations
{
    public partial class UpdateNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionStatus_StatusID",
                table: "CheckingAccountTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionType_TypeID",
                table: "CheckingAccountTransaction");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "CheckingAccountTransaction",
                newName: "CheckingAccountTransactionTypeID");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "CheckingAccountTransaction",
                newName: "CheckingAccountTransactionStatusID");

            migrationBuilder.RenameIndex(
                name: "IX_CheckingAccountTransaction_TypeID",
                table: "CheckingAccountTransaction",
                newName: "IX_CheckingAccountTransaction_CheckingAccountTransactionTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_CheckingAccountTransaction_StatusID",
                table: "CheckingAccountTransaction",
                newName: "IX_CheckingAccountTransaction_CheckingAccountTransactionStatusID");

            migrationBuilder.UpdateData(
                table: "CheckingAccount",
                keyColumn: "ID",
                keyValue: new Guid("2ebf432e-93db-4471-9585-b02f20d8ce1e"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccount",
                keyColumn: "ID",
                keyValue: new Guid("5919c21f-e390-44ad-841a-58789b893d0c"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("5d6673d8-48b5-4feb-805f-769bea37ceb3"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("72f63d9f-dc92-4507-9bc9-f27bd086b213"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("cae7e4dc-d43f-49cd-bf6c-a0db1707e4c1"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("f226faea-4e74-4826-b757-3374c378c072"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransaction",
                keyColumn: "ID",
                keyValue: new Guid("cdea315f-54f7-4bf9-977a-70b93557bf32"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 830, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 830, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionStatus",
                keyColumn: "ID",
                keyValue: new Guid("000c0e7b-3a34-4612-803b-b6510ddfdb26"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionStatus",
                keyColumn: "ID",
                keyValue: new Guid("d314587d-3edb-4911-8b21-0249b0bb0005"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionStatus",
                keyColumn: "ID",
                keyValue: new Guid("fb45206b-1d23-42c0-8f48-fb663f56b6ea"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionType",
                keyColumn: "ID",
                keyValue: new Guid("0d0c7992-7689-45de-8ae7-96db73eab84f"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionType",
                keyColumn: "ID",
                keyValue: new Guid("30685f6d-f398-46f4-a147-2e99d7ec045a"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionType",
                keyColumn: "ID",
                keyValue: new Guid("fa5af19c-58f5-458b-b887-fd0dc37bd1e1"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountType",
                keyColumn: "ID",
                keyValue: new Guid("1417063b-b22d-4c68-8784-db4d32d9fdb5"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountType",
                keyColumn: "ID",
                keyValue: new Guid("859c7f23-a9d5-4146-9d45-2463aaad46d1"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 828, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "ID",
                keyValue: new Guid("31007805-21e7-401c-834f-723fc441731a"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "ID",
                keyValue: new Guid("6b577276-ddc9-4c8e-896a-eee8396eff82"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc), new DateTime(2018, 8, 28, 21, 16, 24, 829, DateTimeKind.Utc) });

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionStatus_CheckingAccountTransactionStatusID",
                table: "CheckingAccountTransaction",
                column: "CheckingAccountTransactionStatusID",
                principalTable: "CheckingAccountTransactionStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionType_CheckingAccountTransactionTypeID",
                table: "CheckingAccountTransaction",
                column: "CheckingAccountTransactionTypeID",
                principalTable: "CheckingAccountTransactionType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionStatus_CheckingAccountTransactionStatusID",
                table: "CheckingAccountTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionType_CheckingAccountTransactionTypeID",
                table: "CheckingAccountTransaction");

            migrationBuilder.RenameColumn(
                name: "CheckingAccountTransactionTypeID",
                table: "CheckingAccountTransaction",
                newName: "TypeID");

            migrationBuilder.RenameColumn(
                name: "CheckingAccountTransactionStatusID",
                table: "CheckingAccountTransaction",
                newName: "StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_CheckingAccountTransaction_CheckingAccountTransactionTypeID",
                table: "CheckingAccountTransaction",
                newName: "IX_CheckingAccountTransaction_TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_CheckingAccountTransaction_CheckingAccountTransactionStatusID",
                table: "CheckingAccountTransaction",
                newName: "IX_CheckingAccountTransaction_StatusID");

            migrationBuilder.UpdateData(
                table: "CheckingAccount",
                keyColumn: "ID",
                keyValue: new Guid("2ebf432e-93db-4471-9585-b02f20d8ce1e"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccount",
                keyColumn: "ID",
                keyValue: new Guid("5919c21f-e390-44ad-841a-58789b893d0c"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("5d6673d8-48b5-4feb-805f-769bea37ceb3"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("72f63d9f-dc92-4507-9bc9-f27bd086b213"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("cae7e4dc-d43f-49cd-bf6c-a0db1707e4c1"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountStatus",
                keyColumn: "ID",
                keyValue: new Guid("f226faea-4e74-4826-b757-3374c378c072"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransaction",
                keyColumn: "ID",
                keyValue: new Guid("cdea315f-54f7-4bf9-977a-70b93557bf32"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 359, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 359, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionStatus",
                keyColumn: "ID",
                keyValue: new Guid("000c0e7b-3a34-4612-803b-b6510ddfdb26"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionStatus",
                keyColumn: "ID",
                keyValue: new Guid("d314587d-3edb-4911-8b21-0249b0bb0005"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionStatus",
                keyColumn: "ID",
                keyValue: new Guid("fb45206b-1d23-42c0-8f48-fb663f56b6ea"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionType",
                keyColumn: "ID",
                keyValue: new Guid("0d0c7992-7689-45de-8ae7-96db73eab84f"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionType",
                keyColumn: "ID",
                keyValue: new Guid("30685f6d-f398-46f4-a147-2e99d7ec045a"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountTransactionType",
                keyColumn: "ID",
                keyValue: new Guid("fa5af19c-58f5-458b-b887-fd0dc37bd1e1"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 358, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountType",
                keyColumn: "ID",
                keyValue: new Guid("1417063b-b22d-4c68-8784-db4d32d9fdb5"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "CheckingAccountType",
                keyColumn: "ID",
                keyValue: new Guid("859c7f23-a9d5-4146-9d45-2463aaad46d1"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "ID",
                keyValue: new Guid("31007805-21e7-401c-834f-723fc441731a"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "ID",
                keyValue: new Guid("6b577276-ddc9-4c8e-896a-eee8396eff82"),
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc), new DateTime(2018, 8, 28, 19, 23, 50, 357, DateTimeKind.Utc) });

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionStatus_StatusID",
                table: "CheckingAccountTransaction",
                column: "StatusID",
                principalTable: "CheckingAccountTransactionStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingAccountTransaction_CheckingAccountTransactionType_TypeID",
                table: "CheckingAccountTransaction",
                column: "TypeID",
                principalTable: "CheckingAccountTransactionType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
