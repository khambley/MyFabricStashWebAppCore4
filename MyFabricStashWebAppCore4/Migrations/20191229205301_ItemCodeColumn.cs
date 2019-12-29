using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyFabricStashWebAppCore4.Migrations
{
    public partial class ItemCodeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdated",
                table: "Fabrics",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 29, 14, 53, 1, 587, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 24, 13, 38, 6, 63, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "ItemCode",
                table: "Fabrics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCode",
                table: "Fabrics");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdated",
                table: "Fabrics",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 24, 13, 38, 6, 63, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 29, 14, 53, 1, 587, DateTimeKind.Local));
        }
    }
}
