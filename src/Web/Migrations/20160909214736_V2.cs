using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Debt",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Penalty",
                table: "Invoices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Debt",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Penalty",
                table: "Invoices");
        }
    }
}
