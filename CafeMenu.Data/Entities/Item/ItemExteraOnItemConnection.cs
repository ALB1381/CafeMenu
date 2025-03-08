using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Item
{
    public class ItemExteraOnItemConnection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConnectionId { get; set; }

        public int ItemId { get; set; }

        public int ExteraItemId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        [ForeignKey("ExteraItemId")]
        public ExteraOnItem ExteraOnItem { get; set; }
        public bool IsDeleted { get; set; }
    }
}
