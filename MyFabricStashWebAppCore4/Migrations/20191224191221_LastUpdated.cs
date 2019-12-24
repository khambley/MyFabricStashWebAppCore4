using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyFabricStashWebAppCore4.Migrations
{
    public partial class LastUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Fabrics");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "Fabrics",
                newName: "LastUpdated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastUpdated",
                table: "Fabrics",
                newName: "DateModified");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Fabrics",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
