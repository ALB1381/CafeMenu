using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMenu.Data.Entities.Order;

namespace CafeMenu.Data.Entities.Item
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }


        [Column(TypeName = "nvarchar(60)")]
        public string ItemName { get; set; }


        [Column(TypeName = "nvarchar(160)")]
        public string ItemIngredient { get; set; }


        [Column(TypeName = "nvarchar(80)")]
        public string ItemImage { get; set; }

        public int ItemGroupId { get; set; }

        [ForeignKey("ItemGroupId")]
        public slectlistitem ItemGroup { get; set; }

        public List<ItemExteraOnItemConnection> ItemExteraOnItemConnections { get; set; }

        public List<ItemDifference> ItemDifferences { get; set; }

        public bool IsDeleted { get; set; }

    }
}
