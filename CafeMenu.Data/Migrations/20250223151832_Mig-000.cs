using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CafeMenu.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "ExteraOnItems",
                columns: table => new
                {
                    ExtraId = table.Column<int>(type: "int", nullable: false),
                    ExteraTitle = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    ExteraOnItemPrice = table.Column<int>(type: "int", nullable: false),
                    ExteraOnItemDecription = table.Column<string>(type: "nvarchar(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExteraOnItems", x => x.ExtraId);
                });

            migrationBuilder.CreateTable(
                name: "MenuTypes",
                columns: table => new
                {
                    MenuTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    MenuTypeTitle = table.Column<string>(type: "nvarchar(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuTypes", x => x.MenuTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroups",
                columns: table => new
                {
                    GroupId = table.Column<byte>(type: "tinyint", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    MenuTypeId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_ItemGroups_MenuTypes_MenuTypeId",
                        column: x => x.MenuTypeId,
                        principalTable: "MenuTypes",
                        principalColumn: "MenuTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderSum = table.Column<int>(type: "int", nullable: false),
                    IsPayed = table.Column<bool>(type: "bit", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "TableId");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    ItemIngredient = table.Column<string>(type: "nvarchar(160)", nullable: false),
                    ItemImage = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    ItemGroupId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_ItemGroups_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemDifferences",
                columns: table => new
                {
                    DifferenceId = table.Column<int>(type: "int", nullable: false),
                    DifferenceTitle = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    ItemDifferncePrice = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDifferences", x => x.DifferenceId);
                    table.ForeignKey(
                        name: "FK_ItemDifferences_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemExteraOnItemConnections",
                columns: table => new
                {
                    ConnectionId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ExteraItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemExteraOnItemConnections", x => x.ConnectionId);
                    table.ForeignKey(
                        name: "FK_ItemExteraOnItemConnections_ExteraOnItems_ExteraItemId",
                        column: x => x.ExteraItemId,
                        principalTable: "ExteraOnItems",
                        principalColumn: "ExtraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemExteraOnItemConnections_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubOrders",
                columns: table => new
                {
                    SubOrderId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<byte>(type: "tinyint", nullable: false),
                    ItemDifferenceId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOrders", x => x.SubOrderId);
                    table.ForeignKey(
                        name: "FK_SubOrders_ItemDifferences_ItemDifferenceId",
                        column: x => x.ItemDifferenceId,
                        principalTable: "ItemDifferences",
                        principalColumn: "DifferenceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubOrderExtraOnItemConnections",
                columns: table => new
                {
                    ConnectionId = table.Column<int>(type: "int", nullable: false),
                    SubOrderId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<byte>(type: "tinyint", nullable: false),
                    ExteraOnItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOrderExtraOnItemConnections", x => x.ConnectionId);
                    table.ForeignKey(
                        name: "FK_SubOrderExtraOnItemConnections_ExteraOnItems_ExteraOnItemId",
                        column: x => x.ExteraOnItemId,
                        principalTable: "ExteraOnItems",
                        principalColumn: "ExtraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubOrderExtraOnItemConnections_SubOrders_SubOrderId",
                        column: x => x.SubOrderId,
                        principalTable: "SubOrders",
                        principalColumn: "SubOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExteraOnItems",
                columns: new[] { "ExtraId", "ExteraOnItemDecription", "ExteraOnItemPrice", "ExteraTitle" },
                values: new object[,]
                {
                    { 1, "250gm vanilla ice cream", 20000, "Ice Cream" },
                    { 2, "200gm Cream", 20000, "Cream" }
                });

            migrationBuilder.InsertData(
                table: "MenuTypes",
                columns: new[] { "MenuTypeId", "MenuTypeTitle" },
                values: new object[] { (byte)1, "Cafe" });

            migrationBuilder.InsertData(
                table: "Tables",
                column: "TableId",
                values: new object[]
                {
                    (byte)1,
                    (byte)2,
                    (byte)3,
                    (byte)4,
                    (byte)5,
                    (byte)6,
                    (byte)7,
                    (byte)8,
                    (byte)9,
                    (byte)10,
                    (byte)11,
                    (byte)12,
                    (byte)13,
                    (byte)14,
                    (byte)15,
                    (byte)16,
                    (byte)17,
                    (byte)18
                });

            migrationBuilder.InsertData(
                table: "ItemGroups",
                columns: new[] { "GroupId", "GroupName", "MenuTypeId" },
                values: new object[,]
                {
                    { (byte)1, "Espresso Base", (byte)1 },
                    { (byte)2, "Hot Base", (byte)1 },
                    { (byte)3, "Iced Base", (byte)1 },
                    { (byte)4, "Brew Base", (byte)1 },
                    { (byte)5, "Matcha Base", (byte)1 },
                    { (byte)6, "Milkshake", (byte)1 },
                    { (byte)7, "Breakfast", (byte)1 },
                    { (byte)8, "Bakery", (byte)1 },
                    { (byte)9, "Fitness", (byte)1 },
                    { (byte)10, "Brunch", (byte)1 },
                    { (byte)11, "Mocktail", (byte)1 },
                    { (byte)12, "Tea and herbal", (byte)1 },
                    { (byte)13, "Others", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "ItemGroupId", "ItemImage", "ItemIngredient", "ItemName" },
                values: new object[] { 1, (byte)1, "20140425_152813t-900x900.jpg", "coffe beans", "Espresso" });

            migrationBuilder.InsertData(
                table: "ItemDifferences",
                columns: new[] { "DifferenceId", "DifferenceTitle", "ItemDifferncePrice", "ItemID" },
                values: new object[,]
                {
                    { 1, "100% Arabica", 120000, 1 },
                    { 2, "20% Arabica", 70000, 1 }
                });

            migrationBuilder.InsertData(
                table: "ItemExteraOnItemConnections",
                columns: new[] { "ConnectionId", "ExteraItemId", "ItemId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDifferences_ItemID",
                table: "ItemDifferences",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemExteraOnItemConnections_ExteraItemId",
                table: "ItemExteraOnItemConnections",
                column: "ExteraItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemExteraOnItemConnections_ItemId",
                table: "ItemExteraOnItemConnections",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroups_MenuTypeId",
                table: "ItemGroups",
                column: "MenuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemGroupId",
                table: "Items",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOrderExtraOnItemConnections_ExteraOnItemId",
                table: "SubOrderExtraOnItemConnections",
                column: "ExteraOnItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOrderExtraOnItemConnections_SubOrderId",
                table: "SubOrderExtraOnItemConnections",
                column: "SubOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOrders_ItemDifferenceId",
                table: "SubOrders",
                column: "ItemDifferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOrders_OrderId",
                table: "SubOrders",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemExteraOnItemConnections");

            migrationBuilder.DropTable(
                name: "SubOrderExtraOnItemConnections");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ExteraOnItems");

            migrationBuilder.DropTable(
                name: "SubOrders");

            migrationBuilder.DropTable(
                name: "ItemDifferences");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "ItemGroups");

            migrationBuilder.DropTable(
                name: "MenuTypes");
        }
    }
}
