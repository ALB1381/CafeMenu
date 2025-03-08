using CafeMenu.Data.Entities.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Order
{
    public class SubOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubOrderId { get; set; }

        [Column(TypeName = "tinyint")]
        public int Count { get; set; }




        public int ItemDifferenceId { get; set; }
        public int OrderId { get; set; }

        [ForeignKey("ItemDifferenceId")]
        public Item.ItemDifference ItemDifference { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public bool IsDeleted { get; set; }

        public List<SubOrderExtraOnItemConnection> SubOrderExtraOnItemConnections { get; set; }

    }
}
