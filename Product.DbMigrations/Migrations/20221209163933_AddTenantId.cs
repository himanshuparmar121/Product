using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DbMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddTenantId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemObjects_Items_ItemId",
                table: "ItemObjects");

            migrationBuilder.DropIndex(
                name: "IX_ItemObjects_ItemId",
                table: "ItemObjects");

            migrationBuilder.AlterColumn<string>(
                name: "UnitOfMeasure",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Items",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LotNumber",
                table: "Items",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ManufacturingDate",
                table: "Items",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ItemObjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ParentItemId",
                table: "ItemObjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentProductId",
                table: "ItemObjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ItemObjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "ItemObjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemObjects_ParentProductId",
                table: "ItemObjects",
                column: "ParentProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemObjects_ProductId",
                table: "ItemObjects",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemObjects_Items_ParentProductId",
                table: "ItemObjects",
                column: "ParentProductId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemObjects_Items_ProductId",
                table: "ItemObjects",
                column: "ProductId",
                principalTable: "Items",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemObjects_Items_ParentProductId",
                table: "ItemObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemObjects_Items_ProductId",
                table: "ItemObjects");

            migrationBuilder.DropIndex(
                name: "IX_ItemObjects_ParentProductId",
                table: "ItemObjects");

            migrationBuilder.DropIndex(
                name: "IX_ItemObjects_ProductId",
                table: "ItemObjects");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LotNumber",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ManufacturingDate",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ParentItemId",
                table: "ItemObjects");

            migrationBuilder.DropColumn(
                name: "ParentProductId",
                table: "ItemObjects");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ItemObjects");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ItemObjects");

            migrationBuilder.AlterColumn<string>(
                name: "UnitOfMeasure",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ItemObjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemObjects_ItemId",
                table: "ItemObjects",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemObjects_Items_ItemId",
                table: "ItemObjects",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
