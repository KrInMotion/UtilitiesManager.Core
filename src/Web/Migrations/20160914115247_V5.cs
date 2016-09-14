using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Invoices",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Invoices",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Invoices");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Invoices",
                nullable: true);
        }
    }
}
