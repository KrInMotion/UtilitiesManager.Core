using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Sum",
                table: "Invoices",
                nullable: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "Penalty",
                table: "Invoices",
                nullable: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentSum",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Debt",
                table: "Invoices",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Sum",
                table: "Invoices",
                nullable: false);

            migrationBuilder.AlterColumn<double>(
                name: "Penalty",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PaymentSum",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Debt",
                table: "Invoices",
                nullable: true);
        }
    }
}
