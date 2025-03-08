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
    public class SubOrderExtraOnItemConnection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConnectionId { get; set; }

        public int SubOrderId { get; set; }

        [Column(TypeName = "tinyint")]
        public int Count { get; set; }

        public int ExteraOnItemId { get; set; }

        [ForeignKey("SubOrderId")]
        public SubOrder SubOrder { get; set; }

        [ForeignKey("ExteraOnItemId")]
        public ExteraOnItem ExteraOnItem { get; set; }
        public bool IsDeleted { get; set; }
    }
}
