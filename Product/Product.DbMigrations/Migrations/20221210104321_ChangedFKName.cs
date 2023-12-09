using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.DbMigrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangedFKName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ParentItemId",
                table: "ItemObjects");

            migrationBuilder.DropColumn(
                name: "ParentProductId",
                table: "ItemObjects");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ItemObjects",
                newName: "ParentItemIdItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemObjects_ProductId",
                table: "ItemObjects",
                newName: "IX_ItemObjects_ParentItemIdItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemObjects_ItemId",
                table: "ItemObjects",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemObjects_Items_ItemId",
                table: "ItemObjects",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemObjects_Items_ParentItemIdItemId",
                table: "ItemObjects",
                column: "ParentItemIdItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemObjects_Items_ItemId",
                table: "ItemObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemObjects_Items_ParentItemIdItemId",
                table: "ItemObjects");

            migrationBuilder.DropIndex(
                name: "IX_ItemObjects_ItemId",
                table: "ItemObjects");

            migrationBuilder.RenameColumn(
                name: "ParentItemIdItemId",
                table: "ItemObjects",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemObjects_ParentItemIdItemId",
                table: "ItemObjects",
                newName: "IX_ItemObjects_ProductId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ItemObjects_ParentProductId",
                table: "ItemObjects",
                column: "ParentProductId");

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
    }
}
