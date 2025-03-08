using CafeMenu.Data.Entities;
using CafeMenu.Data.Entities.Customer;
using CafeMenu.Data.Entities.History;
using CafeMenu.Data.Entities.Item;
using CafeMenu.Data.Entities.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace CafeMenu.Data.Context
{
    public class CafeContext : DbContext
    {
        public CafeContext(DbContextOptions<CafeContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ExteraOnItem> ExteraOnItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemExteraOnItemConnection> ItemExteraOnItemConnections { get; set; }
        public DbSet<slectlistitem> ItemGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SubOrder> SubOrders { get; set; }
        public DbSet<SubOrderExtraOnItemConnection> SubOrderExtraOnItemConnections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<ItemDifference> ItemDifferences { get; set; }
        public DbSet<DeleteHistory> DeleteHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //10
            //8
            modelBuilder.Entity<MenuType>().HasData(
                new MenuType() { MenuTypeId = 1,MenuTypeTitle = "Cafe"}
                );
            modelBuilder.Entity<slectlistitem>().HasData(
                new slectlistitem() { GroupId = 1, GroupName = "Espresso Base" ,MenuTypeId = 1},
                new slectlistitem() { GroupId = 2, GroupName = "Hot Base", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 3, GroupName = "Iced Base", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 4, GroupName = "Brew Base", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 5, GroupName = "Matcha Base", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 6, GroupName = "Milkshake", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 7, GroupName = "Breakfast", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 8, GroupName = "Bakery", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 9, GroupName = "Fitness", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 10, GroupName = "Brunch", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 11, GroupName = "Mocktail", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 12, GroupName = "Tea and herbal", MenuTypeId = 1 },
                new slectlistitem() { GroupId = 13, GroupName = "Others", MenuTypeId = 1 }
                );
            modelBuilder.Entity<Table>().HasData(
                new Table() {TableId= 1},
                new Table() {TableId= 2},
                new Table() {TableId= 3},
                new Table() {TableId= 4},
                new Table() {TableId= 5},
                new Table() {TableId= 6},
                new Table() {TableId= 7},
                new Table() {TableId= 8},
                new Table() {TableId= 9},
                new Table() {TableId= 10},
                new Table() {TableId= 11},
                new Table() {TableId= 12},
                new Table() {TableId= 13},
                new Table() {TableId= 14},
                new Table() {TableId= 15},
                new Table() {TableId= 16},
                new Table() {TableId= 17},
                new Table() {TableId= 18}
                );
            modelBuilder.Entity<Item>().HasData(new Item()
            {
                ItemId = 1,
                ItemGroupId = 1,
                ItemImage = "https://hooklounge.vip/Media_folder/222/img_222_1624714287.jpg",
                ItemIngredient = "coffe beans",
                ItemName = "Espresso",
            });
            modelBuilder.Entity<ItemDifference>().HasData(new ItemDifference()
            {
                DifferenceId = 1,
                DifferenceTitle = "100% Arabica",
                ItemDifferncePrice = 120000,
                ItemID = 1
            });
            modelBuilder.Entity<ItemDifference>().HasData(new ItemDifference()
            {
                DifferenceId = 2,
                DifferenceTitle = "20% Arabica",
                ItemDifferncePrice = 70000,
                ItemID = 1
            });
            modelBuilder.Entity<ExteraOnItem>().HasData(new ExteraOnItem()
            {
                ExteraOnItemPrice = 20000,
                ExteraTitle = "Ice Cream",
                ExtraId = 1,
                ExteraOnItemDecription = "250gm vanilla ice cream"
            });
            modelBuilder.Entity<ExteraOnItem>().HasData(new ExteraOnItem()
            {
                ExteraOnItemPrice = 40000,
                ExteraTitle = "Cream",
                ExteraOnItemDecription = "200gm Cream",
                ExtraId = 2,
            });
            modelBuilder.Entity<ItemExteraOnItemConnection>().HasData(new ItemExteraOnItemConnection()
            {
               ConnectionId = 1,
               ExteraItemId = 1,
               ItemId = 1,
            });
            modelBuilder.Entity<ItemExteraOnItemConnection>().HasData(new ItemExteraOnItemConnection()
            {
                ConnectionId = 2,
                ExteraItemId = 2,
                ItemId = 1,
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
