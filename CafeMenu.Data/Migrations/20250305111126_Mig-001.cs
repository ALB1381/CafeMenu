using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeMenu.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tables",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SubOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SubOrderExtraOnItemConnections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MenuTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ItemGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ItemExteraOnItemConnections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ItemDifferences",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ExteraOnItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DeleteHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    DeletedRowId = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteHistories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ExteraOnItems",
                keyColumn: "ExtraId",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ExteraOnItems",
                keyColumn: "ExtraId",
                keyValue: 2,
                columns: new[] { "ExteraOnItemPrice", "IsDeleted" },
                values: new object[] { 40000, false });

            migrationBuilder.UpdateData(
                table: "ItemDifferences",
                keyColumn: "DifferenceId",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemDifferences",
                keyColumn: "DifferenceId",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemExteraOnItemConnections",
                keyColumn: "ConnectionId",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemExteraOnItemConnections",
                keyColumn: "ConnectionId",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)11,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)12,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "GroupId",
                keyValue: (byte)13,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "IsDeleted", "ItemImage" },
                values: new object[] { false, "https://hooklounge.vip/Media_folder/222/img_222_1624714287.jpg" });

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "MenuTypeId",
                keyValue: (byte)1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)11,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)12,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)13,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)14,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)15,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)16,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)17,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: (byte)18,
                column: "IsDeleted",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeleteHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SubOrders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SubOrderExtraOnItemConnections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MenuTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ItemGroups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ItemExteraOnItemConnections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ItemDifferences");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ExteraOnItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "ExteraOnItems",
                keyColumn: "ExtraId",
                keyValue: 2,
                column: "ExteraOnItemPrice",
                value: 20000);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "ItemImage",
                value: "20140425_152813t-900x900.jpg");
        }
    }
}
